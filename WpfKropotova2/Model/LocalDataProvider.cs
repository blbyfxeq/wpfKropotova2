using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfKropotova2.Model
{
    public class LocalDataProvider : IDataProvider
    {
        public IEnumerable<Sweet> GetSweets()
        {
            return new Sweet[]{
            new Sweet{Type="Шоколадные", Manufacturer="Степ",Price=50, ShelfLife=new DateTime(2021,4,21), Count=45},
            new Sweet{Type="Карамель", Manufacturer="Контик",Price=37, ShelfLife=new DateTime(2021,4,20), Count=300},
            new Sweet{Type="Мармелад", Manufacturer="Лева",Price=18, ShelfLife=new DateTime(2021,6,24), Count=236}
        };
        }
    }
}
