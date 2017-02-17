using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Core
{
    public class HistoryAction : IBookAction
    {
        private IBookRepositoryAsync<BookDto> _repository = new BookRepositoryAsync();
        public async Task Click(DataGridView dgv, DataGridViewCellEventArgs e, int bookId)
        {
            var bookHistory = await _repository.GetBorrowsHistoryAsync(bookId);
            string message = string.Format($"Title - {bookHistory.Title}{Environment.NewLine}Author - {bookHistory.Author}{Environment.NewLine}");
            foreach (var item in bookHistory.BorrowedHistory)
            {
                message += string.Format($"\t Borrowed at - {item.BorrowAt}. Returned at - {item.ReturnedAt}{Environment.NewLine}");
            }
            MessageBox.Show(message);
        }
    }
}
