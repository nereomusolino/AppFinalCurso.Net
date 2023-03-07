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
using System.Drawing.Text;

namespace AppFinal
{
    public partial class FormApp : Form
    {
        private List<Articulos> lista = new List<Articulos>();
        //private List<Articulos> listaPapelera = null;

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
            cmbCriterio.SelectedIndex = -1;
            cmbCampo.SelectedIndex = -1;
            txbFiltro.Text = " ";

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
            try
            {
                CargarBase();
                OcultarListas();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo volver a la base original");
            }

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
            //FiltroPapelera();
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
            if (cmbCampo.SelectedIndex != -1)
            {
                string opcion = cmbCampo.SelectedItem.ToString();

                if (opcion == "Nombre")
                {

                    cmbCriterio.Items.Clear();
                    cmbCriterio.Items.Add("Comienza con");
                    cmbCriterio.Items.Add("Termina con");
                    cmbCriterio.Items.Add("Contiene");

                }
                else if (opcion == "Marca")
                {
                    cmbCriterio.Items.Clear();
                    cmbCriterio.Items.Add("Comienza con");
                    cmbCriterio.Items.Add("Termina con");
                    cmbCriterio.Items.Add("Contiene");

                }
                else if (opcion == "Categoría")
                {
                    cmbCriterio.Items.Clear();
                    cmbCriterio.Items.Add("Comienza con");
                    cmbCriterio.Items.Add("Termina con");
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
            DialogResult respuesta = MessageBox.Show("Esta seguro que desea eliminar?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(respuesta == DialogResult.Yes)
            {
                try
                {
                    //aux.EliminarLogico((Articulos)dgvLista.CurrentRow.DataBoundItem);
                    aux.EliminarFisico((Articulos)dgvLista.CurrentRow.DataBoundItem);
                    CargarBase();
                    //FiltroPapelera();
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo eliminar el dato");
                }
            }
            else if(respuesta == DialogResult.No)
            {
                return;
            }
        }
        /*
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
        *//*
        private void FiltroPapelera()
        {
            ArticulosNegocio aux = new ArticulosNegocio();
            listaPapelera = aux.ListarPapelera();
            if (ListaVacia(listaPapelera) == true)
            {
                btnPapelera.Enabled = true;
            }
            else
            {
                btnPapelera.Enabled = false;
            }
        }
        */
        private void btnPapelera_Click(object sender, EventArgs e)
        {
            FormPapelera form = new FormPapelera();
            form.ShowDialog();
            CargarBase();
            //FiltroPapelera();
        }

        private void btnModifcar_Click(object sender, EventArgs e)
        {

            FormAgregar Modificar = new FormAgregar((Articulos)dgvLista.CurrentRow.DataBoundItem);
            Modificar.ShowDialog();
            CargarBase();
            
        }

        private void txbBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> listaFiltrada;
            string filtro = txbBusqueda.Text;

            try
            {
                if(filtro != "")
                {
                    listaFiltrada = lista.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.MarcaArticulo.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.CategoriaArticulo.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                }
                else
                {
                    listaFiltrada = lista;
                }

                dgvLista.DataSource = null;
                dgvLista.DataSource = listaFiltrada;
                OcultarListas();

            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo encontrar el archivo");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio obj = new ArticulosNegocio();
            string campo;
            string criterio;
            string filtro;

            try
            {

                if (cmbCampo.SelectedIndex != -1 && cmbCriterio.SelectedIndex != -1 && txbFiltro.Text != " ") 
                {
                    campo = cmbCampo.SelectedItem.ToString();
                    criterio = cmbCriterio.SelectedItem.ToString();
                    filtro = txbFiltro.Text;
                    lista = obj.BusquedaAvanzada(campo, criterio, filtro);
                    dgvLista.DataSource = null;
                    dgvLista.DataSource = lista;
                    OcultarListas();
                }
                else
                {
                    MessageBox.Show("Llene todos los campos");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo realizar la búsqueda");
            }

        }

        private void btnDetallar_Click(object sender, EventArgs e)
        {
            FormDetalles form = new FormDetalles((Articulos)dgvLista.CurrentRow.DataBoundItem);
            form.ShowDialog();
        }
    }
}
