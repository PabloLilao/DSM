/// namespace PetstoreGen_MVP.code
using System;
using System.Data;
using System.Configuration;
using LugaresInteresGenNHibernate.CEN.LugaresInteres;
using LugaresInteresGenNHibernate.EN.LugaresInteres;

namespace LugaresInteresGen_MVP.code
{
    public class PresenterRegistro
    {
        private IVistaRegistro vista;
        private UsuarioCEN servicio = null;

        public PresenterRegistro(IVistaRegistro vista) //Recibe la vista a la que tiene que pasar los datos
        {
            this.vista = vista;
            servicio = new UsuarioCEN(); //servicio es un CP

        }
        public void Registro(string email, string nombre, string apellidos, string contrasenya, string poblacion, string foto )
        {

            String idRegistro = servicio.Registro(email, nombre, apellidos, contrasenya, poblacion, foto);
            vista.Registro = servicio.get_IUsuarioCAD().ReadOIDDefault(idRegistro);
        }


    }
}
