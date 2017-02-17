using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Models
{
    public class BorrowsHistoryDto
    {
        public DateTime BorrowAt { get; set; }
        public DateTime? ReturnedAt { get; set; }
    }
}
