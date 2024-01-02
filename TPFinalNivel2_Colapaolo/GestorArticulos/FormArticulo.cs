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
    public partial class FormArticulo : Form
    {
        private Articulo articulo = null;
        private ArticuloNegocio negocio;

        public FormArticulo()
        {
            InitializeComponent();
            this.Text = "Agregar Artículo";
        }
       
        public FormArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            this.Text = "Modificar Artículo";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
               

                if(articulo != null)
                {
                    cbMarca.DataSource = marcaNegocio.listar();
                    cbMarca.ValueMember = "Id";
                    cbMarca.DisplayMember = "Descripcion";
                    cbCategoria.DataSource = categoriaNegocio.listar();
                    cbCategoria.ValueMember = "Id";
                    cbCategoria.DisplayMember = "Descripcion";
                

                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagenUrl.Text = articulo.ImagenUrl;
                    nudPrecio.Value = articulo.Precio;
                    cbMarca.SelectedValue = articulo.Marca.Id;
                    cbCategoria.SelectedValue = articulo.Categoria.Id;

                    Funcion.cargarImagen(pbArticulo, txtImagenUrl.Text);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            Funcion.cargarImagen(pbArticulo, txtImagenUrl.Text);
        }

        private bool close = false;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            negocio = new ArticuloNegocio();

            try
            {
                if (validarAceptar())
                {
                    MessageBox.Show("Revise e ingrese los datos correctamente.");
                    if(txtCodigo.Text == "")
                        txtCodigo.BackColor = Color.Salmon;
                    else
                        txtCodigo.BackColor = Color.White;

                    if (txtNombre.Text == "")
                        txtNombre.BackColor = Color.Salmon;
                    else
                        txtNombre.BackColor = Color.White;

                    if (cbCategoria.SelectedIndex == -1)
                        errorCategoria.SetError(cbCategoria, "Seleccione una Categoría.");
                    else
                        errorCategoria.SetError(cbCategoria, "");

                    if (cbMarca.SelectedIndex == -1)
                        errorMarca.SetError(cbMarca, "Seleccione una Marca.");
                    else
                        errorMarca.SetError(cbMarca, "");

                    if (nudPrecio.Value <= 0)
                        errorPrecio.SetError(nudPrecio, "El precio debe ser superior a 0.");
                    else
                        errorPrecio.SetError(nudPrecio, "");


                    return;
                }
              

                if (articulo == null)
                    articulo = new Articulo();
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.ImagenUrl = txtImagenUrl.Text;
                articulo.Precio = nudPrecio.Value;
                

                if(articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Artículo modificado exitosamente.");
                    close = true;
                    Close();
                    
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Artículo agregado exitosamente.");
                    close = true;
                    Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cbMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {

                cbMarca.DataSource = marcaNegocio.listar();
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void cbCategoria_Click(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cbCategoria.DataSource = categoriaNegocio.listar();
                cbCategoria.ValueMember = "Id";
                cbCategoria.DisplayMember = "Descripcion";

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void FormArticulo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(close == false)
            {

                if (articulo == null)
                {
                    DialogResult resultado = MessageBox.Show("¿Desea salir sin agregar el artículo?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (resultado == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Desea salir sin aplicar cambios?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (resultado == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
              
                }

            }
        }



        //Metodo Validar
        private bool validarAceptar()
        {
            if(txtCodigo.Text == "" || txtNombre.Text == "" || cbMarca.SelectedItem == null || cbCategoria.SelectedItem == null || nudPrecio.Value <= 0)
            {
                return true;
            }
            return false;
        }



        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if(txtCodigo.Text == "")
                txtCodigo.BackColor = Color.Salmon;
            else
                txtCodigo.BackColor = Color.White;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Salmon;
            else
                txtNombre.BackColor = Color.White;
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMarca.SelectedIndex == -1)
                errorMarca.SetError(cbMarca, "Seleccione una Marca.");
            else
                errorMarca.SetError(cbMarca, "");
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedIndex == -1)
                errorCategoria.SetError(cbCategoria, "Seleccione una Categoría.");
            else
                errorCategoria.SetError(cbCategoria, "");
        }

        private void nudPrecio_ValueChanged(object sender, EventArgs e)
        {
            if (nudPrecio.Value <= 0)
                errorPrecio.SetError(nudPrecio, "El precio debe ser superior a 0.");
            else
                errorPrecio.SetError(nudPrecio, "");
        }

    }
}
