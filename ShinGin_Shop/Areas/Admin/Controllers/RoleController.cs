﻿using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using ShinGin_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShinGin_Shop.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        // GET: Admin/Role
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Admin/Role
        public ActionResult Index()
        {
            var items = _db.Roles.ToList();
            return View(items);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IdentityRole model)
        {
            if (ModelState.IsValid)
            {
                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(_db));
                roleManager.Create(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
      /*  public ActionResult Edit(int id)
        {
            var item = _db.Roles.Find(id);
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(IdentityRole model)
        {
            if (ModelState.IsValid)
            {
                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(_db));
                roleManager.Update(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }*/
    }
}