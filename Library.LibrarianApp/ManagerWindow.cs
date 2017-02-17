using Library.Core;
using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Core.Utilities;

namespace Library.LibrarianApp
{
    public partial class ManagerWindow : Form
    {
        private IBookRepositoryAsync<BookDto> _repository = new BookRepositoryAsync();

        public ManagerWindow()
        {
            InitializeComponent();
        }

        private void ManagerWindow_Load(object sender, EventArgs e)
        {
            this.bookGenres.DataSource = Enum.GetValues(typeof(Genres));
            DataGridViewHelper.SetColumns(dgvList, DataGridView_btnClick, "Remove");
            DataGridViewHelper.SetColumns(dgvSearch, DataGridView_btnClick, "Remove");
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            var book = new BookDto();
            book.Title = bookTitle.Text;
            book.Author = bookAuthor.Text;
            book.ReleasedAt = bookRelease.Value;
            Genres genre;
            Enum.TryParse<Genres>(bookGenres.SelectedValue.ToString(), out genre);
            book.GenreId = genre;
            await _repository.CreateBookAsync(book);
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            var books = await _repository.GetBooksAsync();
            await Task.Run(() => DataGridViewHelper.SetGridRows(dgvList, books));
        }

        private async void DataGridView_btnClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (string.Equals("dgvList", dgv.Name, StringComparison.OrdinalIgnoreCase))
            {
                await DataGridViewHelper.Remove(dgvList, e, _repository);
            }
            else
            {
                await DataGridViewHelper.Remove(dgvSearch, e, _repository);
            }
            
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var pattern = SearchPattern.Text;
            var genrePattern = Enum.GetValues(typeof(Genres))
                .OfType<Genres>()
                .Where(g => g.GetAttributeOfType<DescriptionAttribute>().Description
                    .ToLower()
                    .Contains(pattern))
                .Select(g => (int?)g)
                .FirstOrDefault();
            var searchedBooks = await _repository.SearchBooksAsync(pattern, genrePattern.HasValue ? genrePattern.Value : 255);
            await Task.Run(() => DataGridViewHelper.SetGridRows(dgvSearch, searchedBooks));
        }
    }
}
