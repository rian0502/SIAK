﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Presensi360.Providers;

namespace Presensi360.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PeriodsController : Controller
    {
        private readonly PeriodService _periodService;

        public PeriodsController(PeriodService periodService)
        {
            _periodService = periodService;
        }
        // GET: PeriodsController
        public async Task<ActionResult> Index()
        {
            var periods = await _periodService.FindAll();
            return View(periods);
        }

        // GET: PeriodsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PeriodsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PeriodsController/Create
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

        // GET: PeriodsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PeriodsController/Edit/5
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

        // GET: PeriodsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PeriodsController/Delete/5
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
