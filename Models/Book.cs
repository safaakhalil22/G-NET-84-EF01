using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_84_EF01.Models
{
    internal class Book
    {
        #region Book
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ISBN { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int PublishedYear { get; set; }
        public bool InStock { get; set; }
        #endregion
    }
}
