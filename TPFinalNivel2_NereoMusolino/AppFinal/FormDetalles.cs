using ClasesDominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFinal
{
    public partial class FormDetalles : Form
    {
        private Articulos obj;
        public FormDetalles()
        {
            InitializeComponent();
        }

        public FormDetalles(Articulos obj)
        {
            this.obj = obj;
            InitializeComponent();
        }

        private void CargarImagen(string url)
        {
            try
            {
                pbDetalles.Load(url);
            }
            catch (Exception)
            {
                pbDetalles.Load("https://static.vecteezy.com/system/resources/thumbnails/004/141/669/small_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
            }
        }

        private void FormDetalles_Load(object sender, EventArgs e)
        {
            lvDetalles.Items.Clear();

            lvDetalles.Items.Add("Nombre: " + obj.Nombre);

            lvDetalles.Items.Add("Descripcion: " + obj.Descripcion);

            lvDetalles.Items.Add("Categoria de Articulo: " + obj.CategoriaArticulo.Descripcion);

            lvDetalles.Items.Add("Marca de Articulo: " + obj.MarcaArticulo.Descripcion);

            lvDetalles.Items.Add("Precio: " + obj.Precio);

            CargarImagen(obj.UrlImagen);
        }
    }
}
