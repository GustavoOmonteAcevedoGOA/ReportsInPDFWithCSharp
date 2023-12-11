using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
