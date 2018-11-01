using StokTakip.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.DataAccessLayer.EntityFramework
{
   public class DatabaseContext:DbContext
    {
        public DbSet<StokTakipKategori> Kategoriler { get; set; }
        public DbSet<StokTakipUser> Kullanicilar { get; set; }
        public DbSet<StokTakipUrun> Urunler { get; set; }
        public DbSet<StokTakipSatis> Satislar { get; set; }
       

        public DatabaseContext()
        {
            Database.SetInitializer(new MyInit());
        }
    }
}
