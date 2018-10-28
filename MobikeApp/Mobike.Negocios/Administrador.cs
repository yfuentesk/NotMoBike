using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobike.Negocios
{
    public class Administrador
    {
        private string idPersona;
        private string password;
        private string nombre;
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public string Id_Persona
        {
            get { return idPersona; }
            set { idPersona = value; }
        }
    }
}
