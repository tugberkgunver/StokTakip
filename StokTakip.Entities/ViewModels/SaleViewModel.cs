using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities.ViewModels
{
   public class SaleViewModel
    {
        public List<StokTakipUrun> arananUrunler { get; set; }
        public StokTakipUrun arananUrun { get; set; }
        public int girilenMiktar { get; set; }
    }
}
