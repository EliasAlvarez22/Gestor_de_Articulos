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
        private OpenFileDialog archivo = null;
        public frmNuevoArticulo()
        {
            InitializeComponent();
        }

        public frmNuevoArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
            LblArticuloNuevo.Text = "Modificar Artículo";
        }
        

        // Para cerrar el form


        // Para Agregar a la DB el nuevo Articulo o modificar el Articulo
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            ArticuloNegocio Negocio = new ArticuloNegocio();
           
            try
            {
                if (ValidarCamposArticulo())
                    return;

                if (articulo == null)
                    articulo = new Articulo();

                articulo.CodigoArticulo = txtCodArticulo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.ImagenUrl = txtUrlImagen.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
               
                // Modifica el articulo de la DB
                if(articulo.Id  != 0)
                {
                    Negocio.ModificarArticulo(articulo);
                    MessageBox.Show("Modificado exitosamente");
                    Close();
                } //Agrega el articulo a la DB
                else
                {
                    Negocio.Agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                    BtnAgregar.Enabled = false;
                    LblValidacionAgregar.Text = "Artículo agregado, puede cerrar la ventana";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            // No lo cierro porque no pude hacer que se cierre el tabPage luego de que se agregue un articulo
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

            /* Si no es null significa que tiene una instancia y es un Articulo existente y 
               carga sus datos */
            if (articulo != null)
            {
                txtCodArticulo.Text = articulo.CodigoArticulo;
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;
                txtUrlImagen.Text = articulo.ImagenUrl;
                CargarImagen(articulo.ImagenUrl);
                cboMarca.SelectedValue = articulo.Marca.Id;
                cboCategoria.SelectedValue = articulo.Categoria.Id;
                txtPrecio.Text = articulo.Precio.ToString();
                BtnAgregar.Text = "Modificar artículo";
            }
        }
        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            string imagen = txtUrlImagen.Text;
            CargarImagen(imagen);
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                PbxImagen.Load(imagen);

            }
            catch (Exception)
            {
                PbxImagen.Load("https://media.istockphoto.com/id/1296187581/es/foto/caja-de-cart%C3%B3n-abierta-vac%C3%ADa-vista-de-%C3%A1ngulo-alto.jpg?s=612x612&w=0&k=20&c=8Xmxs5nDOZB8uZpovwBpXgJ1-YuqUUsqNEJawLYhwAE=");
            }
        }

        //Sirve para reiniciar todos los campos del formulario
        private void BtnInicializar_Click(object sender, EventArgs e)
        {


            txtCodArticulo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtUrlImagen.Text = "";
            cboMarca.SelectedItem= null;
            cboCategoria.SelectedItem = null;
            cboCategoria.SelectedIndex = -1;
            cboMarca.SelectedIndex = -1;
            txtPrecio.Text = "";
        }

        private void BtnAgregarimagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            try
            {
                archivo.Filter = "jpg|*.jpg;|png|*.png";
                if (archivo.ShowDialog() == DialogResult.OK)
                {
                    txtUrlImagen.Text = archivo.FileName;
                    CargarImagen(archivo.FileName);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }           
        }
        private bool ValidarCamposArticulo()
        {
            if (string.IsNullOrWhiteSpace(txtCodArticulo.Text))
            {
                pbxCodigo.Visible = true;
            }
            else
            {
                pbxCodigo.Visible = false;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                pbxNombre.Visible = true;
            }
            else
            {
                pbxNombre.Visible = false;
            }
            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                pbxPrecio.Visible = true;
            }
            else
            {
                pbxPrecio.Visible = false;
            }

           
            if (pbxCodigo.Visible == true || pbxNombre.Visible == true ||
                 pbxPrecio.Visible == true)
            {
                LblValidacionAgregar.Text = "Complete los datos necesarios";
                return true;
            }
            else
                return false;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número (código ASCII entre 48 y 57)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Suprime la tecla presionada si no es un número
            }
        }

        
    }  
}
