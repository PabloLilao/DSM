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
using PetstoreGen_MVP.code;
using LugaresInteresGen_MVP.views;
using LugaresInteresGen_MVP;

namespace PetstoreGen_MVP.views
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Cabecera : Page
    {
        //PresenterMaster presenter = null;
        public Cabecera()
        {
            //presenter = new PresenterMaster(this);
            InitializeComponent();
           // presenter.IniciarVista();
        }
        private void IrInicio(object sender, System.Windows.RoutedEventArgs e)
        {            
            ((MainWindow)Application.Current.MainWindow).IrInicio();
        }
        private void IrRegistro(object sender, System.Windows.RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).IrRegistro();
        }
        private void IrLugar(object sender, System.Windows.RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).IrLugar();
        }

    }
}
