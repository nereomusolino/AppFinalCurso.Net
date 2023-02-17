using ClasesDominio;
using ClasesNegocio;
using System;
using System.Collections;
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
    public partial class FormAgregar : Form
    {
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void CargarImagen(string url)
        {
            try
            {
                pbxImagen.Load(url);
            }
            catch (Exception)
            {
                pbxImagen.Load("https://static.vecteezy.com/system/resources/thumbnails/004/141/669/small_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
            }
        }

        private void txbUrlImagen_Leave(object sender, EventArgs e)
        {
            CargarImagen(txbUrlImagen.Text);
        }

        private void ValidarRequeridos()
        {
            if (txbCodigo.Text == "")
            {
                label1.Visible = true;
            }
            if (txbNombre.Text == "")
            {
                label2.Visible = true;
            }
            if (txbDescripcion.Text == "")
            {
                label3.Visible = true;
            }
            if (cmbMarca.Text == "")
            {
                label4.Visible = true;
            }
            if (cmbCategoria.Text == "")
            {
                label5.Visible = true;
            }
            if (txbUrlImagen.Text == "")
            {
                label6.Visible = true;
            }
            /*if (txbPrecio.Text == "")
            {
                label7.Visible = true;
            }*/
        }

        private bool ValidarTextbox()
        {
            if (!(cmbCategoria.Text == "" || txbCodigo.Text == "" || txbDescripcion.Text == "" || cmbMarca.Text == "" || txbNombre.Text == "" || /*txbPrecio.Text == "" ||*/ txbUrlImagen.Text == ""))
            {
                return true;
            }
            return false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio aux = new ArticulosNegocio();
            Articulos obj = new Articulos();
            
            ValidarRequeridos();

            if(ValidarTextbox())
            {
                obj.Nombre = txbNombre.Text;
                obj.CodigoArticulo = txbCodigo.Text;
                obj.Descripcion = txbDescripcion.Text;
                obj.MarcaArticulo = (Marca)cmbMarca.SelectedItem;
                obj.CategoriaArticulo = (Categoria)cmbCategoria.SelectedItem;
                obj.UrlImagen = txbUrlImagen.Text;
                //obj.Precio = float.Parse(txbPrecio.Text);

                try
                {
                    aux.Agregar(obj);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo cargar el articulo");
                }
            }
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            MarcasNegocio marcas = new MarcasNegocio();
            CategoriasNegocio categorias = new CategoriasNegocio();

            cmbMarca.DataSource = marcas.Listar();
            cmbCategoria.DataSource = categorias.Listar();
        }
    }
}
