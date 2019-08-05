using Cthulhu.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Administrador.Controllers
{
    public class RegistroUsuaController : Controller
    {
        UsuariosBL _usuariosBL;
        public RegistroUsuaController()
        {
            _usuariosBL = new UsuariosBL();
        }

        // GET: RegistroUsua
        public ActionResult Index()
        {
            var Registrarse = _usuariosBL.ObtenerUsuario();
            return View(Registrarse);
        }

        public ActionResult Edit(int Id)
        {
            var ModificarUsuario = _usuariosBL.ObtenerUsuario(Id);

            return View(ModificarUsuario);
        }

        [HttpPost]
        public ActionResult Edit(Usuarios usuario)
        {
            _usuariosBL.GuardarUsuario(usuario);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var usuario = _usuariosBL.ObtenerUsuario(id);
            return View(usuario);

        }
        [HttpPost]
        public ActionResult delete(Usuarios usuario)
        {
            _usuariosBL.EliminarUsuario(usuario.Id);
            return RedirectToAction("Index");
        }
    }
}