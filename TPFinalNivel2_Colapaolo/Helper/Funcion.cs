using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Helper
{
    public static class Funcion
    {
        public static void cargarImagen(PictureBox pbArticulo, string imagen)
        {
            try
            {
            pbArticulo.Load(imagen);

            }
            catch (Exception)
            {

                pbArticulo.Load("https://i.imgur.com/o2g90MG.png");
            }
        }

        public static void actualizarDgvPapelera(DataGridView dgvArticulosPapelera)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listaArticulos = negocio.listarPapelera();
            dgvArticulosPapelera.DataSource = listaArticulos;
            
            ajustarColumnas(dgvArticulosPapelera);

            dgvArticulosPapelera.Columns["Id"].Visible = false;
            dgvArticulosPapelera.Columns["ImagenUrl"].Visible = false;
            dgvArticulosPapelera.Columns["Precio"].Visible = false;
            dgvArticulosPapelera.Columns["Descripcion"].Visible = false;
        }

        public static void ajustarColumnas(DataGridView dgvArticulos)
        {
            dgvArticulos.RowHeadersWidth = 24;
            dgvArticulos.Columns["Codigo"].Width = 45;
            dgvArticulos.Columns["Nombre"].Width = 124;
            dgvArticulos.Columns["Descripcion"].Width = 120;
            dgvArticulos.Columns["Marca"].Width = 60;
            dgvArticulos.Columns["Categoria"].Width = 80;
            dgvArticulos.Columns["Precio"].Width = 76;
        }

        public static void actualizarDgv(DataGridView dgvArticulos, PictureBox pbArticulo, List<Articulo> listaArticulos)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listar();
            dgvArticulos.DataSource = listaArticulos;
            pbArticulo.Load(listaArticulos[0].ImagenUrl);

            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Codigo"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;

            ajustarColumnas(dgvArticulos);

        }

        public static void ocultarColumnas(DataGridView dgvArticulos)
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Codigo"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
        }

        public static List<Articulo> listaArticulosFiltrados { get; set; }

        public static bool soloNumeros(string cadena)
        {
            foreach(char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }

            return true;
        }
    }
}
