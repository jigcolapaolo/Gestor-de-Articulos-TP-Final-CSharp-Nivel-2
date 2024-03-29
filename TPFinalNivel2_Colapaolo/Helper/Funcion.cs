﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;
using System.IO;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

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

                string rutaImagen = Path.Combine(System.Windows.Forms.Application.StartupPath, "Imagenes", "Image_not_available.png");
                pbArticulo.Load(rutaImagen);

            }
        }

        public static void actualizarDgvPapelera(DataGridView dgvArticulosPapelera)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listaArticulos = negocio.listarPapelera();
            dgvArticulosPapelera.DataSource = listaArticulos;
        

            dgvArticulosPapelera.Columns["Id"].Visible = false;
            dgvArticulosPapelera.Columns["ImagenUrl"].Visible = false;
            dgvArticulosPapelera.Columns["Precio"].Visible = false;
            dgvArticulosPapelera.Columns["Descripcion"].Visible = false;
            dgvArticulosPapelera.Columns["Marca"].Visible = false;
            dgvArticulosPapelera.Columns["Categoria"].Visible = false;
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
