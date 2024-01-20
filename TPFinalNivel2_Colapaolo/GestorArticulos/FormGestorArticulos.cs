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
using Negocio;
using Helper;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestorArticulos
{
    public partial class FormGestorArticulos : Form
    {
        private List<Articulo> listaArticulos;
        private List<Articulo> listaArticulosFiltrada;
        private ArticuloNegocio negocio;

        public FormGestorArticulos()
        {
            InitializeComponent();
        }

        private void FormGestorArticulos_Load(object sender, EventArgs e)
        {
                negocio = new ArticuloNegocio();

            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                pbArticulo.Load(listaArticulos[0].ImagenUrl);

                Funcion.ocultarColumnas(dgvArticulos);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show("Bienvenido!");
            txtBuscar.Text = "Buscar";
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            Funcion.cargarImagen(pbArticulo, seleccionado.ImagenUrl);

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            txtBuscar.Text = "Buscar";
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                List<Articulo> listaFiltrada = new List<Articulo>();
                string filtro = txtBuscar.Text;

                if(filtro != "")
                {
                    listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Codigo.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                }
                else
                {
                    listaFiltrada = listaArticulos;
                }

                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaFiltrada;
                Funcion.ocultarColumnas(dgvArticulos);
            }
        }

        private FormBusquedaAvanzada busquedaAvanzada = null;
        private void btnBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            if(busquedaAvanzada == null || busquedaAvanzada.IsDisposed)
            {

                busquedaAvanzada = new FormBusquedaAvanzada();
                busquedaAvanzada.EventoBuscar += Filtro_EventoBuscar;
                busquedaAvanzada.Show();

            }
            else
            {
                busquedaAvanzada.Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormArticulo articulo = new FormArticulo();
            articulo.ShowDialog();
            Funcion.actualizarDgv(dgvArticulos, pbArticulo, listaArticulos);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.RowCount == 0 || dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un artículo.");
                return;
            }

            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            FormArticulo articulo = new FormArticulo(seleccionado);
            articulo.ShowDialog();
            Funcion.actualizarDgv(dgvArticulos, pbArticulo, listaArticulos);
        }

        private FormPapelera papelera = null;
        private void btnPapelera_Click(object sender, EventArgs e)
        { 
            if(papelera == null || papelera.IsDisposed)
            {
                papelera = new FormPapelera();
                papelera.EventoArticuloEliminado += Papelera_EventoArticuloEliminado;  //Suscripcion al evento
                papelera.Show();
                
            }
            else
            {
                papelera.Close();
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.RowCount == 0)
            {
                MessageBox.Show("Seleccione un artículo.");
                return;
            }

            negocio = new ArticuloNegocio();
            Articulo seleccionado = new Articulo();
            if(dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un artículo.");
                return;
            }
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            DialogResult = MessageBox.Show("¿Desea enviar el artículo a la papelera?", "Eliminando..", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (DialogResult == DialogResult.Yes)
            {
                negocio.eliminarPapelera(seleccionado);
                MessageBox.Show("Artículo enviado a la papelera.");
                EventoEnviarPapelera?.Invoke(this, EventArgs.Empty);

                Funcion.actualizarDgv(dgvArticulos, pbArticulo, listaArticulos);
                
            }

            
        }


        //EVENTOS
        //Metodo relacionado con el evento de la papelera
        private void Papelera_EventoArticuloEliminado(object sender, EventArgs e)
        {
            Funcion.actualizarDgv(dgvArticulos, pbArticulo, listaArticulos);
        }

        public event EventHandler EventoEnviarPapelera;

        //Busqueda Avanzada
        private void Filtro_EventoBuscar(object sender, EventArgs e)
        {
            listaArticulosFiltrada = Funcion.listaArticulosFiltrados;
            dgvArticulos.DataSource = listaArticulosFiltrada;
            if(dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Elemento no encontrado.");
                Funcion.actualizarDgv(dgvArticulos, pbArticulo, listaArticulos);
                return;
            }
            else
            {
                Funcion.cargarImagen(pbArticulo, listaArticulosFiltrada[0].ImagenUrl);
            }
            Funcion.ocultarColumnas(dgvArticulos);
        }

        private void FormGestorArticulos_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Hasta luego!");
        }

        System.Windows.Forms.ToolTip TipBuscar;
        private void txtBuscar_MouseEnter(object sender, EventArgs e)
        {
            TipBuscar = new System.Windows.Forms.ToolTip();
            TipBuscar.ToolTipTitle = string.Empty;
            TipBuscar.ToolTipIcon = ToolTipIcon.Info;
            TipBuscar.IsBalloon = true;
            TipBuscar.Show("Puede buscar por Nombre, Categoría o Marca.\nPresione ENTER para buscar", txtBuscar, 0, -100, 5000);
        }

        private void txtBuscar_MouseLeave(object sender, EventArgs e)
        {
            TipBuscar.Hide(txtBuscar);
        }

    }
}
