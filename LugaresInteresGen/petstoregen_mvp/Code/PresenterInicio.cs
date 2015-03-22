/// namespace PetstoreGen_MVP.code
using System;
using System.Data;
using System.Configuration;
using LugaresInteresGenNHibernate.CEN.LugaresInteres;
using LugaresInteresGenNHibernate.EN.LugaresInteres;

namespace LugaresInteresGen_MVP.code
{
    public class PresenterInicio
    {
        private IVistaInicio vista;
        private LugarCEN servicio = null;
        private UsuarioCEN servicio2 = null;

        public PresenterInicio(IVistaInicio vista) //Recibe la vista a la que tiene que pasar los datos
        {
            this.vista = vista;
            servicio = new LugarCEN(); //servicio es un CP
            servicio2 = new UsuarioCEN();
        }

        public void DameTodosLugares()
        {

           // vista.DameLugares = servicio.DameTodos(0, -1); //Recupera los datos de la BD
        }
        public void Login(string email, string contrasenya) {            
            Boolean conectado = servicio2.Login(email, contrasenya);
            if (conectado) {
                class1.emailUsuario = email;
                class1.contrasenya = contrasenya;
            
            }
        }
    }
}
