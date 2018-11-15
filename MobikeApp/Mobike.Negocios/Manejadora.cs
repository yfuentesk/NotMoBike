using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobike.Negocios
{
    public class Manejadora
    {
        public Manejadora()
        {

        }

        public List<Usuario> ListarUsuario()
        {
            List<Usuario> ListaUsuario = new List<Usuario>();
            foreach (Datos.usuario usu in Conexion.Mob.usuario )
            {
                Usuario nuevoUsuario = new Usuario(usu.id_personaF,
                                                   usu.persona.password,
                                                   usu.persona.nombre,
                                                   usu.persona.direccion,
                                                   usu.tarjeta,
                                                   usu.saldo);
                ListaUsuario.Add(nuevoUsuario);
            }
            return ListaUsuario;
        }

        public List<Administrador> ListarAdmin()
        {
            List<Administrador> ListaAdmin = new List<Administrador>();
            foreach (Datos.administrador adm in Conexion.Mob.administrador)
            {
                Administrador nuevoAdmin = new Administrador(adm.id_personaF,
                                                   adm.persona.password,
                                                   adm.persona.nombre,
                                                   adm.persona.direccion);
                ListaAdmin.Add(nuevoAdmin);
                
            }
            return ListaAdmin;
        }

        public List<Recorrido> ListarRecorridos()
        {
            List<Recorrido> ListarRecorrido = new List<Recorrido>();
            foreach (Datos.recorrido re in Conexion.Mob.recorrido)
            {
                Recorrido nuevoRecorrido = new Recorrido(re.id_recorrido,
                                                         re.kilometros,
                                                         re.inicio_recorrido,
                                                         re.fin_recorrido,
                                                         re.tiempo_estimado,
                                                         re.cobro);
                ListarRecorrido.Add(nuevoRecorrido);
            }
            return ListarRecorrido;
        }
    }
}
