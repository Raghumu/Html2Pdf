using Html2Pdf.Models;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Html2Pdf.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult PrintIndexPage()
        {
            return new ViewAsPdf("~/Views/Home/Index.cshtml");
        }
    }
}
