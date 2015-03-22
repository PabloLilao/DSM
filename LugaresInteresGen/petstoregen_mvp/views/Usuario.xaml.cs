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
    public partial class Usuario : Page, IVistaUsuario
    {

        PresenterUsuario presenter = null;
        
        public Usuario()
        {
            InitializeComponent();
            presenter = new PresenterUsuario(this);
            presenter.DameTodosUsuarios();
            
        }



        private void dataGridProductos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public IList<UsuarioEN> DameUsuarios
        {
            set {

                this.DataContext = value;
            }
        }
    }
}
