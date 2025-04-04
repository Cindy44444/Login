using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Usuarios
    {
        private static List<Usuarios> usuarios = new List<Usuarios>
        {
            new Usuarios{NombreUsuario = "Admin", Contrasenia= "123"},
            new Usuarios {NombreUsuario = "Pikachu", Contrasenia = "321"},
            new Usuarios {NombreUsuario = "Ben10", Contrasenia = "978"},
            new Usuarios {NombreUsuario = "Pucca", Contrasenia = "4576"},
             new Usuarios {NombreUsuario = "Narnia", Contrasenia = "654"},
        };


        public Usuarios() { }
        public List<Usuarios> Obtenerusuarios()
        {
            return usuarios;
        }
        
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
          
    }
}
