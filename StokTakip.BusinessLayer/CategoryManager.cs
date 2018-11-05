using StokTakip.DataAccessLayer.EntityFramework;
using StokTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BusinessLayer
{
   public class CategoryManager
    {
        Repository<StokTakipKategori> repo_cat = new Repository<StokTakipKategori>();

        public List<StokTakipKategori> GetCategories()
        {

            return repo_cat.List();

        }

        public BusinessLayerResult<StokTakipKategori> AddCategory(StokTakipKategori kategori)
        {


            BusinessLayerResult<StokTakipKategori> layerResult = new BusinessLayerResult<StokTakipKategori>();

            int dbResult = repo_cat.Insert(new StokTakipKategori()
            {
                KategoriAdi = kategori.KategoriAdi



            });

            if (dbResult > 0)
            {

            }

            return layerResult;

        }

        public BusinessLayerResult<StokTakipKategori> DeleteCategory(int? gelenkategori)
        {

            BusinessLayerResult<StokTakipKategori> layerResult = new BusinessLayerResult<StokTakipKategori>();
            StokTakipKategori kategoriBul = repo_cat.Find(x => x.Id == gelenkategori);


            int dbResult = repo_cat.Delete(kategoriBul);

            if (dbResult > 0)
            {

            }

            return layerResult;

        }

        public StokTakipKategori FindProduct(int gelenid)
        {
            return repo_cat.Find(x => x.Id == gelenid);
        }

        public BusinessLayerResult<StokTakipKategori> UpdateProduct(StokTakipKategori gelenKategori)
        {


            BusinessLayerResult<StokTakipKategori> layerResult = new BusinessLayerResult<StokTakipKategori>();
            StokTakipKategori eskiKategori = repo_cat.Find(x => x.Id == gelenKategori.Id);

            eskiKategori.KategoriAdi = gelenKategori.KategoriAdi;
            

            int dbResult = repo_cat.Update(eskiKategori);

            if (dbResult > 0)
            {

            }

            return layerResult;

        }
    }
}
