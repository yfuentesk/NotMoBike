using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobike.Negocios
{
    public class Estacionamiento
    {
        private string idEstacionamiento;
        private string nombreEst;
        private string direccionEst;
        private int capacidad;

        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }


        public string DireccionEstacionamiento
        {
            get { return direccionEst; }
            set { direccionEst = value; }
        }


        public string NombreEstacionamiento
        {
            get { return nombreEst; }
            set { nombreEst = value; }
        }


        public string IdEstacionamiento
        {
            get { return idEstacionamiento; }
            set { idEstacionamiento = value; }
        }

    }
}
