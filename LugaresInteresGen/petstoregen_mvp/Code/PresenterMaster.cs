using System;
using System.Data;


/// <summary>
/// Descripción breve de Presenter
/// </summary>
/// namespace PetstoreGen_MVP.code
namespace PetstoreGen_MVP.code
{
    public class PresenterMaster
    {
        private IVistaMaster vista;

        public PresenterMaster(IVistaMaster vista)
        {
            this.vista = vista;

        }
        public void IniciarVista()
        {
            //vista.Email = "santi@dlsi.ua.es";
        }
    }
}