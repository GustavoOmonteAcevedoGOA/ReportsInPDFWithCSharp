using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace ReportsInPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int rowIndex= dgvproducts.Rows.Add();
            DataGridViewRow row = dgvproducts.Rows[rowIndex];

            row.Cells["Quantity"].Value = txtQuantity.Text;
            row.Cells["Description"].Value = txtDescription.Text;
            row.Cells["UnitPrice"].Value = txtPrice.Text.Replace('.', ',');
            row.Cells["Amount"].Value = decimal.Parse(txtQuantity.Text) * decimal.Parse(txtPrice.Text.Replace('.', ','));

            txtDescription.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvproducts.Columns.Add("Quantity", "Quantity");
            dgvproducts.Columns.Add("Description", "Description");
            dgvproducts.Columns.Add("UnitPrice", "Unit Price");
            dgvproducts.Columns.Add("Amount", "Amount");
        }

        private void btnFinishAndPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";

            string pageHTML_text = Properties.Resources.template.ToString();

            pageHTML_text =pageHTML_text.Replace("@CLIENT",txtnames.Text);
            pageHTML_text =pageHTML_text.Replace("@DOCUMENT",txtdocument.Text);
            pageHTML_text =pageHTML_text.Replace("@DATE", DateTime.Now.ToString("dd/MM/yyyy"));
            
            string rows = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in dgvproducts.Rows)
            {
                rows += "<tr>";
                rows += "<td>" + row.Cells["Quantity"].Value.ToString() + "</td>";
                rows += "<td>" + row.Cells["Description"].Value.ToString() + "</td>";
                rows += "<td>" + row.Cells["UnitPrice"].Value.ToString() + "</td>";
                rows += "<td>" + row.Cells["Amount"].Value.ToString() + "</td>";
                rows += "</tr>";
                total += decimal.Parse(row.Cells["Amount"].Value.ToString());

            }


            pageHTML_text =pageHTML_text.Replace("@ROWS", rows);
            pageHTML_text =pageHTML_text.Replace("@TOTAL", total.ToString());

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create)) 
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();

                    pdfDoc.Add(new Phrase(""));

                    using (StringReader sr = new StringReader(pageHTML_text))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();

                }



            }

        }
    }
}
