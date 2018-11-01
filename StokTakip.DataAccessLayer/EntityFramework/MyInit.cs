using StokTakip.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.DataAccessLayer.EntityFramework
{
   public class MyInit : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            StokTakipUser admin = new StokTakipUser()
            {
                Name = "Alper",
                Surname = "Hayvali",
                Email = "tugberkgunver@gmail.com",
                ActivateGuid = Guid.NewGuid(),
                IsActive = true,
                IsAdmin = true,
                Username = "alperhayvali",
                Password = "123456"
              
            };

            context.Kullanicilar.Add(admin);
            context.SaveChanges();
        }
    }
}
