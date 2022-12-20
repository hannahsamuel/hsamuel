//using Kendo.Mvc.Examples.Models.Gantt;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.Examples.Controllers
{
    public partial class SpreadsheetController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index_Save(string contentType, string base64, string fileName)
        {
            var fileContents = Convert.FromBase64String(base64);

            return File(fileContents, contentType, fileName);
        }




    }
    public partial class TextBoxController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
    }
    public partial class Pie_ChartsController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}