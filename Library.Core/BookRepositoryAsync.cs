using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Core
{
    public class BookRepositoryAsync : IBookRepositoryAsync<BookDto>
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["Library"].ConnectionString;

        public async Task CreateBookAsync(BookDto book)
        {
            string sql = "exec [dbo].[CreateBook] @title, @author, @releasedAt, @genre";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = sql;
                command.Parameters.AddWithValue("title", book.Title);
                command.Parameters.AddWithValue("author", book.Author);
                command.Parameters.AddWithValue("releasedAt", book.ReleasedAt);
                command.Parameters.AddWithValue("genre", book.GenreId);
                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task<IEnumerable<BookDto>> GetBooksAsync()
        {
            var books = new List<BookDto>();
            string sql = "exec [dbo].[GetAllBooks]";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = sql;
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        var book = await Task.Run(() => BookParserFromReader(reader));
                        books.Add(book);
                    }
                }
                return books;
            }
        }

        public async Task RemoveBookAsync(int id)
        {
            string sql = "exec [dbo].[RemoveBook] @bookId";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = sql;
                command.Parameters.AddWithValue("bookId", id);
                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task<IEnumerable<BookDto>> SearchBooksAsync(string pattern, int genre = 255)
        {
            var books = new List<BookDto>();
            string sql = "exec [dbo].[SearchBook] @pattern, @genre";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = sql;
                command.Parameters.AddWithValue("pattern", pattern);
                command.Parameters.AddWithValue("genre", genre);
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        var book = await Task.Run(() => BookParserFromReader(reader));
                        books.Add(book);
                    }
                }
                return books;
            }
        }

        public BookDto BookParserFromReader(SqlDataReader reader)
        {
            var book = new BookDto()
            {
                Id = reader.GetInt32(0),
                Title = reader.GetString(1),
                Author = reader.GetString(2),
                ReleasedAt = reader.GetDateTime(3),
                GenreId = (Genres)Enum.Parse(typeof(Genres), reader.GetByte(4).ToString()),
                IsBorrowed = reader.GetBoolean(5)
            };
            return book;
        }

        public async Task BorrowBookAsync(int bookId)
        {
            string sql = "exec [dbo].[BorrowBook] @bookId";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = sql;
                command.Parameters.AddWithValue("bookId", bookId);
                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task ReturnBookAsync(int bookId)
        {
            string sql = "exec [dbo].[ReturnBook] @bookId";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = sql;
                command.Parameters.AddWithValue("bookId", bookId);
                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task<BookDto> GetBorrowsHistoryAsync(int bookId)
        {
            string sql = "exec [dbo].[GetBorrowsHistory] @bookId";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {

                connection.Open();
                command.CommandText = sql;
                command.Parameters.AddWithValue("bookId", bookId);
                using (var reader = await command.ExecuteReaderAsync())
                {
                    var book = new BookDto() { BorrowedHistory = new List<BorrowsHistoryDto>() };
                    while (reader.Read())
                    {
                        book.Title = await reader.GetFieldValueAsync<string>(0);
                        book.Author = await reader.GetFieldValueAsync<string>(1);
                        if(!await reader.IsDBNullAsync(2)) {
                            book.BorrowedHistory.Add(
                            new BorrowsHistoryDto()
                            {
                                BorrowAt = await reader.GetFieldValueAsync<DateTime>(2),
                                ReturnedAt = await reader.IsDBNullAsync(3) ? null : await reader.GetFieldValueAsync<DateTime?>(3)
                            });
                        }
                    }
                    return book;
                }
            }
        }
    }
}
