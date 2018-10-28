using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobike.Negocios
{
    public class Usuario
    {
        private string idPersona;
        private string password;
        private string nombre;
        private string direccion;
        private long tarjeta;
        private double saldo;

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
        
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public long Tarjeta
        {
            get { return tarjeta; }
            set { tarjeta = value; }
        }

    }
}