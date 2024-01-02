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

namespace GestorArticulos
{
    public partial class FormPapelera : Form
    {
        private ArticuloNegocio negocio;

        public FormPapelera()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormPapelera_Load(object sender, EventArgs e)
        {
            Funcion.actualizarDgvPapelera(dgvArticulosPapelera);

            FormGestorArticulos gestor = Application.OpenForms["FormGestorArticulos"] as FormGestorArticulos;

            if (gestor != null)
            {
                gestor.EventoEnviarPapelera += Gestor_EnviarPapelera;
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            negocio = new ArticuloNegocio();
            Articulo seleccionado = new Articulo();

            if(dgvArticulosPapelera.RowCount == 0)
            {
                MessageBox.Show("Papelera vacia.");
                return;
            }

            if(dgvArticulosPapelera.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un elemento.");
                return;
            }

            seleccionado = (Articulo)dgvArticulosPapelera.CurrentRow.DataBoundItem;

            DialogResult = MessageBox.Show("¿Desea recuperar el artículo seleccionado?", "Recuperando..", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(DialogResult == DialogResult.Yes)
            {
                negocio.recuperar(seleccionado);
                MessageBox.Show("Artículo recuperado. Por favor actualice su precio.");
                EventoArticuloEliminado?.Invoke(this, EventArgs.Empty);                   //Ejecucion del evento

                Funcion.actualizarDgvPapelera(dgvArticulosPapelera);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            negocio = new ArticuloNegocio();
            Articulo seleccionado = new Articulo();

            if(dgvArticulosPapelera.RowCount == 0)
            {
                MessageBox.Show("Papelera vacia.");
                return;
            }

            if(dgvArticulosPapelera.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un elemento.");
                return;
            }

            seleccionado = (Articulo)dgvArticulosPapelera.CurrentRow.DataBoundItem;
            DialogResult = MessageBox.Show("¿Desea eliminar el artículo definitivamente?", "Eliminando..", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if(DialogResult == DialogResult.Yes)
            {
                negocio.eliminar(seleccionado);
                MessageBox.Show("Artículo eliminado.");

                Funcion.actualizarDgvPapelera(dgvArticulosPapelera);
               
            }

        }
        
        public event EventHandler EventoArticuloEliminado; //Declaracion del evento

        private void Gestor_EnviarPapelera(object sender, EventArgs e)
        {
            Funcion.actualizarDgvPapelera(dgvArticulosPapelera);
        }
    }
}
