using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyShop.Controllers
{
    public class FileSystemController : Controller
    {
        public IActionResult Index()    
        {
            var files = System.IO.Directory.GetFiles(@"c:\");
            ViewBag.FilesList = files;

            return View(files);
        }
    }
}