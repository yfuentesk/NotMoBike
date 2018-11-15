using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobike.Negocios
{
    public class Administrador : Persona
    {
        public Administrador()
        {

        }

        public Administrador(string IdPersona, string Contrasena, string Nombre, string Direccion)
        {
            this.Id_Persona = IdPersona;
            this.Password = Contrasena;
            this.Nombre = Nombre;
            this.Direccion = Direccion;
        }
        #region CRUD
        public bool Create()
        {
            try
            {
                Datos.persona per = new Datos.persona()
                {
                    id_persona = this.Id_Persona,
                    password = this.Password,
                    nombre = this.Nombre,
                    direccion = this.Direccion,

                };
                Conexion.Mob.persona.Add(per);
                Conexion.Mob.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool Read()
        {
            try
            {
                Datos.persona adm = (from auxadm in Conexion.Mob.persona
                                     where auxadm.id_persona == this.Id_Persona
                                     select auxadm).First();
                this.Id_Persona = adm.id_persona;
                this.Password = adm.password;
                this.Nombre = adm.nombre;
                this.Direccion = adm.direccion;

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update()
        {
            try
            {
                Datos.persona per = Conexion.Mob.persona.First(p => p.id_persona == Id_Persona);

                per.nombre = Nombre;
                per.password = Password;
                per.direccion = Direccion;
                ;

                Conexion.Mob.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool Delete()
        {
            try
            {
                Datos.persona per = (from auxper in Conexion.Mob.persona
                                     where auxper.id_persona == this.Id_Persona
                                     select auxper).First();
                Conexion.Mob.persona.Remove(per);
                Conexion.Mob.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }

}
