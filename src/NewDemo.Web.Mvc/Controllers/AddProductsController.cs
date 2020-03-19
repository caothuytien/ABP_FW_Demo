using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewDemo.Controllers;

namespace NewDemo.Web.Controllers
{
    public class AddProductsController : NewDemoControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}