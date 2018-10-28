using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobike.Negocios
{
    public class Bicicleta
    {
        private string idBicicleta;
        private string location;
        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }


        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public string IdBicicleta
        {
            get { return idBicicleta; }
            set { idBicicleta = value; }
        }

    }
}
