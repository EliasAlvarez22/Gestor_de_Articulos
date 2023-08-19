using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Gestor_de_ventas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void AbrirFormulario<MiForm> () where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None; // Saca el borde
                formulario.Dock = DockStyle.Fill;// Para que el form se llene en el panel/ control primario
                panelFormularios.Controls.Add(formulario);
                formulario.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();

            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
             AbrirFormulario<frmArticulos>();
        }

        private void BtnAgregarArticulo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmNuevoArticulo>();
        }
    }
}
