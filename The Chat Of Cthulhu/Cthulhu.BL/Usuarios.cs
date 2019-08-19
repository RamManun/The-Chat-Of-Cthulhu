using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cthulhu.BL
{
    public class Usuarios
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese un nickname")]
        [MinLength(3, ErrorMessage = "Ingrese minimo 3 carecteres")]
        [MaxLength(15, ErrorMessage = "Ingrese Maximo 15 carecteres")]
        public string Nickname { get; set; }
        [Required(ErrorMessage = "Ingrese un nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese un apellido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Ingrese un Correo")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "Ingrese una Contrasenia")]

        public string Pass { get; set; }
    }
}
