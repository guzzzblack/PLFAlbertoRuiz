﻿using Microsoft.AspNetCore.Mvc;

namespace ProyectoClase.Controllers
{
    public class PrincipalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
