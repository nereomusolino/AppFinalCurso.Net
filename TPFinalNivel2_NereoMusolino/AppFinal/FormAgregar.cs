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
using System.IO;
using System.Configuration;

namespace AppFinal
{
    public partial class FormAgregar : Form
    {
        private Articulos aux = null;
        private OpenFileDialog archivo = null;
        public FormAgregar()
        {
            InitializeComponent();
        }

        public FormAgregar(Articulos aux)
        {
            InitializeComponent();
            this.aux = aux;
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
            if (txbPrecio.Text == "")
            {
                label7.Visible = true;
            }
        }

        private bool ValidarTextbox()
        {
            if (!(cmbCategoria.Text == "" || txbCodigo.Text == "" || txbDescripcion.Text == "" || cmbMarca.Text == "" || txbNombre.Text == "" || txbPrecio.Text == "" || txbUrlImagen.Text == ""))
            {
                return true;
            }
            return false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio obj = new ArticulosNegocio();         
            ValidarRequeridos();

            if(ValidarTextbox())
            {
                if(aux == null)
                {
                    aux = new Articulos();
                }
                aux.Nombre = txbNombre.Text;
                aux.CodigoArticulo = txbCodigo.Text;
                aux.Descripcion = txbDescripcion.Text;
                aux.MarcaArticulo = (Marca)cmbMarca.SelectedItem;
                aux.CategoriaArticulo = (Categoria)cmbCategoria.SelectedItem;
                aux.UrlImagen = txbUrlImagen.Text;
                aux.Precio = txbPrecio.Text;

                try
                {
                    if(aux.Id != 0)
                    {
                        obj.Modificar(aux);
                        MessageBox.Show("Modificado exitosamente");
                    }
                    else
                    {
                        obj.Agregar(aux);
                        MessageBox.Show("Agregado exitosamente");
                    }

                    if(archivo != null && !(txbUrlImagen.Text.ToUpper().Contains("HTTP")))
                    {
                        File.Copy(archivo.FileName, ConfigurationManager.AppSettings["carpeta-imagenes"] + archivo.SafeFileName);
                    }

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
            cmbMarca.ValueMember = "Id";
            cmbMarca.DisplayMember = "Descripcion";
            cmbMarca.SelectedIndex = -1;
            cmbCategoria.DataSource = categorias.Listar();
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DisplayMember = "Descripcion";
            cmbCategoria.SelectedIndex = -1;

            if (aux != null)
            {
                this.Name = "Modificar";
                btnAgregar.Text = "Modificar";
                txbCodigo.Text = aux.CodigoArticulo;
                txbNombre.Text = aux.Nombre;
                txbDescripcion.Text = aux.Descripcion;
                txbUrlImagen.Text = aux.UrlImagen;
                CargarImagen(aux.UrlImagen);
                cmbMarca.SelectedValue = aux.MarcaArticulo.Id;
                cmbCategoria.SelectedValue = aux.CategoriaArticulo.Id;
                txbPrecio.Text = aux.Precio;
            }
        }

        private void txbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txbUrlImagen.Text = archivo.FileName;
                CargarImagen(txbUrlImagen.Text);
            }
        }
    }
}
