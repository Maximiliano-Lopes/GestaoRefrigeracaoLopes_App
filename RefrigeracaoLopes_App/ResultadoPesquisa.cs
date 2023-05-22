using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace RefrigeracaoLopes_App
{
    public partial class ResultadoPesquisa : Form
    {
        public ResultadoPesquisa(DataTable data)
        {
            InitializeComponent();
            dataGridResultadoPesquisa.DataSource = data;
        }

        private void ResultadoPesquisa_Load(object sender, EventArgs e)
        {

        }
        private void ConvertDataGridViewToPDF(DataGridView dataGridView, string filePath)
        {
           
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Arial", 10, XFontStyle.Regular);

            
            float totalWidth = dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);

            
            float rowHeight = dataGridView.Rows.GetRowsHeight(DataGridViewElementStates.Visible);

            
            float x = 10;
            float y = 10;

            
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                gfx.DrawString(column.HeaderText, font, XBrushes.Black, x, y);
                x += column.Width;
            }

            y += rowHeight;

            
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                x = 10;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    gfx.DrawString(cell.Value?.ToString(), font, XBrushes.Black, x, y);
                    x += dataGridView.Columns[cell.ColumnIndex].Width;
                }
                y += rowHeight;
            }

            
            document.Save(filePath);
            Process.Start(filePath);
        }
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            String dataHoje = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();

            ConvertDataGridViewToPDF(dataGridResultadoPesquisa, "RelatorioPagamentosPendentes_"+dataHoje+".pdf");
        }
    }
}
