
namespace DBAssignment5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpInvoices = new System.Windows.Forms.GroupBox();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.txtProductTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalesTax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtShippingTotal = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtInvoiceDate = new System.Windows.Forms.TextBox();
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtInvoiceTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInvoices
            // 
            this.grpInvoices.Controls.Add(this.dgvInvoices);
            this.grpInvoices.Location = new System.Drawing.Point(23, 321);
            this.grpInvoices.Name = "grpInvoices";
            this.grpInvoices.Size = new System.Drawing.Size(658, 307);
            this.grpInvoices.TabIndex = 55;
            this.grpInvoices.TabStop = false;
            this.grpInvoices.Text = "Invoices";
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Location = new System.Drawing.Point(24, 39);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.RowHeadersWidth = 62;
            this.dgvInvoices.RowTemplate.Height = 33;
            this.dgvInvoices.Size = new System.Drawing.Size(614, 251);
            this.dgvInvoices.TabIndex = 0;
            // 
            // txtProductTotal
            // 
            this.txtProductTotal.Location = new System.Drawing.Point(190, 197);
            this.txtProductTotal.Name = "txtProductTotal";
            this.txtProductTotal.ReadOnly = true;
            this.txtProductTotal.Size = new System.Drawing.Size(150, 31);
            this.txtProductTotal.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 53;
            this.label7.Text = "Product Total:";
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.Location = new System.Drawing.Point(190, 258);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.ReadOnly = true;
            this.txtSalesTax.Size = new System.Drawing.Size(150, 31);
            this.txtSalesTax.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 51;
            this.label6.Text = "Sales Tax:";
            // 
            // txtShippingTotal
            // 
            this.txtShippingTotal.Location = new System.Drawing.Point(532, 197);
            this.txtShippingTotal.Name = "txtShippingTotal";
            this.txtShippingTotal.ReadOnly = true;
            this.txtShippingTotal.Size = new System.Drawing.Size(150, 31);
            this.txtShippingTotal.TabIndex = 48;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(190, 134);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(491, 31);
            this.txtName.TabIndex = 47;
            // 
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.Location = new System.Drawing.Point(190, 75);
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.ReadOnly = true;
            this.txtInvoiceDate.Size = new System.Drawing.Size(491, 31);
            this.txtInvoiceDate.TabIndex = 46;
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Location = new System.Drawing.Point(190, 18);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.Size = new System.Drawing.Size(124, 31);
            this.txtInvoiceID.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Shipping Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "Invoice Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Customer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Invoice ID:";
            // 
            // btnInvoice
            // 
            this.btnInvoice.Location = new System.Drawing.Point(337, 16);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(130, 34);
            this.btnInvoice.TabIndex = 39;
            this.btnInvoice.Text = "&Get Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnGetCustomer_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(23, 650);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(159, 34);
            this.btnClear.TabIndex = 58;
            this.btnClear.Text = "&Clear Invoice";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(569, 650);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 57;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // txtInvoiceTotal
            // 
            this.txtInvoiceTotal.Location = new System.Drawing.Point(531, 258);
            this.txtInvoiceTotal.Name = "txtInvoiceTotal";
            this.txtInvoiceTotal.ReadOnly = true;
            this.txtInvoiceTotal.Size = new System.Drawing.Size(150, 31);
            this.txtInvoiceTotal.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 60;
            this.label5.Text = "Invoice Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 708);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInvoiceTotal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpInvoices);
            this.Controls.Add(this.txtProductTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSalesTax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtShippingTotal);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtInvoiceDate);
            this.Controls.Add(this.txtInvoiceID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInvoice);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.grpInvoices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInvoices;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.TextBox txtProductTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtShippingTotal;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtInvoiceDate;
        private System.Windows.Forms.TextBox txtInvoiceID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtInvoiceTotal;
        private System.Windows.Forms.Label label5;
    }
}

