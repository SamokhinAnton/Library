using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Core.Utilities
{
    public static class DataGridViewHelper
    {
        public static void SetGridRows(DataGridView dgr, IEnumerable<BookDto> books)
        {
            dgr.Rows.Clear();
            dgr.Refresh();
            foreach (var book in books)
            {
                var a = dgr.Rows
                    .Add(book.Id,
                    book.Title,
                    book.Author,
                    book.ReleasedAt,
                    book.Genre,
                    book.IsBorrowed);
            }
        }

        public async static Task Remove(DataGridView dgv, DataGridViewCellEventArgs e, IBookRepositoryAsync<BookDto> repository)
        {
            if (e.ColumnIndex == dgv.Columns["Remove"].Index)
            {
                var id = (int)dgv.Rows[e.RowIndex].Cells["BookId"].Value;
                await repository.RemoveBookAsync(id);
                dgv.Rows.RemoveAt(e.RowIndex);
            }
        }

        public static void SetColumns(DataGridView dgv, DataGridViewCellEventHandler dataGridView_btnClick, params string[] buttonNames)
        {
            dgv.Columns.Add("BookId", "BookId");
            dgv.Columns.Add("Title", "Title");
            dgv.Columns.Add("Author", "Author");
            dgv.Columns.Add("Release", "Release");
            dgv.Columns.Add("Genre", "Genre");
            dgv.Columns.Add("IsBorrowed", "IsBorrowed");
            AddColumnButtonsToGrid(dgv, buttonNames);
            dgv.CellClick += dataGridView_btnClick;
        }

        private static void AddColumnButtonsToGrid(DataGridView dgv, params string[] buttonNames)
        {
            foreach (var button in buttonNames)
            {
                var buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = button;
                buttonColumn.Text = button;
                buttonColumn.DataPropertyName = button;
                buttonColumn.UseColumnTextForButtonValue = true;
                dgv.Columns.Add(buttonColumn);
            }
        }
    }
}
