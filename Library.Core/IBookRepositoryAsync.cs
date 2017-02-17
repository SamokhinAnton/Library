using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core
{
    public interface IBookRepositoryAsync<T> where T : class
    {
        Task CreateBookAsync(T book);

        Task RemoveBookAsync(int id);

        Task<IEnumerable<T>> GetBooksAsync();

        Task<IEnumerable<T>> SearchBooksAsync(string pattern, int genre = 255);

        Task BorrowBookAsync(int bookId);

        Task ReturnBookAsync(int bookId);

        Task<T> GetBorrowsHistoryAsync(int bookId);
    }
}
