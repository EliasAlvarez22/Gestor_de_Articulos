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
        private bool FormularioEstaAbierto(Type tipoFormulario)
        {
            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == tipoFormulario)
                {
                    return true; // El formulario está abierto
                }
            }
            return false; // El formulario no está abierto
        }

        private void AbrirFormulario<MiForm>(string titulo) where MiForm : Form, new()
        {
            
            Form formulario = TcoMenu.Controls.OfType<MiForm>().FirstOrDefault();
            if (!FormularioEstaAbierto(typeof(MiForm)))
            {
                if (formulario == null)
                {
                    try
                    {
                        TabPage Tab = new TabPage(titulo);
                        formulario = new MiForm();
                        formulario.TopLevel = false;
                        formulario.Parent = Tab;
                        formulario.FormBorderStyle = FormBorderStyle.None;
                        formulario.Dock = DockStyle.Fill;
                        formulario.Show();

                        // Boton para cerrar
                        Button BotonCerrar = new Button();
                        BotonCerrar.BackColor = Color.White;
                        BotonCerrar.Text = "Cerrar Ventana";
                        BotonCerrar.Dock = DockStyle.Top;
                        BotonCerrar.Height = 40;
                        /* Evento para cerrar el form, Cierra el form, remueve del tabControl y por las dudas cierra las referencias 
                         Que pudieran quedar abiertas*/
                        BotonCerrar.Click += (sender, e) =>
                        {
                            TcoMenu.TabPages.Remove(Tab);
                            formulario.Dispose();
                        };
                        BotonCerrar.Font = new Font("Microsoft Sans Serif", 22);

                        Tab.Controls.Add(BotonCerrar);
                        TcoMenu.TabPages.Add(Tab);
                        TcoMenu.SelectedTab = Tab;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    
                }
                else
                {
                    // Para llevarlo al frente si ya esta abierto
                    TcoMenu.SelectedTab = formulario.Parent as TabPage;
                }

            }
            

        }
        private void btnArticulos_Click(object sender, EventArgs e)
        {

            AbrirFormulario<frmArticulos>("Lista de Artículos");
        }

        private void BtnAgregarArticulo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmNuevoArticulo>("Artículo");
        }

        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmCategorias>("Lista de Categorías");
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmInicio>("Inicio");
        }

        private void BtnMarcas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmMarcas>("Ver Marcas");

        }
    }
}
