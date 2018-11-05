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
   public class ProductManager
    {
        private Repository<StokTakipUrun> repo_urun = new Repository<StokTakipUrun>();

        public BusinessLayerResult<ProductCategoryModel> AddProduct(ProductCategoryModel urun)
        {
           

            BusinessLayerResult<ProductCategoryModel> layerResult = new BusinessLayerResult<ProductCategoryModel>();
          
                int dbResult = repo_urun.Insert(new StokTakipUrun()
                {
                    UrunAdi = urun.Product.UrunAdi,
                    AlisFiyat = urun.Product.AlisFiyat,
                    SatisFiyat = urun.Product.SatisFiyat,
                    KdvOrani = urun.Product.KdvOrani,
                    StokMiktari = urun.Product.StokMiktari,
                    OlcuBirimi = "Adet",
                    Kategori_Id= urun.SelectedCategoryId



                });

                if (dbResult > 0)
                {
                    
                }

            return layerResult;

        }

        public List<StokTakipUrun> GetProducts()
        {

            return repo_urun.List();

        }

        public StokTakipUrun FindProduct(int gelenid)
        {
            return repo_urun.Find(x => x.Id == gelenid);
        }

        public List<StokTakipUrun> FindProductByName(string gelenurun)
        {
            return repo_urun.Find2(x => x.UrunAdi.Contains(gelenurun));
        }

        public BusinessLayerResult<StokTakipUrun> UpdateProduct(StokTakipUrun gelenurun)
        {


            BusinessLayerResult<StokTakipUrun> layerResult = new BusinessLayerResult<StokTakipUrun>();
            StokTakipUrun eskiUrun = repo_urun.Find(x => x.Id == gelenurun.Id);

            eskiUrun.UrunAdi = gelenurun.UrunAdi;
            eskiUrun.AlisFiyat = gelenurun.AlisFiyat;
            eskiUrun.StokMiktari = gelenurun.StokMiktari;

            int dbResult = repo_urun.Update(eskiUrun);

            if (dbResult > 0)
            {

            }

            return layerResult;

        }

        public BusinessLayerResult<StokTakipUrun> DeleteProduct(int? gelenurun)
        {

            BusinessLayerResult<StokTakipUrun> layerResult = new BusinessLayerResult<StokTakipUrun>();
            StokTakipUrun urunBul = repo_urun.Find(x => x.Id == gelenurun);

           
            int dbResult = repo_urun.Delete(urunBul);

            if (dbResult > 0)
            {

            }

            return layerResult;

        }



    }
    }

