using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobike.Negocios
{
    public abstract class Persona
    {
        #region Campos
        private string _idPersona;
        private string _password;
        private string _nombre;
        private string _direccion;
        #endregion
        #region Propiedades
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }


        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }


        public string Id_Persona
        {
            get { return _idPersona; }
            set { _idPersona = value; }
        }
        #endregion
        #region Constructores
        public Persona()
        {
            _idPersona = string.Empty;
            _password = string.Empty;
            _nombre = string.Empty;
            _direccion = string.Empty;
        }

        public Persona(string IdPersona, string Contrasena, string Nombre, string Direccion)
        {
            this.Id_Persona = IdPersona;
            this.Password = Contrasena;
            this.Nombre = Nombre;
            this.Direccion = Direccion;
        }
        #endregion
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
                Datos.persona per = (from auxper in Conexion.Mob.persona
                                      where auxper.id_persona == this.Id_Persona
                                      select auxper).First();
                this.Id_Persona = per.id_persona;
                this.Password = per.password;
                this.Nombre = per.nombre;
                this.Direccion = per.direccion;

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
