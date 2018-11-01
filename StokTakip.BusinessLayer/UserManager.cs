using StokTakip.DataAccessLayer.EntityFramework;
using StokTakip.Entities;
using StokTakip.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BusinessLayer
{
   public class UserManager
    {
        private Repository<StokTakipUser> repo_user = new Repository<StokTakipUser>();
       

        public BusinessLayerResult<StokTakipUser> LoginUser(LoginViewModel data)
        {
            BusinessLayerResult<StokTakipUser> layerResult = new BusinessLayerResult<StokTakipUser>();
            layerResult.Result = repo_user.Find(x => x.Username == data.Username && x.Password == data.Password);



            if (layerResult.Result != null)
            {
                if (!layerResult.Result.IsActive)
                {
                    layerResult.Errors.Add("Kullanıcı aktifleştirilmemiştir. Lütfen e-mailinizi kontrol ediniz.");
                }

            }
            else
            {
                layerResult.Errors.Add("Kullanıcı adı yada şifre uyuşmuyor.");

            }
            return layerResult;
        }

        public List<StokTakipUser> GetUsers()
        {
            
           return repo_user.List();
            
        }

    }
}
