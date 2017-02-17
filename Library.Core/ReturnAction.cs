using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Core
{
    public class ReturnAction : IBookAction
    {
        private IBookRepositoryAsync<BookDto> _repository = new BookRepositoryAsync();
        public async Task Click(DataGridView dgv, DataGridViewCellEventArgs e, int bookId)
        {
            if (!(bool)dgv.Rows[e.RowIndex].Cells["IsBorrowed"].Value)
            {
                MessageBox.Show("The book already returned");
            }
            else
            {
                await _repository.ReturnBookAsync(bookId);
                dgv.Rows[e.RowIndex].Cells["IsBorrowed"].Value = false;
            }
        }
    }
}
