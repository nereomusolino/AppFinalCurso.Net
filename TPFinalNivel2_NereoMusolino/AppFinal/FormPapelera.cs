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
    public partial class FormPapelera : Form
    {
        private List<Articulos> lista = new List<Articulos>();

        public FormPapelera()
        {
            InitializeComponent();
        }

        private void CargarImagen(string url)
        {
            try
            {
                pbxPapelera.Load(url);
            }
            catch (Exception)
            {
                pbxPapelera.Load("https://static.vecteezy.com/system/resources/thumbnails/004/141/669/small_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
            }
        }

        private void OcultarListas()
        {
            dgvPapelera.Columns["UrlImagen"].Visible = false;
            dgvPapelera.Columns["Id"].Visible = false;

        }

        private bool ListaVacia(List<Articulos> lista)
        {
            if (lista == null)
            {
                return false;
            }
            if (lista.Count == 0)
            {
                return false;
            }
            return true;
        }

        private void CargarBasePapelera()
        {
            ArticulosNegocio aux = new ArticulosNegocio();
  
            try
            {
                lista = aux.ListarPapelera();
                dgvPapelera.DataSource = lista;

                if (ListaVacia(lista)==true)
                {

                    CargarImagen(lista[0].UrlImagen.ToString());
                    OcultarListas();
                }

            }

            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar el formulario");
            }

            
        }

        private void Papelera_Load(object sender, EventArgs e)
        {
            CargarBasePapelera();
        }

        private void EliminarFisicamente_Click(object sender, EventArgs e)
        {
            ArticulosNegocio obj = new ArticulosNegocio();
            try
            {
                obj.EliminarFisico((Articulos)dgvPapelera.CurrentRow.DataBoundItem);
                CargarBasePapelera();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> listaFiltrada;
            string filtro = txbBusquedaPapelera.Text;

            try
            {
                if (filtro != "")
                {
                    listaFiltrada = lista.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.MarcaArticulo.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.CategoriaArticulo.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                }
                else
                {
                    listaFiltrada = lista;
                }

                dgvPapelera.DataSource = null;
                dgvPapelera.DataSource = listaFiltrada;
                OcultarListas();

            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo encontrar el archivo");
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio obj = new ArticulosNegocio();

            try
            {
                obj.Restaurar((Articulos)dgvPapelera.CurrentRow.DataBoundItem);
                CargarBasePapelera();
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo restaurar el archivo");
            }
        }
    }
}
