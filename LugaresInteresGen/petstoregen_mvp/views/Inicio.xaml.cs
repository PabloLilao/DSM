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
    public partial class Inicio : Page, IVistaInicio //Hereda de page, implementa vista
    {

        PresenterInicio presenter1 = null;
        
        public Inicio()
        {
            InitializeComponent();

            presenter1 = new PresenterInicio(this); //Para recuperar datos de la BD, se pasa a si misma como parametro para que le devuelva los datos
            presenter1.DameTodosLugares(); //Llama al serivcio para obtener la lista de lugares
        }


        private void dataGridLugar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button1_Click_Login(object sender, RoutedEventArgs e)
        {

            presenter1.Login(this.email.Text, this.contrasenya.Text);
        
        }



        public IList<LugarEN> DameLugares
        {
            set {

                this.DataContext = value;
            }
        }
    }
}
