/// namespace PetstoreGen_MVP.code
using System;
using System.Data;
using System.Configuration;
using LugaresInteresGenNHibernate.CEN.LugaresInteres;
using LugaresInteresGenNHibernate.EN.LugaresInteres;
//using System.Collections.Generic;

namespace LugaresInteresGen_MVP.code
{
    public class PresenterCrearGrupo
    {
        private IVistaCrearGrupo vista;
        private GrupoCEN servicio = null;
        private ActividadCEN servicio_actividad = null;

        private LugarCEN servicio_lugar = null;

        public PresenterCrearGrupo(IVistaCrearGrupo vista) //Recibe la vista a la que tiene que pasar los datos
        {
            this.vista = vista;
            servicio = new GrupoCEN(); //servicio es un CP
            servicio_actividad = new ActividadCEN();
            servicio_lugar = new LugarCEN();
            

        }

        /*public void crear(string nombre, string descripcion, string usuario, LugaresInteresGenNHibernate.Enumerated.LugaresInteres.ActivitiesEnum actividad)
        {

            servicio.Crear(nombre, descripcion, usuario, actividad);
        }*/
        public void crear(string nombre, string descripcion, string usuario, string actividad)
        {

            servicio.Crear(nombre, descripcion, usuario, actividad);
        }
        public void DameTodasActividades()
        {
            //IList<ActividadEN> actividades = servicio_actividad.DameTodasActividades(0, -1);
           // vista.DameActividades = actividades;
            vista.DameActividades = servicio_actividad.DameTodasActividades(0, -1);
        }

    

  

        


    }
}
