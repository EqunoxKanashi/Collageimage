using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Collageimage.Controllers
{
    public class CreateImageController : Controller
    {
        // GET: CreateImage
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Zoom()
        {
            return View();
        }
    }
}