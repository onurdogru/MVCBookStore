using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using MVCBookStore.Models.Entity;

namespace MVCBookStore.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        DbMVCBookStoreEntities db = new DbMVCBookStoreEntities();
        public ActionResult Index()
        {
            var kategori = db.TBL_KITAPLAR.ToList();

            return View(kategori);
        }
    }
}