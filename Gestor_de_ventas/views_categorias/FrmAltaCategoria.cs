using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            //Valida que no se ingrese otra Categoria Default
            string CategoriaDefault = "sin categoría".ToUpper();
            string categoriaDef = "sin categoria".ToUpper();
            if ((txtDescripcion.Text.ToUpper() == CategoriaDefault) || (txtDescripcion.Text.ToUpper() == categoriaDef))
            {
                lblValidacion.Text = "Ya existe la Categoria Default 'Sin Categoría'";
                return;
            }                       
            if (txtDescripcion.Text == "")
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
            CategoriaNegocio negocioCategoria = new();
            try
            {
                if (categoria != null)
                {
                    Text = "Modificar Categoría";
                    txtDescripcion.Text = categoria.Descripcion;
                    LblTituloCategoria.Text = "Modificar Categoria";
                    BtnAgregar.Text = "Modificar";
                    lblCategoriasUsadas.Text = "Categoría usada en             articulos";
                    lblContarCategorias.Text = negocioCategoria.ContarCategoriaEnUso(categoria.Id).ToString();
                }
                else                
                    lblCategoriasUsadas.Text = "";               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
