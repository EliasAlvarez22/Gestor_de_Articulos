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
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

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
                ListaArticulos = negocio.ListarArticulos();

                DgvArticulos.DataSource = ListaArticulos;

                OcultarColumnas();
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
            seleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
            frmNuevoArticulo Modificar = new frmNuevoArticulo(seleccionado);
            Modificar.ShowDialog();
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            ListaArticulos = negocio.ListarArticulos();

            DgvArticulos.DataSource = ListaArticulos;

            OcultarColumnas();
        }


        //Exportar PDF con iTextSharp, se oculta la url de Imagen en la exportacion

        private void BtnExportarPDF_Click(object sender, EventArgs e)
        {
            try
            {
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
                    pdfDocument.Add(new Paragraph("Lista de Articulos"));
                    pdfDocument.Add(new Paragraph(Chunk.NEWLINE));

                    PdfPTable pdfTable = new PdfPTable(DgvArticulos.ColumnCount - columnasOcultar.Length); // Menos 2 columnas que deseas ocultar
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

            Articulo seleccionado = DgvArticulos.CurrentRow.DataBoundItem as Articulo;
            DialogResult resultado = MessageBox.Show("Seguro que desea eliminar?", "Eliminar Pokemon", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                negocio.EliminarArticulo(seleccionado.Id);
                MessageBox.Show("Artículo eliminado correctamente");
            }
        }
    }
}
       