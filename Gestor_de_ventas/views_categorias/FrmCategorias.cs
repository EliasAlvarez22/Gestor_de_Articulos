using Dominio;
using Negocio;
using System;
using System.Collections;
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
            CategoriaNegocio negocioCategoria = new();
            try
            {
                negocioCategoria.CrearIdDefaultCategoria();
                Refrescar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
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
            if (DgvCategorias.Rows.Count > 0)
            {
                DgvCategorias.CurrentCell = DgvCategorias.Rows[0].Cells[1];
            }
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Valida si no tiene Categorias, que no haga nada.
            if (DgvCategorias.RowCount == 0)
                return;
            Categoria seleccionado;
            try
            {
                seleccionado = (Categoria)DgvCategorias.CurrentRow.DataBoundItem;
                FrmAltaCategoria Modificar = new FrmAltaCategoria(seleccionado);
                Modificar.ShowDialog();
                Refrescar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnEliminarCategoria_Click(object sender, EventArgs e)
        {
            //Valida si no tiene Categorias, que no haga nada.
            if (DgvCategorias.RowCount == 0)
                return;
            Categoria seleccionado;
            CategoriaNegocio negocio = new();
            
            try
            {
                seleccionado = (Categoria)DgvCategorias.CurrentRow.DataBoundItem;
                //La categoría Default no se puede eliminar
                int idAux = negocio.BuscarIdDefault();
                if (seleccionado.Id == idAux)
                {
                    MessageBox.Show("Esta categoría no puede eliminarse, es la Categoría Default", "Categoría Default", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                //si se usa la marca, no se puede eliminar. Sino si.
                int CategoriaUsada = negocio.ContarCategoriaEnUso(seleccionado.Id);
                if (CategoriaUsada > 0)
                {
                    MessageBox.Show("Esta categoría no puede eliminarse, categoría en uso", "Categoría en uso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult resultado = MessageBox.Show("Seguro que desea eliminar?", "Eliminar categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    negocio.EliminarCategoria(seleccionado.Id);
                    Refrescar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
