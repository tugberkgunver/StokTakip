using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities
{
    [Table("Urunler")]
    public class StokTakipUrun : MyEntityBase
    {
        public string BarkodNo { get; set; }
        public string UrunAdi { get; set; }
        public int AlisFiyat { get; set; }
        public int SatisFiyat { get; set; }
        public int KdvOrani { get; set; }
        public int StokMiktari { get; set; }
        public string OlcuBirimi { get; set; }
        public int Kategori_Id { get; set; }

        public virtual StokTakipKategori Kategori { get; set; }
        public virtual List<StokTakipSatis> Satislar { get; set; }
    }
}
