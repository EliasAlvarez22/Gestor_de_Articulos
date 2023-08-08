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
    public partial class frmArticulos : Form
    {
        private List<Articulo> ListaArticulos = new List<Articulo>();
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                ListaArticulos = negocio.ListarArticulos();

                DgvArticulos.DataSource = ListaArticulos;

                OcultarColumnas();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void OcultarColumnas()
        {
            DgvArticulos.Columns["ImagenUrl"].Visible = false;
            DgvArticulos.Columns["Id"].Visible = false;
        }

        private void DgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvArticulos.CurrentRow != null)
            {
                Articulo ArticuloSeleccionado= (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
            }
        }

        private void BtnEditarArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
            frmNuevoArticulo Modificar = new frmNuevoArticulo(seleccionado);
            Modificar.Show();
        }
    }
}
