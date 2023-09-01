using Dominio;
using Negocio;
using System;
using System.Windows.Forms;

namespace Gestor_de_ventas.views_Marcas
{
    public partial class FrmAltaMarca : Form
    {
        Marca marca = null;
        public FrmAltaMarca()
        {
            InitializeComponent();
        }
        public FrmAltaMarca(Marca marca)
        {
            try
            {
                InitializeComponent();
                this.marca = marca;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //Valida que no se ingrese otra marca Default
                string MarcaDefault = "Sin Marca".ToUpper();
                if (txtDescripcion.Text.ToUpper() == MarcaDefault)
                {
                    lblValidacion.Text = "Ya existe la Marca Default 'Sin Marca'";
                    return;
                }
                //Validaciones
                if (txtDescripcion.Text == "")
                {
                    lblValidacion.Text = "Complete la descripción";
                    return;
                }
                
                
                if (marca == null)
                    marca = new Marca();
                MarcaNegocio negocio = new();
                marca.Descripcion = txtDescripcion.Text;

                if (marca.Id != 0)
                {
                    negocio.ModificarMarca(marca);
                }
                else
                {
                    negocio.AgregarMarca(marca);
                }
                Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }            
        }

        private void FrmAltaMarca_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocioMarca = new MarcaNegocio();
            try
            {
                //Significa que ya es una marca creada
                if(marca != null)
                {
                    lblMarcasUsadas.Text = "Marca usada en             articulos";
                    txtDescripcion.Text = marca.Descripcion;
                    LblTitulo.Text = "Modificar Marca";
                    Text = "Modificar Marca";
                    btnAgregar.Text = "Modificar";
                    lblContarMarcas.Text = negocioMarca.ContarMarcaEnUso(marca.Id).ToString();
                }
                else
                {
                    lblMarcasUsadas.Text = "";
                }
            }
            catch (Exception ex)
            {

                 MessageBox.Show(ex.ToString());
            }
        }
    }
}
