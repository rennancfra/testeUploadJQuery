using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace testeUpload.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Upload()
        {
            for (int i = 0; i < Request.Files.Count; i++)
            {
                HttpPostedFileBase file = Request.Files[i]; //Uploaded file
                                                            //Use the following properties to get file's name, size and MIMEType
                int fileSize = file.ContentLength;
                string fileName = file.FileName;
                //teste
                string mimeType = file.ContentType;
                System.IO.Stream fileContent = file.InputStream;
                //To save file, use SaveAs method
                file.SaveAs(@"C:\Users\renna\Documents\Teste\"+file.FileName.Split('.')[0]+"teste"+"."+ file.FileName.Split('.')[1]); //File will be saved in application root
            }
            return Json("Uploaded " + Request.Files.Count + " files");
        }
    }
}