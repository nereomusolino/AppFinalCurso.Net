using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesNegocio;
using ClasesDominio;
using System.Data.SqlTypes;

namespace AppFinal
{
    public partial class FormApp : Form
    {
        private List<Articulos> lista = new List<Articulos>();

        public FormApp()
        {
            InitializeComponent();
        }

        private void btnBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            pbImagenes.Location = new Point(531, 128);
            dgvLista.Location = new Point(12, 128);
            lblCampo.Visible = true;
            lblCriterio.Visible = true;
            lblFiltro.Visible = true;
            cmbCampo.Visible = true;
            cmbCriterio.Visible = true;
            txbFiltro.Visible = true;
            btnBuscar.Visible = true;
            btnVolver.Visible = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            pbImagenes.Location = new Point(531, 85);
            dgvLista.Location = new Point(12, 85);
            lblCampo.Visible = false;
            lblCriterio.Visible = false;
            lblFiltro.Visible = false;
            cmbCampo.Visible = false;
            cmbCriterio.Visible = false;
            txbFiltro.Visible = false;
            btnBuscar.Visible = false;
            btnVolver.Visible = false;
        }

        private void CargarImagen(string url)
        {
            try
            {
                pbImagenes.Load(url);
            }
            catch (Exception)
            {
                pbImagenes.Load("https://static.vecteezy.com/system/resources/thumbnails/004/141/669/small_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
            }
        }

        private void OcultarListas()
        {
            dgvLista.Columns["UrlImagen"].Visible = false;
            dgvLista.Columns["Id"].Visible = false;

        }

        private void CargarBase()
        {
            ArticulosNegocio aux = new ArticulosNegocio();
            try
            {
                lista = aux.Listar();
                dgvLista.DataSource = lista;
                CargarImagen(lista[0].UrlImagen.ToString());
                OcultarListas();
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo cargar el formulario");
            }

        }

        private void FormApp_Load(object sender, EventArgs e)
        {
            CargarBase();
            cmbCampo.Items.Add("Nombre");
            cmbCampo.Items.Add("Marca");
            cmbCampo.Items.Add("Categoría");
            cmbCampo.Items.Add("Precio");
        }

        private void dgvLista_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvLista.CurrentRow != null)
            {
                Articulos aux = new Articulos();
                aux = (Articulos)dgvLista.CurrentRow.DataBoundItem;
                CargarImagen(aux.UrlImagen);
            }
            
        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cmbCampo.SelectedItem.ToString();
            
            if(opcion == "Nombre")
            {
                cmbCriterio.Items.Clear();
                cmbCriterio.Items.Add("Comienza con");
                cmbCriterio.Items.Add("Contiene");

            }
            else if(opcion == "Marca")
            {
                cmbCriterio.Items.Clear();
                cmbCriterio.Items.Add("Comienza con");
                cmbCriterio.Items.Add("Contiene");

            }
            else if (opcion == "Categoría")
            {
                cmbCriterio.Items.Clear();
                cmbCriterio.Items.Add("Comienza con");
                cmbCriterio.Items.Add("Contiene");

            }
            else
            {
                cmbCriterio.Items.Clear();
                cmbCriterio.Items.Add("Mayor a ");
                cmbCriterio.Items.Add("Menor a");
                cmbCriterio.Items.Add("Igual a");

            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar Agregar = new FormAgregar();
            Agregar.ShowDialog();
            CargarBase();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio aux = new ArticulosNegocio();

            try
            {
                aux.EliminarLogico((Articulos)dgvLista.CurrentRow.DataBoundItem);
                CargarBase();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo eliminar el dato");
            }
        }

        private void btnPapelera_Click(object sender, EventArgs e)
        {
            FormPapelera form = new FormPapelera();
            form.ShowDialog();

        }
    }
}
