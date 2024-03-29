﻿using PagedList;
using ShinGin_Shop.Models;
using ShinGin_Shop.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShinGin_Shop.Areas.Admin.Controllers
{
/*    [Authorize(Roles = "Admin,Staff")]*/
    public class NewsController : Controller
    {
        ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Admin/News
        public ActionResult Index(int? page,String SearchText)
        {
            var pageSize = 5;
            if(page == null)
            {  
                page = 1; 
            }
            IEnumerable<News> items = _db.News.OrderByDescending(x => x.Id);
            if (!String.IsNullOrEmpty(SearchText))
            {
                items = items.Where(x => x.Alias.Contains(SearchText) || x.Title.Contains(SearchText));
            }    
            var pageIndex = page.HasValue ? Convert.ToInt32(page) :1;
            items = items.ToPagedList(pageIndex, pageSize);
            ViewBag.PageSize = pageSize;
            ViewBag.Page = page;
            return View(items);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(News model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedDate = DateTime.Now;
                model.CategoryId = 17;
                model.ModifiedDate = DateTime.Now;
                model.Alias = ShinGin_Shop.Models.Common.Filter.FilterChar(model.Title);
                _db.News.Add(model);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public ActionResult Edit(int id)
        {
            var item = _db.News.Find(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(News model)
        {
            if (ModelState.IsValid)
            {
                model.ModifiedDate = DateTime.Now;
                model.Alias = ShinGin_Shop.Models.Common.Filter.FilterChar(model.Title);
                _db.News.Attach(model);
                _db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = _db.News.Find(id);
            if (item != null)
            {
                _db.News.Remove(item);
                _db.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { susscess = false });
        }
        [HttpPost]
        public ActionResult IsActive(int id)
        {
            var item = _db.News.Find(id);
            if (item != null)
            {
                item.IsActive = !item.IsActive;
                _db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return Json(new { success = true, isActive = item.IsActive });
            }
            return Json(new { susscess = false });
        }
        [HttpPost]
        public ActionResult DeleteAll(string ids)
        {
            if (!string.IsNullOrEmpty(ids))
            {
                var items = ids.Split(',');
                if (items != null && items.Any())
                {
                    foreach (var item in items)
                    {
                        var obj = _db.News.Find(Convert.ToInt32(item));
                        _db.News.Remove(obj);
                        _db.SaveChanges();
                    }
                }
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
    }

}