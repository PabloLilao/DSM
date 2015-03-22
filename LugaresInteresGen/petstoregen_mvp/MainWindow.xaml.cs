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
using LugaresInteresGen_MVP.views;
using PetstoreGen_MVP.views;

namespace LugaresInteresGen_MVP //cambiar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //frame1.Content = new Cabecera();
            frame1.Content = new Cabecera2();
            Contenido.Content = new Inicio();
            //Contenido.Content = new LugarNuevo();
            //Contenido.Content = new CrearGrupo();

            //frame1.Content = new PetstoreGen_MVP.views.Cabecera();            
           // PageController.Content = new Cabecera();
           

            
           // Contenido.NavigationService.Navigate(new Usuario());
            //CrearGrupo.NavigationService.Navigate(new CrearGrupo());
            //Contenido.Content = new LugarNuevo();
            //Contenido.Content = new Inicio();
          // Contenido.Content = new Lugar();
            //Contenido.Content = new CrearGrupo();
            
         //   frameContenido2.NavigationService.Navigate(new Lugar());
        }
        

        internal void IrInicio()
        {
            Contenido.Content = new Inicio();
        }
        internal void IrRegistro()
        {
            Contenido.Content = new VistaRegistro();
        }
        internal void IrLugar()
        {
            Contenido.Content = new Lugar();
        }
        internal void IrLugarNuevo()
        {
            Contenido.Content = new LugarNuevo();
        }
        internal void IrCrearGrupo()
        {
            Contenido.Content = new CrearGrupo();
        }


        private void frame1_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
