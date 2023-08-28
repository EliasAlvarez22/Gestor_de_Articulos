﻿using Gestor_de_ventas.views_Marcas;
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
                MarcaNegocio negocio = new();
                DialogResult resultado = MessageBox.Show("Seguro que desea eliminar?", "Eliminar Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    negocio.EliminarMarca(seleccionado.Id);
                    Refrescar();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
    }
}