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
using System.Drawing;
using LugaresInteresGenNHibernate.EN.LugaresInteres;
using System.Collections;
using LugaresInteresGen_MVP.code;
using System.Windows.Forms;

namespace LugaresInteresGen_MVP.views
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class LugarNuevo : Page, IVistaLugarNuevo //Hereda de page, implementa vista   
    {
              
        PictureBox img = null;
        string ruta = "";
        string de = "";
        string nom = "";
        string imagen = "";
        string nombreLugar = "";
        System.Collections.Generic.IList<String> list_fotos = new System.Collections.Generic.List<String>();


        PresenterLugarNuevo presenter = null;        
        public LugarNuevo()
        {

            InitializeComponent();

            presenter = new PresenterLugarNuevo(this); //Para recuperar datos de la BD, se pasa a si misma como parametro para que le devuelva los datos
            //string p_nombre, string p_tipo, string p_ubicacion, string p_descripcion, string p_poblacion, string p_foto
      }


        
        private void confirmar_Lugar_Click(object sender, RoutedEventArgs e)
        {

            if (this.tipo.Text != null && this.tipo.Text != "")
            {
                if (this.poblacion.Text != null && this.poblacion.Text != "")
                {

                    if (this.coordenadas.Text != null && this.coordenadas.Text != "")
                    {
                        if (this.descripcion.Text != null && this.descripcion.Text != "")
                        {
                            if (imagen != "")
                            {
                                if (!System.IO.File.Exists(ruta + nombreLugar))
                                {
                                    System.IO.File.Copy(de, ruta + nombreLugar);
                                    //almacenamos en la lista la ruta de la imagen y como nombre el nombre del lugar + el de la foto original

                                    list_fotos.Add(ruta + nombreLugar);

                                        /*for(int x=0;x<list_fotos.Count && x < 1; x++) {
                                                this.ea.Text = (list_fotos[x]);

                                        }*/
                                    //this.ea.Text = list_fotos.ToString();
                                    
                                }
                                presenter.crearLugarNuevo(this.nombre.Text, this.tipo.Text, this.coordenadas.Text, this.descripcion.Text, this.poblacion.Text, list_fotos);
                                System.Windows.MessageBox.Show(String.Concat("Lugar creado con éxito!!"));
                            }
                           
                        }
                    }
                }
            }

        }

        private void subir_Foto_Click(object sender, RoutedEventArgs e)
        {

            if (this.nombre.Text != null && this.nombre.Text != "")
            {
                nombreLugar = this.nombre.Text;           


                img = new PictureBox();
                // Set the location and size of the PictureBox control.
                this.img.Location = new System.Drawing.Point(702, 284);
                this.img.Size = new System.Drawing.Size(155, 99);
                this.img.TabStop = false;
                this.img.SizeMode = PictureBoxSizeMode.StretchImage;
                this.img.BorderStyle = BorderStyle.FixedSingle;
                // Add the PictureBox to the form.
                this.windowsFormsHost1.Child = img;

                OpenFileDialog BuscarImagen = new OpenFileDialog();
                BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
                BuscarImagen.FileName = "";
                BuscarImagen.Title = "Añadir fotos";
                BuscarImagen.InitialDirectory = "C:\\";

                if (BuscarImagen.ShowDialog() == DialogResult.OK)
                {
                    String Direccion = BuscarImagen.FileName;
                    de = Direccion;
                    //direccion destino
                    ruta = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "images\\lugares\\ ");
                    //nombre de la imagen
                    nom = Direccion.Substring(Direccion.LastIndexOf("\\") + 1);
                    nombreLugar = nombreLugar + nom;

                    //direccion para almacenar en lugares                                                           
                    imagen = ruta + nom;

                    this.img.ImageLocation = Direccion;

                    img.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }
        
        }

        public LugarEN CreaLugar
        {
            set {

                this.DataContext = value;
            }
        }

        
    }
}
