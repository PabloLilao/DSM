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
using System.Windows.Forms;
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
    public partial class Lugar : Page, IVistaLugar //Hereda de page, implementa vista
    {

        PresenterLugar presenter1 = null;
       
        LugarEN lugar = new LugarEN();
        string foti="";
        public Lugar()
        {
            InitializeComponent();

            presenter1 = new PresenterLugar(this); //Para recuperar datos de la BD, se pasa a si misma como parametro para que le devuelva los datos
            presenter1.DameTodosLugares(); //Llama al serivcio para obtener la lista de lugares
           
           
             
        }


        private void dataGridLugar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public IList<LugarEN> DameLugares
        {
            set {

                //lugar.Foto = lugar.Foto.FirstOrDefault();
                //string foti = lugar.Foto.FirstOrDefault().ToString();
                this.DataContext = value;

                /*
                string url = "";
                for (int x = 0; x <lugar.Foto.Count && x < 1; x++)
                {
                    url = (lugar.Foto[x]);

                }
                this.DataContext = SetImageData(File.ReadAllBytes(url));
                */
            }
        }

        private void resultados_Nombre_Click(object sender, RoutedEventArgs e) 
        {
            
            
           //DameLugaresNombre(this.buscar.Text);
           //this.DataContext = DameLugaresNombre(this.buscar.Text);
          
                        
             
             

        }
        /*public IList<LugarEN> DameLugaresNombre(string nombre) {

            System.Collections.Generic.IList<LugarEN> encontrados = new System.Collections.Generic.List<LugarEN>();
         encontrados  = servicio.Gestor_dame_productos_inicio();

            return encontrados;
        
        }*/
    }
}
