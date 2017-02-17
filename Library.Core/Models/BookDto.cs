using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.Utilities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Library.Core.Models
{
    public class BookDto
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public DateTime ReleasedAt { get; set; }
        [Required]
        public Genres GenreId { get; set; }

        public string Genre => GenreId.GetAttributeOfType<DescriptionAttribute>().Description;

        public bool IsBorrowed { get; set; }

        public List<BorrowsHistoryDto> BorrowedHistory { get; set; }
    }
}
