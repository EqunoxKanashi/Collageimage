using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Collageimage.Models
{
    public class Image
    {
        public int ImageID { get; set; }
        public string Name { get; set; }
        public DateTime UploadDate { get; set;}
        public byte[] ImageData { get; set; }
    }
}