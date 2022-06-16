namespace Stock_Management
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_addProd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Prod = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.howmuch_add_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Prod)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btn_addProd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 489);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 43);
            this.panel1.TabIndex = 2;
            // 
            // btn_addProd
            // 
            this.btn_addProd.BackColor = System.Drawing.Color.Red;
            this.btn_addProd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_addProd.Location = new System.Drawing.Point(1105, 7);
            this.btn_addProd.Name = "btn_addProd";
            this.btn_addProd.Size = new System.Drawing.Size(75, 29);
            this.btn_addProd.TabIndex = 1;
            this.btn_addProd.Text = "Ekle";
            this.btn_addProd.UseVisualStyleBackColor = false;
            this.btn_addProd.Click += new System.EventHandler(this.btn_addProd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hammaddeleri Yönet";
            // 
            // dgv_Prod
            // 
            this.dgv_Prod.AllowUserToAddRows = false;
            this.dgv_Prod.AllowUserToDeleteRows = false;
            this.dgv_Prod.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Prod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Prod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.Column6,
            this.Column2,
            this.Column1,
            this.Column3,
            this.howmuch_add_prod,
            this.OrderCount,
            this.Description,
            this.Column4,
            this.Column5});
            this.dgv_Prod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Prod.EnableHeadersVisualStyles = false;
            this.dgv_Prod.Location = new System.Drawing.Point(0, 0);
            this.dgv_Prod.Name = "dgv_Prod";
            this.dgv_Prod.ReadOnly = true;
            this.dgv_Prod.Size = new System.Drawing.Size(1192, 489);
            this.dgv_Prod.TabIndex = 3;
            this.dgv_Prod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Prod_CellContentClick);
            // 
            // idCol
            // 
            this.idCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idCol.HeaderText = "ID";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Width = 39;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Ürün Stok Kodu";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Malzeme Adı";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Ürün Miktarı";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 81;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Ürün Eşik Miktarı";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 99;
            // 
            // howmuch_add_prod
            // 
            this.howmuch_add_prod.HeaderText = "Ürün Ekleme Miktarı";
            this.howmuch_add_prod.Name = "howmuch_add_prod";
            this.howmuch_add_prod.ReadOnly = true;
            // 
            // OrderCount
            // 
            this.OrderCount.HeaderText = "İş Emri Ürün Miktarı";
            this.OrderCount.Name = "OrderCount";
            this.OrderCount.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Açıklama";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "";
            this.Column4.Image = ((System.Drawing.Image)(resources.GetObject("Column4.Image")));
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 5;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "";
            this.Column5.Image = ((System.Drawing.Image)(resources.GetObject("Column5.Image")));
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 5;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 532);
            this.Controls.Add(this.dgv_Prod);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Prod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_addProd;
        public System.Windows.Forms.DataGridView dgv_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn howmuch_add_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
    }
}