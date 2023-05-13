using PagedList;
using ShinGin_Shop.Models.EF;
using ShinGin_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShinGin_Shop.Areas.Admin.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Admin/Products
        ApplicationDbContext _db = new ApplicationDbContext();
        public ActionResult Index(int? page, String SearchText)
        {
            var pageSize = 5;
            if (page == null)
            {
                page = 1;
            }
            IEnumerable<Product> items = _db.Products.OrderByDescending(x => x.Id);
            if (!String.IsNullOrEmpty(SearchText))
            {
                items = items.Where(x => x.Alias.Contains(SearchText) || x.Title.Contains(SearchText));
            }
            var pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            items = items.ToPagedList(pageIndex, pageSize);
            ViewBag.PageSize = pageSize;
            ViewBag.Page = page;
            return View(items);
        }

        public ActionResult Create()
        {

            ViewBag.ProductCategory = new SelectList(_db.ProductCategories.ToList(), "Id", "Title");
            return View();
        }
    }
}