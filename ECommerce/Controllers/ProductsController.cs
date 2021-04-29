﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ECommerce.Controllers
{
    public class ProductsController : Controller
    {
        // GET: ProductsController
        public ActionResult Index()
        {
            var products = new[]{
                new Product
                {
                    Id = 1,
                    Name = "Easter Pillow Cover",
                    Description = "Burlap 18 X 18 pillow cover with Easter motif",
                    
                },
                new Product
                {
                    Id = 2,
                    Name = "Summer Pillow Cover",
                    Description = "Burlap 18 X 18 pillow cover with Summer Flowers motif",
                    
                },

                new Product
                {
                    Id = 3,
                    Name = "Throw Blanket",
                    Description = "Yellow 100% Cotton 50\" x 60\" throw blanket",

                },

                new Product
                {
                    Id = 4,
                    Name = "Down Alternative Bed Pillow",
                    Description = "Standard size machine washable medium firm down alternative pillow",

                },
            };
            return View(products);
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
