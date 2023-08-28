using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Gestor_de_ventas
{
    public partial class FrmAltaCategoria : Form
    {
        private Categoria categoria = null;
        public FrmAltaCategoria()
        {
            InitializeComponent();
        }
        public FrmAltaCategoria(Categoria categoria)           
        {
            InitializeComponent();
            this.categoria = categoria;
            LblTituloCategoria.Text = "Modificar categoría";
            BtnAgregar.Text = "Modificar";
            Text = "Modificar Marca";
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            //Validaciones

            if(txtDescripcion.Text == "")
            {
                lblValidacion.Text = "Complete la descripción";
                return;

            }
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if(categoria == null)         
                    categoria = new Categoria();

                categoria.Descripcion = txtDescripcion.Text; 
                
                if(categoria.Id != 0)
                {
                    negocio.ModificarCategoria(categoria);
                    MessageBox.Show("Modificado correctamente");
                }
                else
                {
                    negocio.AgregarCategoria(categoria);
                    MessageBox.Show("Agregado correctamente");
                }
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()) ;
            }                                                    
        }

        private void FrmAltaCategoria_Load(object sender, EventArgs e)
        {

            if (categoria != null)
            {
                txtDescripcion.Text = categoria.Descripcion;
            }
        }
    }
}
