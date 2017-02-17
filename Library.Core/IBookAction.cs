using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Core
{
    public interface IBookAction
    {
        Task Click(DataGridView dgv, DataGridViewCellEventArgs e, int bookId);
    }
}
