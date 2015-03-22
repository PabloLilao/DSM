using System;
using System.Data;
using System.Configuration;
using LugaresInteresGenNHibernate.CEN.LugaresInteres;
using LugaresInteresGenNHibernate.EN.LugaresInteres;

/// <summary>
/// Descripción breve de Presenter
/// </summary>
/// namespace PetstoreGen_MVP.code
namespace LugaresInteresGen_MVP.code
{
    public class PresenterUsuario
    {
        private IVistaUsuario vista;
        private UsuarioCEN servicio = null;

        public PresenterUsuario(IVistaUsuario vista)
        {
            this.vista = vista;
            servicio = new UsuarioCEN();

        }

        public void DameTodosUsuarios()
        {

            vista.DameUsuarios = servicio.DameTodos(0,-1);
        }

    }
}