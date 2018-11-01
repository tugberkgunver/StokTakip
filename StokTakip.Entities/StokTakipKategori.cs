using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities
{
    [Table("Kategoriler")]
    public class StokTakipKategori:MyEntityBase
    {
        public string KategoriAdi { get; set; }

        public virtual List<StokTakipUrun> Urunler { get; set; }
    }
}
