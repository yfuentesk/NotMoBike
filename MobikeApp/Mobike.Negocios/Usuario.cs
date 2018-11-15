using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobike.Negocios
{
    public class Usuario : Persona
    {
        private long _tarjeta;
        private double _saldo;
        
        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public long Tarjeta
        {
            get { return _tarjeta; }
            set { _tarjeta = value; }
        }
        #region Constructores
        public Usuario()
        {
            _saldo = 0;
            _tarjeta = -1;
        }

        public Usuario(string IdPersona, string Contrasena, string Nombre, string Direccion, long Tarjeta, double Saldo)
        {
            this.Id_Persona = IdPersona;
            this.Password = Contrasena;
            this.Nombre = Nombre;
            this.Direccion = Direccion;
            this.Tarjeta = Tarjeta;
            this.Saldo = Saldo;
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
