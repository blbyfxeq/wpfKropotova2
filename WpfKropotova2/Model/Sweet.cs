using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfKropotova2.Model
{
    public class Sweet
    {
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public DateTime ShelfLife { get; set; }
        public int Count{ get; set; }
    }
}