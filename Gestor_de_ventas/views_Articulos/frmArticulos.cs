﻿using Dominio;
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
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using OfficeOpenXml;

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
                //Grid de articulos
                ListaArticulos = negocio.ListarArticulos();
                DgvArticulos.DataSource = ListaArticulos;
                OcultarColumnas();

                if (DgvArticulos.Rows.Count > 0)
                {
                    DgvArticulos.Rows[0].Selected = true;
                    DgvArticulos.CurrentCell = DgvArticulos.Rows[0].Cells[1];
                }
                //Campos
                CboCampo.Items.Clear();
                CboCampo.Items.Add("Precio");
                CboCampo.Items.Add("Código");
                CboCampo.Items.Add("Marcas");
                CboCampo.Items.Add("Categorías");
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
                Articulo ArticuloSeleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
            }
        }

        private void BtnEditarArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            //Valida si no tiene articulos, que no haga nada.
            if (DgvArticulos.RowCount == 0)
                return;
            try
            {                
                seleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
                frmNuevoArticulo Modificar = new frmNuevoArticulo(seleccionado);
                Modificar.ShowDialog();
                RefrescarGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void RefrescarGrid()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ListaArticulos = negocio.ListarArticulos();
            DgvArticulos.DataSource = ListaArticulos;
            OcultarColumnas();
        }
        

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            RefrescarGrid();
        }
        //Exportar PDF con iTextSharp, se oculta la url de Imagen en la exportacion
        private void BtnExportarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                //Valida si no tiene articulos, que no haga nada.
                if (DgvArticulos.RowCount == 0)
                    return;

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    int[] columnasOcultar = { 6, 0 };
                    Document pdfDocument = new Document();
                    PdfWriter.GetInstance(pdfDocument, new FileStream(saveFileDialog.FileName, FileMode.Create));

                    pdfDocument.Open();
                    pdfDocument.AddAuthor("Gestor de Artículos");
                    //Encabezado
                    pdfDocument.Add(new Paragraph("Lista de Artículos"));
                    pdfDocument.Add(new Paragraph(Chunk.NEWLINE));

                    PdfPTable pdfTable = new PdfPTable(DgvArticulos.ColumnCount - columnasOcultar.Length); // Menos las columnas segun el tamano de las columnas a ocultar
                    pdfTable.WidthPercentage = 100;

                    for (int i = 0; i < DgvArticulos.ColumnCount; i++)
                    {
                        if (!columnasOcultar.Contains(i))
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(DgvArticulos.Columns[i].HeaderText));
                            cell.FixedHeight = 38f;
                            pdfTable.AddCell(cell);
                        }
                    }

                    pdfTable.HeaderRows = 1;

                    for (int row = 0; row < DgvArticulos.Rows.Count; row++)
                    {
                        for (int column = 0; column < DgvArticulos.Columns.Count; column++)
                        {
                            if (!columnasOcultar.Contains(column))
                            {
                                PdfPCell cell = new PdfPCell();
                                cell.FixedHeight = 20f;
                                if (DgvArticulos[column, row].Value != null)
                                {
                                    cell.Phrase = new Phrase(DgvArticulos[column, row].Value.ToString());
                                }
                                pdfTable.AddCell(cell);
                            }
                        }
                    }

                    pdfDocument.Add(pdfTable);
                    pdfDocument.Close();
                    MessageBox.Show("Archivo PDF exportado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnEliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            //Valida si no tiene articulos, que no haga nada.
            if (DgvArticulos.RowCount == 0)                          
                return;
            try
            {
                Articulo seleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
                DialogResult resultado = MessageBox.Show("Seguro que desea eliminar?", "Eliminar artículo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    negocio.EliminarArticulo(seleccionado.Id);
                    MessageBox.Show("Artículo eliminado correctamente");

                    RefrescarGrid();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }
            
        }
        private void CboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoriaNegocio NegocioCategorias = new CategoriaNegocio();
            MarcaNegocio NegocioMarcas = new MarcaNegocio();
            try
            {
                TxtFiltro.Enabled = true;
                string opcion = CboCampo.SelectedItem.ToString();
                CboCriterio.DataSource = null;

                if (opcion == "Precio")
                {
                    CboCriterio.Items.Clear();
                    CboCriterio.Items.Add("Mayor a");
                    CboCriterio.Items.Add("Menor a");
                    CboCriterio.Items.Add("Igual que");
                }
                if (opcion == "Código")
                {
                    CboCriterio.Items.Clear();
                    CboCriterio.Items.Add("Igual que");
                    CboCriterio.SelectedIndex = 0;
                }
                if (opcion == "Marcas")
                {
                    CboCriterio.DataSource = NegocioMarcas.ListarMarcas();
                    CboCriterio.ValueMember = "Id";
                    CboCriterio.DisplayMember = "Descripcion";
                    CboCriterio.SelectedIndex = -1;
                    TxtFiltro.Enabled = false;
                    TxtFiltro.Text = "";
                }
                if (opcion == "Categorías")
                {
                    CboCriterio.DataSource = NegocioCategorias.ListarCategorias();
                    CboCriterio.ValueMember = "Id";
                    CboCriterio.DisplayMember = "Descripcion";
                    CboCriterio.SelectedIndex = -1;
                    TxtFiltro.Enabled = false;
                    TxtFiltro.Text = "";
                }
            }                
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                
                // Validaciones
                string[] CamposAvalidar = {"Precio","Código" };                
                if (CboCampo.Text == "" && CboCriterio.Text == "")
                {
                    LblValidacionFiltro.Text = "Elija un campo y un criterio";
                    return;
                }
                else if (CboCriterio.Text == "")
                {
                    LblValidacionFiltro.Text = "Elija un criterio";
                    return;
                }
                bool ValicacionFiltro = CamposAvalidar.Any(campo => CboCampo.Text.Contains(campo)) && TxtFiltro.Text == "";
                if (ValicacionFiltro)
                {
                    LblValidacionFiltro.Text = "Debe tener un filtro esta búsqueda";
                    return;
                }
                if (CboCampo.Text == "Precio")
                {
                    string contFiltro = TxtFiltro.Text;
                    foreach (char c in contFiltro)
                    {
                        if (!char.IsDigit(c))
                        {
                            LblValidacionFiltro.Text = "Solo acepta numeros el campo filtro";
                            return; // Se encontró un carácter no numérico
                        }
                    }
                }
                if (DgvArticulos.Rows.Count == 0)
                    return;
                else                
                    LblValidacionFiltro.Text = "";
                
                               
                //Logica
                List<Articulo> listaFiltrada;
                DgvArticulos.DataSource = null;
                listaFiltrada = negocio.Filtrar(CboCampo.Text, CboCriterio.Text, TxtFiltro.Text);
                DgvArticulos.DataSource = listaFiltrada;
                OcultarColumnas();

                if (DgvArticulos.RowCount > 0)
                {
                    DgvArticulos.Rows[0].Selected = true;
                    DgvArticulos.CurrentCell = DgvArticulos.Rows[0].Cells[1];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void CboCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblValidacionFiltro.Text = "";
        }

        private void ExportarExcel(DataGridView dataGridView)
        {
            ExcelPackage excelPackage = new ExcelPackage();
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Lista de artículos");

            for (int filas = 1; filas <= dataGridView.Columns.Count; filas++)
            {
                worksheet.Cells[1, filas].Value = dataGridView.Columns[filas - 1].HeaderText;
            }

            for (int fila = 0; fila < dataGridView.Rows.Count; fila++)
            {
                for (int columna = 0; columna < dataGridView.Columns.Count; columna++)
                {
                    worksheet.Cells[fila + 2, columna + 1].Value = dataGridView.Rows[fila].Cells[columna].Value;
                }
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Archivo de Excel (*.xlsx)|*.xlsx";
            saveDialog.FileName = "Lista de Artículos.xlsx";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo archivoExcel = new FileInfo(saveDialog.FileName);
                excelPackage.SaveAs(archivoExcel);
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarExcel(DgvArticulos);
        }

        private void DgvArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (e.Value is double || e.Value is float || e.Value is decimal)
            {
                e.Value = Math.Truncate(Convert.ToDecimal(e.Value)).ToString();
                e.FormattingApplied = true;
            }
            
        }
    }
}
       