using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Book_Library_System
{
    class BookInformation
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public string Genre { get; set; }
        public string Langauge { get; set; }
        public string Date { get; set; }
        public byte[] Image { get; set; }


    }
}
