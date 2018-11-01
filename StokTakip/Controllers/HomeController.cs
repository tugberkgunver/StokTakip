using StokTakip.BusinessLayer;
using StokTakip.Entities;
using StokTakip.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StokTakip.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        UserManager um = new UserManager();
        ProductManager pm = new ProductManager();
        CategoryManager cm = new CategoryManager();


        public ActionResult Index()
        {
           

            return View();
        }

       

        public ActionResult KategoriEkle()
        {
            CategoryViewModel category = new CategoryViewModel();
            category.kategoriler = cm.GetCategories();
            

            return View(category);
        }



        [HttpPost]
        public ActionResult KategoriEkle(CategoryViewModel gelenkategori)
        {


            StokTakipKategori stk = new StokTakipKategori();
            stk.KategoriAdi = gelenkategori.kategori.KategoriAdi;

            if (ModelState.IsValid)
            {


                BusinessLayerResult<StokTakipKategori> res = cm.AddCategory(stk);

                if (res.Errors.Count > 0)
                {
                    res.Errors.ForEach(x => ModelState.AddModelError("", x));
                    return View(gelenkategori);
                }



                return RedirectToAction("RegisterOK");
            }

            return View();
        }

        public ActionResult UrunEkle()
        {

            ViewBag.CategoryData = new SelectList(cm.GetCategories(), "Id", "KategoriAdi");
            ProductCategoryModel pcm = new ProductCategoryModel();
            pcm.Products = pm.GetProducts();


            return View(pcm);
        }

        [HttpPost]
        public ActionResult UrunEkle(ProductCategoryModel pr)
        {
       
            StokTakipUrun data = pr.Product;
            pr.Product.Kategori_Id =pr.SelectedCategoryId ;

            if (ModelState.IsValid)
            {

                 
                BusinessLayerResult<ProductCategoryModel> res = pm.AddProduct(pr);

                if (res.Errors.Count > 0)
                {
                    res.Errors.ForEach(x => ModelState.AddModelError("", x));
                    return View(data);
                }



                return RedirectToAction("RegisterOK");
            }

            return View();
        }

        public ActionResult UrunDuzenle(int id)
        {
            StokTakipUrun stu = pm.FindProduct(id);
           

            return View(stu);
        }

        [HttpPost]
        public ActionResult UrunDuzenle(StokTakipUrun UpdateUrun)
        {
            if (UpdateUrun != null)
            {
                pm.UpdateProduct(UpdateUrun);
            }

            return View();
        }

        public ActionResult UrunSil(int? id)
        {
            pm.DeleteProduct(id);
            return RedirectToAction("UrunEkle");
        }


     

        public ActionResult RegisterOK()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                
                BusinessLayerResult<StokTakipUser> res = um.LoginUser(model);

                if (res.Errors.Count > 0)
                {
                    res.Errors.ForEach(x => ModelState.AddModelError("", x));
                    return View(model);
                }

                Session["login"] = res.Result;
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}