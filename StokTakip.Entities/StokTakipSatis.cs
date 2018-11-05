using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities
{
    [Table("Satislar")]
    public class StokTakipSatis:MyEntityBase
    {
        public int Adet { get; set; }
        public DateTime SatisTarihi { get; set; }
        public bool SatisTipi { get; set; }
        public int SatilanUrun_Id { get; set; }


    }
}
