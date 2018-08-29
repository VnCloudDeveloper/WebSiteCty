using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VNCloudWeb.Controllers
{
    public class CloudServerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}