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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }


        private void FrmInicio_Load(object sender, EventArgs e)
        {
            ActualizarContadores();
        }

        
        private void ActualizarContadores()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            MarcaNegocio negocioMarcas = new MarcaNegocio();
            try
            {
                //Contar Articulos
                LblContadorArticulos.Text = negocio.ContarArticulos().ToString();
                LblContadorMarcas.Text = negocioMarcas.ContarMarcas().ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnActualizarTotales_Click(object sender, EventArgs e)
        {
            ActualizarContadores();
        }
    }
}
