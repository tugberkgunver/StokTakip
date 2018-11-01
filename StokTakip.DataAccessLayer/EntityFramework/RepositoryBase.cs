using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.DataAccessLayer.EntityFramework
{
   public class RepositoryBase
    {
        protected static DatabaseContext context;
        private static object locker = new object();

        //Burada protected yaptık tekrar tekrar newlenmesini istemiyoruz.
        protected RepositoryBase()
        {
            CreateContext();
        }

        //Burada DatabaseContext'in kontrolünü gerçekleştirdik. Ve Singleton Pattern Kullanmış olduk.
        private static void CreateContext()
        {
            if (context == null)
            {
                //MultiThread uygulamalarda iki iş parçacığı bu if'e girebilir.
                //Bu yüzden lock ile kitleme yapılır.
                lock (locker)
                {
                    context = new DatabaseContext();
                }


            }


        }
    }
}
