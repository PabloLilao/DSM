using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LugaresInteresGenNHibernate.EN.LugaresInteres;
using System.Collections;
using LugaresInteresGen_MVP.code;

namespace LugaresInteresGen_MVP.views
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class CrearGrupo : Page, IVistaCrearGrupo //Hereda de page, implementa vista
    {

        PresenterCrearGrupo presenter = null;
        //LugaresInteresGenNHibernate.Enumerated.LugaresInteres.ActivitiesEnum act;
        ActividadEN cat = new  ActividadEN();
        //IList<ActividadEN> act = new IList ActividadEN();
        string actividadElegida = "";

        public CrearGrupo()
        {
            InitializeComponent();
            presenter = new PresenterCrearGrupo(this); //Para recuperar datos de la BD, se pasa a si misma como parametro para que le devuelva los datos
            presenter.DameTodasActividades();
           
            
           
           
        }

    

        private void confirmar_Grupo_Click(object sender, RoutedEventArgs e)
        {
            GrupoEN servicio = new GrupoEN();
            string emailUsuario = class1.emailUsuario;
            LugaresInteresGenNHibernate.Enumerated.LugaresInteres.ActivitiesEnum activ = LugaresInteresGenNHibernate.Enumerated.LugaresInteres.ActivitiesEnum.Acampar;
            
            //presenter.crear(this.nombre.Text, this.descripcion.Text, emailUsuario,LugaresInteresGenNHibernate.Enumerated.LugaresInteres.ActivitiesEnum.Acampar);
            presenter.crear(this.nombre.Text, this.descripcion.Text, emailUsuario, actividadElegida);

        }
        public IList<ActividadEN> DameActividades
        {
            set
            { 
                actividad.ItemsSource = value;               
                
            }
        }

        public void selectActividad_Click(object sender, SelectionChangedEventArgs e ) {
            
            actividadElegida = actividad.SelectedValue.ToString();
        
        }
       
      
  


    }
}
