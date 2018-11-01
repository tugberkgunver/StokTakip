using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities.ViewModels
{
   public class ProductCategoryModel
    {
        public int SelectedCategoryId { get; set; }
        public StokTakipUrun Product { get; set; }
        public List<StokTakipUrun> Products { get; set; }
    }
}
