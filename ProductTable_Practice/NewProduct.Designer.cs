namespace ProductTable_Practice
{
    partial class NewProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtQPU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbT = new System.Windows.Forms.RadioButton();
            this.rdbF = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.nmUP = new System.Windows.Forms.NumericUpDown();
            this.nmUIS = new System.Windows.Forms.NumericUpDown();
            this.nmUIO = new System.Windows.Forms.NumericUpDown();
            this.nmReorderLevel = new System.Windows.Forms.NumericUpDown();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUIS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUIO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmReorderLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier";
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Location = new System.Drawing.Point(145, 323);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(75, 23);
            this.btnNewProduct.TabIndex = 3;
            this.btnNewProduct.Text = "Add";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(145, 82);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 4;
            // 
            // txtQPU
            // 
            this.txtQPU.Location = new System.Drawing.Point(145, 114);
            this.txtQPU.Name = "txtQPU";
            this.txtQPU.Size = new System.Drawing.Size(100, 20);
            this.txtQPU.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantity Per unit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Unit Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Units In Stock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Units On Order";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Reorder Level";
            // 
            // rdbT
            // 
            this.rdbT.AutoSize = true;
            this.rdbT.Location = new System.Drawing.Point(145, 296);
            this.rdbT.Name = "rdbT";
            this.rdbT.Size = new System.Drawing.Size(47, 17);
            this.rdbT.TabIndex = 5;
            this.rdbT.TabStop = true;
            this.rdbT.Text = "True";
            this.rdbT.UseVisualStyleBackColor = true;
            this.rdbT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdbF_MouseClick);
            // 
            // rdbF
            // 
            this.rdbF.AutoSize = true;
            this.rdbF.Location = new System.Drawing.Point(195, 296);
            this.rdbF.Name = "rdbF";
            this.rdbF.Size = new System.Drawing.Size(50, 17);
            this.rdbF.TabIndex = 5;
            this.rdbF.TabStop = true;
            this.rdbF.Text = "False";
            this.rdbF.UseVisualStyleBackColor = true;
            this.rdbF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdbF_MouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Discontinued";
            // 
            // nmUP
            // 
            this.nmUP.DecimalPlaces = 2;
            this.nmUP.Location = new System.Drawing.Point(145, 154);
            this.nmUP.Name = "nmUP";
            this.nmUP.Size = new System.Drawing.Size(100, 20);
            this.nmUP.TabIndex = 7;
            // 
            // nmUIS
            // 
            this.nmUIS.Location = new System.Drawing.Point(145, 190);
            this.nmUIS.Name = "nmUIS";
            this.nmUIS.Size = new System.Drawing.Size(100, 20);
            this.nmUIS.TabIndex = 7;
            // 
            // nmUIO
            // 
            this.nmUIO.Location = new System.Drawing.Point(145, 225);
            this.nmUIO.Name = "nmUIO";
            this.nmUIO.Size = new System.Drawing.Size(100, 20);
            this.nmUIO.TabIndex = 7;
            // 
            // nmReorderLevel
            // 
            this.nmReorderLevel.Location = new System.Drawing.Point(145, 263);
            this.nmReorderLevel.Name = "nmReorderLevel";
            this.nmReorderLevel.Size = new System.Drawing.Size(100, 20);
            this.nmReorderLevel.TabIndex = 7;
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(146, 47);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(121, 21);
            this.cmbCategories.TabIndex = 8;
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(146, 17);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(121, 21);
            this.cmbSuppliers.TabIndex = 8;
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(292, 358);
            this.Controls.Add(this.cmbSuppliers);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.nmReorderLevel);
            this.Controls.Add(this.nmUIO);
            this.Controls.Add(this.nmUIS);
            this.Controls.Add(this.nmUP);
            this.Controls.Add(this.rdbF);
            this.Controls.Add(this.rdbT);
            this.Controls.Add(this.txtQPU);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.btnNewProduct);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "NewProduct";
            this.Text = "Product Page";
            this.Load += new System.EventHandler(this.NewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUIS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUIO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmReorderLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtQPU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbT;
        private System.Windows.Forms.RadioButton rdbF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmUP;
        private System.Windows.Forms.NumericUpDown nmUIS;
        private System.Windows.Forms.NumericUpDown nmUIO;
        private System.Windows.Forms.NumericUpDown nmReorderLevel;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.ComboBox cmbSuppliers;
    }
}