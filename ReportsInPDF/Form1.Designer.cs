namespace ReportsInPDF
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupClientDetails = new System.Windows.Forms.GroupBox();
            this.Document = new System.Windows.Forms.Label();
            this.txtdocument = new System.Windows.Forms.TextBox();
            this.Names = new System.Windows.Forms.Label();
            this.txtnames = new System.Windows.Forms.TextBox();
            this.GroupProductDetails = new System.Windows.Forms.GroupBox();
            this.Description = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.dgvproducts = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFinishAndPrint = new System.Windows.Forms.Button();
            this.GroupClientDetails.SuspendLayout();
            this.GroupProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupClientDetails
            // 
            this.GroupClientDetails.Controls.Add(this.Document);
            this.GroupClientDetails.Controls.Add(this.txtdocument);
            this.GroupClientDetails.Controls.Add(this.Names);
            this.GroupClientDetails.Controls.Add(this.txtnames);
            this.GroupClientDetails.Location = new System.Drawing.Point(60, 21);
            this.GroupClientDetails.Name = "GroupClientDetails";
            this.GroupClientDetails.Size = new System.Drawing.Size(444, 59);
            this.GroupClientDetails.TabIndex = 0;
            this.GroupClientDetails.TabStop = false;
            this.GroupClientDetails.Text = "Client Details";
            // 
            // Document
            // 
            this.Document.AutoSize = true;
            this.Document.Location = new System.Drawing.Point(30, 22);
            this.Document.Name = "Document";
            this.Document.Size = new System.Drawing.Size(76, 13);
            this.Document.TabIndex = 0;
            this.Document.Text = "Document No:";
            // 
            // txtdocument
            // 
            this.txtdocument.Location = new System.Drawing.Point(112, 19);
            this.txtdocument.Name = "txtdocument";
            this.txtdocument.Size = new System.Drawing.Size(110, 20);
            this.txtdocument.TabIndex = 1;
            // 
            // Names
            // 
            this.Names.AutoSize = true;
            this.Names.Location = new System.Drawing.Point(244, 22);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(43, 13);
            this.Names.TabIndex = 0;
            this.Names.Text = "Names:";
            // 
            // txtnames
            // 
            this.txtnames.Location = new System.Drawing.Point(293, 19);
            this.txtnames.Name = "txtnames";
            this.txtnames.Size = new System.Drawing.Size(136, 20);
            this.txtnames.TabIndex = 1;
            // 
            // GroupProductDetails
            // 
            this.GroupProductDetails.Controls.Add(this.Description);
            this.GroupProductDetails.Controls.Add(this.txtDescription);
            this.GroupProductDetails.Controls.Add(this.Price);
            this.GroupProductDetails.Controls.Add(this.txtPrice);
            this.GroupProductDetails.Controls.Add(this.Quantity);
            this.GroupProductDetails.Controls.Add(this.txtQuantity);
            this.GroupProductDetails.Location = new System.Drawing.Point(60, 86);
            this.GroupProductDetails.Name = "GroupProductDetails";
            this.GroupProductDetails.Size = new System.Drawing.Size(444, 74);
            this.GroupProductDetails.TabIndex = 0;
            this.GroupProductDetails.TabStop = false;
            this.GroupProductDetails.Text = "Product Details";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(6, 26);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(63, 13);
            this.Description.TabIndex = 0;
            this.Description.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(75, 23);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(107, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(188, 27);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(34, 13);
            this.Price.TabIndex = 0;
            this.Price.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(225, 24);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(62, 20);
            this.txtPrice.TabIndex = 1;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(306, 27);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(49, 13);
            this.Quantity.TabIndex = 0;
            this.Quantity.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(361, 23);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(68, 20);
            this.txtQuantity.TabIndex = 1;
            // 
            // dgvproducts
            // 
            this.dgvproducts.AllowUserToAddRows = false;
            this.dgvproducts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvproducts.ColumnHeadersHeight = 30;
            this.dgvproducts.EnableHeadersVisualStyles = false;
            this.dgvproducts.Location = new System.Drawing.Point(61, 247);
            this.dgvproducts.MultiSelect = false;
            this.dgvproducts.Name = "dgvproducts";
            this.dgvproducts.ReadOnly = true;
            this.dgvproducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvproducts.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvproducts.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvproducts.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvproducts.RowTemplate.Height = 30;
            this.dgvproducts.Size = new System.Drawing.Size(443, 161);
            this.dgvproducts.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(399, 189);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFinishAndPrint
            // 
            this.btnFinishAndPrint.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnFinishAndPrint.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFinishAndPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishAndPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinishAndPrint.Location = new System.Drawing.Point(386, 423);
            this.btnFinishAndPrint.Name = "btnFinishAndPrint";
            this.btnFinishAndPrint.Size = new System.Drawing.Size(117, 29);
            this.btnFinishAndPrint.TabIndex = 3;
            this.btnFinishAndPrint.Text = "Finish And Print";
            this.btnFinishAndPrint.UseVisualStyleBackColor = false;
            this.btnFinishAndPrint.Click += new System.EventHandler(this.btnFinishAndPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 469);
            this.Controls.Add(this.btnFinishAndPrint);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvproducts);
            this.Controls.Add(this.GroupClientDetails);
            this.Controls.Add(this.GroupProductDetails);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupClientDetails.ResumeLayout(false);
            this.GroupClientDetails.PerformLayout();
            this.GroupProductDetails.ResumeLayout(false);
            this.GroupProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupClientDetails;
        private System.Windows.Forms.Label Document;
        private System.Windows.Forms.TextBox txtdocument;
        private System.Windows.Forms.Label Names;
        private System.Windows.Forms.TextBox txtnames;
        private System.Windows.Forms.GroupBox GroupProductDetails;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DataGridView dgvproducts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFinishAndPrint;
    }
}

