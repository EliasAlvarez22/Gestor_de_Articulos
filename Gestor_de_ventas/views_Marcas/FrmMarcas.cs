using Gestor_de_ventas.views_Marcas;
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
using Dominio;
namespace Gestor_de_ventas
{
    public partial class FrmMarcas : Form
    {
        List<Marca> ListaMarcas = new List<Marca>();
        public FrmMarcas()
        {
            InitializeComponent();
        }        
        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            FrmAltaMarca alta = new();
            alta.ShowDialog();
            Refrescar();
        }

        private void Refrescar()
        {
            MarcaNegocio negocio = new();
            DgvMarcas.DataSource = null;
            ListaMarcas = negocio.ListarMarcas();
            DgvMarcas.DataSource = ListaMarcas;
            DgvMarcas.Columns["Id"].Visible = false;

            if (DgvMarcas.Rows.Count > 0)
            {
                DgvMarcas.CurrentCell = DgvMarcas.Rows[0].Cells[1];
            }                            
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Validacion para que no haga nada si no tiene ninguno
            if (DgvMarcas.Rows.Count < 0)
                return;
            Marca seleccionado = (Marca)DgvMarcas.CurrentRow.DataBoundItem;            
            FrmAltaMarca alta = new(seleccionado);
            alta.ShowDialog();
            Refrescar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validacion para que no haga nada si no tiene ninguno
                if (DgvMarcas.Rows.Count < 0)
                    return;
                Marca seleccionado = (Marca)DgvMarcas.CurrentRow.DataBoundItem;
                MarcaNegocio negocioMarca = new MarcaNegocio();
                
                //La Marca Default no se puede eliminar
                int idAux = negocioMarca.BuscarIdDefault();

                if (seleccionado.Id == idAux)
                {
                    MessageBox.Show("Esta marca no puede eliminarse, es la Marca Default", "Marca Default", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                int marcaUsada = negocioMarca.ContarMarcaEnUso(seleccionado.Id);
                //si se usa la marca, no se puede eliminar. Sino si.
                
                if ( marcaUsada > 0 )
                {
                    DialogResult confirmarEliminacion = MessageBox.Show($"Esta marca se está usando {marcaUsada} vez/veces .Se reemplazará por la Marca Default ¿Seguro que desea continuar?", "Marca en uso", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if(confirmarEliminacion == DialogResult.Yes)
                    {
                        DialogResult EliminacionConfirmada = MessageBox.Show("¿Seguro que desea eliminar?", "Eliminar Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (EliminacionConfirmada == DialogResult.Yes)
                        {
                            negocioMarca.AsignarMarcaDefault(seleccionado.Id);
                            negocioMarca.EliminarMarca(seleccionado.Id);
                            Refrescar();
                            return;
                        }
                    }
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar?", "Eliminar Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        negocioMarca.EliminarMarca(seleccionado.Id);
                        Refrescar();
                    }
                }

                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocioMarca = new();
            try
            {
                negocioMarca.CrearIdDefault();
                Refrescar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
