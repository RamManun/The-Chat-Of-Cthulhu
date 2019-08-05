using Cthulhu.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Usuarioss.Web.Admin.Controllers
{
    public class RegistroUsuariosController : Controller
    {
       UsuariosBLuarios _usuariosBL;
        public RegistroUsuariosController()
        {
            _usuariosBL UsuariosBLuarios();
        }
        // GET: RegistroUsuarios
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
        public ActionResult Edit(UsBLuarios usuario)
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
        public ActionResult delete(UsBLuarios usuario)
        {
            _usuariosBL.EliminarUsuario(usuario.Id);
            return RedirectToAction("Index");
        }
    }
}