using ShinGin_Shop.Models;
using ShinGin_Shop.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShinGin_Shop.Areas.Admin.Controllers
{
    public class ProductsCategoryController : Controller
    {
        // GET: Admin/ProductsCategory
        ApplicationDbContext _db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var item = _db.ProductCategories;
            return View(item);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductCategory model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedDate = DateTime.Now;
                model.ModifiedbyDate = DateTime.Now;
                model.Alias = ShinGin_Shop.Models.Common.Filter.FilterChar(model.Title);
                _db.ProductCategories.Add(model);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}