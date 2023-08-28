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
                ArticuloNegocio negocio = new ArticuloNegocio();
                this.marca = marca;
                txtDescripcion.Text = marca.Descripcion;
                LblTitulo.Text = "Modificar Marca";
                Text = "Modificar Marca";
                btnAgregar.Text = "Modificar";
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

        }
    }
}
