﻿using Microsoft.AspNetCore.Mvc;


namespace Presensi360.Controllers
{
    public class CompaniesController : Controller
    {
        
        public async Task<IActionResult> Index()
        {
            
            return View();
        }

        public async Task<IActionResult> Edit(int id)
        {

            return View();
        }
    }
}
