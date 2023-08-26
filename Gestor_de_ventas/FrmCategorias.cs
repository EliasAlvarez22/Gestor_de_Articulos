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
    public partial class FrmCategorias : Form
    {
        List<Categoria> listaCategorias;
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            

            listaCategorias = negocio.ListarCategorias();
            DgvCategorias.DataSource = listaCategorias;
            OcultarColumnas();

        }
        private void OcultarColumnas()
        {
            DgvCategorias.Columns["Id"].Visible = false;
        }

        private void BtnAgregarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAltaCategoria frmAltaCategoria = new FrmAltaCategoria();
                frmAltaCategoria.ShowDialog();
                Refrescar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void Refrescar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            listaCategorias = negocio.ListarCategorias();
            DgvCategorias.DataSource = listaCategorias;
            OcultarColumnas();
        }
    }
}
