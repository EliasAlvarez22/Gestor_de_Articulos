using Dominio;
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

namespace Gestor_de_ventas
{
    public partial class frmNuevoArticulo : Form
    {
        private Articulo articulo = null;
        public frmNuevoArticulo()
        {
            InitializeComponent();
        }

        public frmNuevoArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
            LblArticuloNuevo.Text = "Modificar Articulo";
        }

       

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio Negocio = new ArticuloNegocio();
           
            try
            {
                if (articulo == null)
                    articulo = new Articulo();


                articulo.CodigoArticulo = txtCodArticulo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.ImagenUrl = txtUrlImagen.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
               

                Negocio.Agregar(articulo);
                MessageBox.Show("Agregado exitosamente");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            Close();

        }

        private void frmNuevoArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio NegocioCategorias = new CategoriaNegocio();
            MarcaNegocio NegocioMarcas = new MarcaNegocio();

            cboCategoria.DataSource = NegocioCategorias.ListarCategorias();
            cboCategoria.ValueMember = "Id";
            cboCategoria.DisplayMember = "Descripcion";
            cboMarca.DataSource = NegocioMarcas.ListarMarcas();
            cboMarca.ValueMember = "Id";
            cboMarca.DisplayMember = "Descripcion";

            //Para que aparezcan vacíos
            cboMarca.SelectedIndex = -1;
            cboCategoria.SelectedIndex = -1;


            if (articulo != null)
            {
                txtCodArticulo.Text = articulo.CodigoArticulo;
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;
                txtUrlImagen.Text = articulo.ImagenUrl;
                //cargarImagen(pokemon.UrlImagen);
                cboMarca.SelectedValue = articulo.Marca.Id;
                cboCategoria.SelectedValue = articulo.Categoria.Id;
                txtPrecio.Text = articulo.Precio.ToString();
            }
        }
    }
}
