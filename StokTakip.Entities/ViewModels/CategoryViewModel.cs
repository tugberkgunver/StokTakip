using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities.ViewModels
{
   public class CategoryViewModel
    {
       public List<StokTakipKategori> kategoriler { get; set; }
        public StokTakipKategori kategori { get; set; }
    }
}
