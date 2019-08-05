using Cthulhu.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace The_Chat_Of_Cthulhu.Controllers
{
    public class HomeController : Controller
    {
        UsuariosBL _UsuarioBL;

        public HomeController()
        {
            _UsuarioBL = new UsuariosBL();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registrar()
        {
            var nuevousuario = new Usuarios();
            return View(nuevousuario);
        }

        [HttpPost]
        public ActionResult registrar(Usuarios usuario)
        {
            _UsuarioBL.GuardarUsuario(usuario);
            return RedirectToAction("Index");
        }
    }
}