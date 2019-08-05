using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cthulhu.BL
{
   public class UsuariosBL
    { 
            Contexto _contexto;
            public List<Usuarios> ListadeUsuarios { get; set; }

            public UsuariosBL()
            {
                _contexto = new Contexto();
                ListadeUsuarios = new List<Usuarios>();
            }

            public List<Usuarios> ObtenerUsuario()
            {
                ListadeUsuarios = _contexto.Usuarios.ToList();
                return ListadeUsuarios;
            }

            public Usuarios ObtenerUsuario(int Id)
            {
                var usuario = _contexto.Usuarios.Find(Id);
                return usuario;
            }

            public void GuardarUsuario(Usuarios usuario)
            {
                if (usuario.Id == 0)
                {
                    _contexto.Usuarios.Add(usuario);
                }
                else
                {
                    var usuarioExistente = _contexto.Usuarios.Find(usuario.Id);
                    usuarioExistente.Nombre = usuario.Nombre;
                    usuarioExistente.Apellido = usuario.Apellido;
                    usuarioExistente.Nickname = usuario.Nickname;
                    usuarioExistente.Pass = usuario.Pass;
                }
                _contexto.SaveChanges();
            }

            public void EliminarUsuario(int Id)
            {
                var usuario = _contexto.Usuarios.Find(Id);
                _contexto.Usuarios.Remove(usuario);
                _contexto.SaveChanges();
            }
        }
}
