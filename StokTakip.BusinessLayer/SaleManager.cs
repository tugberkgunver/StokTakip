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
    public class SaleManager
    {

        private Repository<StokTakipSatis> repo_satis = new Repository<StokTakipSatis>();
        

        public BusinessLayerResult<SaleViewModel> AddProduct(SaleViewModel urun)
        {


            BusinessLayerResult<SaleViewModel> layerResult = new BusinessLayerResult<SaleViewModel>();

            int dbResult = repo_satis.Insert(new StokTakipSatis()
            {

                SatisTarihi = DateTime.Now,
                SatisTipi = true,
                Adet=urun.girilenMiktar,
                SatilanUrun_Id =urun.arananUrun.Id
                
                

            });



            if (dbResult > 0)
            {
                ProductManager pm = new ProductManager();
                urun.arananUrun.StokMiktari = urun.arananUrun.StokMiktari - urun.girilenMiktar;
                pm.UpdateProduct(urun.arananUrun);

            }

           

            return layerResult;

        }
    }

}
    


    

