﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCore.MongoDB.CRUD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.MongoDB.CRUD.Controllers
{
    public class AlbumController : Controller
    {
        private IAlbumCollection db = new AlbumCollection();

        // GET: AlbumController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AlbumController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AlbumController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AlbumController/Create
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

        // GET: AlbumController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AlbumController/Edit/5
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

        // GET: AlbumController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AlbumController/Delete/5
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
