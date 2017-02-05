using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Collageimage.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(HttpPostedFileBase[] UploadedImage)
        {
            if(UploadedImage.Count() <= 1)
            {

            }

            foreach(var image in UploadedImage)
            {
                if(image.ContentLength > 0)
                {

                }
            }

            //  dose a thing like http://stackoverflow.com/questions/19185848/how-to-save-an-image-to-database-using-mvc-4
            return View();
        }

        [HttpDelete]
        public ActionResult remove(int ImageID)
        {

            //do some delete stuff
            return View();
        }


    }
}