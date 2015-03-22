/// namespace PetstoreGen_MVP.code
using System;
using System.Data;
using System.Configuration;
using LugaresInteresGenNHibernate.CEN.LugaresInteres;
using LugaresInteresGenNHibernate.EN.LugaresInteres;

namespace LugaresInteresGen_MVP.code
{
    public class PresenterLugarNuevo
    {
        private IVistaLugarNuevo vista;
        private LugarCEN servicio = null;

        public PresenterLugarNuevo(IVistaLugarNuevo vista) //Recibe la vista a la que tiene que pasar los datos
        {
            this.vista = vista;
            servicio = new LugarCEN(); //servicio es un CP

        }
        public void crearLugarNuevo(string nombre, string tipo, string ubicacion, string descripcion, string poblacion, System.Collections.Generic.IList<string> foto )
        {

            //vista.CreaLugar = servicio.CrearLugar(nombre, tipo, ubicacion, descripcion, poblacion, foto);

            servicio.CrearLugar(nombre, tipo, ubicacion, descripcion, poblacion, foto);
        }


    }
}
