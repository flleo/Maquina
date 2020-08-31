using Maquina.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Maquina.Controllers
{
    public class FilesController : Controller
    {
        private MaquinaContext db = new MaquinaContext();
        //
        // GET: /File/
        public ActionResult Index(int? id)
        {
            var fileToRetrieve = db.Files.Find(id);
            return File(fileToRetrieve.Content, fileToRetrieve.ContentType);
        }
    }
}