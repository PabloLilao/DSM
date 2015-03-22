/// namespace PetstoreGen_MVP.code
using System;
using System.Data;
using System.Configuration;
using LugaresInteresGenNHibernate.CEN.LugaresInteres;
using LugaresInteresGenNHibernate.EN.LugaresInteres;

namespace LugaresInteresGen_MVP.code
{
    public class PresenterLugar
    {
        private IVistaLugar vista;
        private LugarCEN servicio = null;

        public PresenterLugar(IVistaLugar vista) //Recibe la vista a la que tiene que pasar los datos
        {
            this.vista = vista;
            servicio = new LugarCEN(); //servicio es un CP

        }

        public void DameTodosLugares()
        {

            vista.DameLugares = servicio.DameTodos(0, -1); //Recupera los datos de la BD
        }
        /*public void DameLugaresNombre(string nombre)
        {
            vista.DameLugaresNombre = servicio.BuscarLugarNombre(nombre);
        }*/
    }
}
