using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Helper;

namespace GestorArticulos
{
    public partial class FormBusquedaAvanzada : Form
    {
        public FormBusquedaAvanzada()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listaArticulos = new List<Articulo>();
            if(cbCampo.SelectedItem == null || cbCondicion.SelectedItem == null || txtFiltro.Text == "")
            {
                MessageBox.Show("Ingrese correctamente los datos de busqueda.");
                return;
            }

            if((string)cbCampo.SelectedItem == "Precio" && !(Funcion.soloNumeros(txtFiltro.Text)))
            {
                MessageBox.Show("Precio seleccionado. Solo ingrese numeros.");
                return;
            }
            listaArticulos = negocio.filtrar(cbCampo.SelectedItem.ToString(), cbCondicion.SelectedItem.ToString(), txtFiltro.Text);
            Funcion.listaArticulosFiltrados = listaArticulos;
            EventoBuscar?.Invoke(this, EventArgs.Empty);
        }

        private void FormBusquedaAvanzada_Load(object sender, EventArgs e)
        {
            cbCampo.Items.Add("Nombre");
            cbCampo.Items.Add("Marca");
            cbCampo.Items.Add("Categoría");
            cbCampo.Items.Add("Precio");

        }

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string campo = cbCampo.SelectedItem.ToString();

            if(campo == "Precio")
            {
                lblCondicion.Text = "Condición";
                txtFiltro.Enabled = true;
                txtFiltro.Text = "";
                cbCondicion.DataSource = null;
                cbCondicion.Items.Clear();
                cbCondicion.Items.Add("Mayor a..");
                cbCondicion.Items.Add("Menos a..");
                cbCondicion.Items.Add("Igual a..");
            }
            else if (campo == "Marca")
            {
                lblCondicion.Text = "Tipo";
                MarcaNegocio negocio = new MarcaNegocio();
                cbCondicion.DataSource = negocio.listar();
                txtFiltro.Enabled = false;
                txtFiltro.Text = cbCondicion.SelectedValue.ToString();
            }
            else if (campo == "Categoría")
            {
                lblCondicion.Text = "Tipo";
                CategoriaNegocio negocio = new CategoriaNegocio();
                cbCondicion.DataSource = negocio.listar();
                txtFiltro.Enabled = false;
                txtFiltro.Text = cbCondicion.SelectedValue.ToString();
            }
            else
            {
                lblCondicion.Text = "Condición";
                txtFiltro.Enabled = true;
                txtFiltro.Text = "";
                cbCondicion.DataSource = null;
                cbCondicion.Items.Clear();
                cbCondicion.Items.Add("Empieza con..");
                cbCondicion.Items.Add("Termina con..");
                cbCondicion.Items.Add("Contiene..");
            }
        }
        private void cbCondicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string campo = cbCampo.SelectedItem.ToString();

            if (campo == "Categoría" || campo == "Marca")
            {
                txtFiltro.Text = cbCondicion.SelectedValue.ToString(); 
            }
        }

        private void cbCondicion_Click(object sender, EventArgs e)
        {
            if(cbCondicion.SelectedItem == null && cbCampo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un campo.");
            }
        }

        public event EventHandler EventoBuscar;

    }
}
