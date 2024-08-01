using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Botones.Controllers
{
    public class BotonController : Controller
    {
        // GET: Boton
        public ActionResult GetAll()
        {
            return View();
        }
    }
}