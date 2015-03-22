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
    public partial class VistaRegistro : Page, IVistaRegistro //Hereda de page, implementa vista
    {

        PresenterRegistro presenter = null;
        
        public VistaRegistro()
        {

            InitializeComponent();

            presenter = new PresenterRegistro(this); //Para recuperar datos de la BD, se pasa a si misma como parametro para que le devuelva los datos
            //string p_nombre, string p_tipo, string p_ubicacion, string p_descripcion, string p_poblacion, string p_foto
      }


        
        private void registro_Click(object sender, RoutedEventArgs e)
        {
            //Comprobar campos obligatorios *
            if (this.nombre.Text != "" && this.nombre.Text != null)
            {
                this.errNombre.Visibility = System.Windows.Visibility.Hidden;

                if (this.apellidos.Text != "" && this.apellidos.Text != null)
                {
                    this.errApellidos.Visibility = System.Windows.Visibility.Hidden;

                    if (this.contraseña.Text != "" && this.contraseña.Text != null && this.repetirContraseña.Text != null && this.repetirContraseña.Text != "")
                    {
                        if (this.provincia.Text != "" && this.provincia.Text != null)
                        {
                            this.errProvincia.Visibility = System.Windows.Visibility.Hidden;

                            if (this.email.Text != "" && this.email.Text != null)
                            {
                                this.errEmail.Visibility = System.Windows.Visibility.Hidden;

                                //Comprobar contraseñas
                                if (this.contraseña.Text == this.repetirContraseña.Text)
                                {
                                    this.errContraseña.Visibility = System.Windows.Visibility.Hidden;
                                    //Llamada a Registro
                                    presenter.Registro(this.email.Text, this.nombre.Text, this.apellidos.Text, this.contraseña.Text, this.localidad.Text, this.foto.Text); //Llama al serivcio para obtener NADA
                                    //(this.emailRecuperar.Text);
                                }
                                else
                                {
                                    //Mostrar error
                                    this.errContraseña.Visibility = System.Windows.Visibility.Visible;
                                }
                            }
                            else
                            {
                                this.errEmail.Visibility = System.Windows.Visibility.Visible;
                            }
                        }
                        else
                        {
                            this.errProvincia.Visibility = System.Windows.Visibility.Visible;
                        }
                    }
                    else
                    {
                        this.errContraseña.Visibility = System.Windows.Visibility.Visible;
                    }
                }
                else
                {
                    this.errApellidos.Visibility = System.Windows.Visibility.Visible;
                }

            }
            else
            {
                this.errNombre.Visibility = System.Windows.Visibility.Visible;
            }
        }

        public UsuarioEN Registro
        {
            set {

                this.DataContext = value;
            }
        }

        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
