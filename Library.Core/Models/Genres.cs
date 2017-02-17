using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Models
{
    public enum Genres
    {
        [Description("Comedy")]
        Comedy,
        [Description("Drama")]
        Drama,
        [Description("Horror")]
        Horror,
        [Description("Adventure")]
        Adventure,
        [Description("Historical")]
        Historical,
        [Description("Science")]
        Science,
        [Description("Suspense")]
        Suspense,
        [Description("Thriller")]
        Thriller,
        [Description("Fantasy")]
        Fantasy
    }
}
