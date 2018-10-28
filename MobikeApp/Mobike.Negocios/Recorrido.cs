using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobike.Negocios
{
    public class Recorrido
    {
        private int idRecorrido;
        private double km;
        private DateTime inicioRecorrido;
        private DateTime finRecorrido;
        private double tiempoEstimado;
        private double cobro;

        public double Cobro
        {
            get { return cobro; }
            set { cobro = value; }
        }


        public double TiempoEstimado
        {
            get { return tiempoEstimado; }
            set { tiempoEstimado = value; }
        }


        public DateTime FinRecorrido
        {
            get { return finRecorrido; }
            set { finRecorrido = value; }
        }


        public DateTime InicioRecorrido
        {
            get { return inicioRecorrido; }
            set { inicioRecorrido = value; }
        }

        public double Kilometros
        {
            get { return km; }
            set { km = value; }
        }

        public int Id_Recorrido
        {
            get { return idRecorrido; }
            set { idRecorrido = value; }
        }

    }
}
