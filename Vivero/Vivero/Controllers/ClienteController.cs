using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vivero.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Registrar()
        {
            return View();
        }
    }
}