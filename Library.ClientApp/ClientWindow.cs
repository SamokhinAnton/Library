using Library.Core;
using Library.Core.Models;
using Library.Core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.ClientApp
{
    public partial class ClientWindow : Form
    {
        private IBookRepositoryAsync<BookDto> _repository = new BookRepositoryAsync();

        public ClientWindow()
        {
            InitializeComponent();

        }

        private async void ClientWindow_Load(object sender, EventArgs e)
        {
            DataGridViewHelper.SetColumns(dgvList, DataGridView_btnClick, "Borrow", "Return", "History");
            var books = await _repository.GetBooksAsync();
            DataGridViewHelper.SetGridRows(dgvList, books);
        }

        private async void DataGridView_btnClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            var bookId = (int)dgv.Rows[e.RowIndex].Cells["BookId"].Value;
            IBookAction action;
            if (e.ColumnIndex == dgv.Columns["Borrow"].Index)
            {
                action = new BorrowAction();
            } else if (e.ColumnIndex == dgv.Columns["Return"].Index)
            {
                action = new ReturnAction();
            } else
            {
                action = new HistoryAction();
            }
            await action.Click(dgv, e, bookId);
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            var books = await _repository.GetBooksAsync();
            DataGridViewHelper.SetGridRows(dgvList, books);
        }
    }
}
