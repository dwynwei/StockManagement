namespace Stock_Management
{
    partial class ProductModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductModule));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clearForm = new System.Windows.Forms.Button();
            this.btn_productUpdate = new System.Windows.Forms.Button();
            this.btn_productAdd = new System.Windows.Forms.Button();
            this.prodName_textBox = new System.Windows.Forms.TextBox();
            this.stockCode_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.minProdCount_numeric = new System.Windows.Forms.NumericUpDown();
            this.addProdCound_numeric = new System.Windows.Forms.NumericUpDown();
            this.prodCount_numeric = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.orderCount_numeric = new System.Windows.Forms.NumericUpDown();
            this.desc_textBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minProdCount_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProdCound_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodCount_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderCount_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 2);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(926, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Modülü";
            // 
            // btn_clearForm
            // 
            this.btn_clearForm.BackColor = System.Drawing.Color.Chocolate;
            this.btn_clearForm.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearForm.ForeColor = System.Drawing.Color.White;
            this.btn_clearForm.Location = new System.Drawing.Point(815, 308);
            this.btn_clearForm.Name = "btn_clearForm";
            this.btn_clearForm.Size = new System.Drawing.Size(116, 45);
            this.btn_clearForm.TabIndex = 25;
            this.btn_clearForm.Text = "Form İçeriğini Temizle";
            this.btn_clearForm.UseVisualStyleBackColor = false;
            // 
            // btn_productUpdate
            // 
            this.btn_productUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_productUpdate.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productUpdate.ForeColor = System.Drawing.Color.White;
            this.btn_productUpdate.Location = new System.Drawing.Point(815, 226);
            this.btn_productUpdate.Name = "btn_productUpdate";
            this.btn_productUpdate.Size = new System.Drawing.Size(116, 45);
            this.btn_productUpdate.TabIndex = 24;
            this.btn_productUpdate.Text = "Güncelle";
            this.btn_productUpdate.UseVisualStyleBackColor = false;
            this.btn_productUpdate.Click += new System.EventHandler(this.btn_productUpdate_Click);
            // 
            // btn_productAdd
            // 
            this.btn_productAdd.BackColor = System.Drawing.Color.LightCoral;
            this.btn_productAdd.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productAdd.ForeColor = System.Drawing.Color.White;
            this.btn_productAdd.Location = new System.Drawing.Point(815, 144);
            this.btn_productAdd.Name = "btn_productAdd";
            this.btn_productAdd.Size = new System.Drawing.Size(116, 45);
            this.btn_productAdd.TabIndex = 23;
            this.btn_productAdd.Text = "Ekle";
            this.btn_productAdd.UseVisualStyleBackColor = false;
            this.btn_productAdd.Click += new System.EventHandler(this.btn_productAdd_Click);
            // 
            // prodName_textBox
            // 
            this.prodName_textBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodName_textBox.Location = new System.Drawing.Point(321, 165);
            this.prodName_textBox.Name = "prodName_textBox";
            this.prodName_textBox.Size = new System.Drawing.Size(425, 22);
            this.prodName_textBox.TabIndex = 21;
            // 
            // stockCode_textBox
            // 
            this.stockCode_textBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockCode_textBox.Location = new System.Drawing.Point(321, 119);
            this.stockCode_textBox.Name = "stockCode_textBox";
            this.stockCode_textBox.Size = new System.Drawing.Size(425, 22);
            this.stockCode_textBox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(246, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(246, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ürün Miktarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Malzeme Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ürün Stok Kodu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(246, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 23);
            this.label8.TabIndex = 27;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 23);
            this.label9.TabIndex = 26;
            this.label9.Text = "Ürün Eşik Miktarı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(246, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 23);
            this.label10.TabIndex = 29;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(49, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 23);
            this.label11.TabIndex = 28;
            this.label11.Text = "Ürün Ekleme Miktarı";
            // 
            // minProdCount_numeric
            // 
            this.minProdCount_numeric.Location = new System.Drawing.Point(321, 256);
            this.minProdCount_numeric.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.minProdCount_numeric.Name = "minProdCount_numeric";
            this.minProdCount_numeric.Size = new System.Drawing.Size(425, 23);
            this.minProdCount_numeric.TabIndex = 32;
            // 
            // addProdCound_numeric
            // 
            this.addProdCound_numeric.Location = new System.Drawing.Point(321, 298);
            this.addProdCound_numeric.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.addProdCound_numeric.Name = "addProdCound_numeric";
            this.addProdCound_numeric.Size = new System.Drawing.Size(425, 23);
            this.addProdCound_numeric.TabIndex = 33;
            // 
            // prodCount_numeric
            // 
            this.prodCount_numeric.Location = new System.Drawing.Point(321, 214);
            this.prodCount_numeric.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.prodCount_numeric.Name = "prodCount_numeric";
            this.prodCount_numeric.Size = new System.Drawing.Size(425, 23);
            this.prodCount_numeric.TabIndex = 35;
            this.prodCount_numeric.ValueChanged += new System.EventHandler(this.prodCount_numeric_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(247, 337);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 23);
            this.label12.TabIndex = 37;
            this.label12.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(50, 341);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 23);
            this.label13.TabIndex = 36;
            this.label13.Text = "İş Emri Ürün Miktarı";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(247, 383);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 23);
            this.label14.TabIndex = 39;
            this.label14.Text = ":";
            // 
            // orderCount_numeric
            // 
            this.orderCount_numeric.Location = new System.Drawing.Point(321, 341);
            this.orderCount_numeric.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.orderCount_numeric.Name = "orderCount_numeric";
            this.orderCount_numeric.Size = new System.Drawing.Size(425, 23);
            this.orderCount_numeric.TabIndex = 40;
            // 
            // desc_textBox
            // 
            this.desc_textBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_textBox.Location = new System.Drawing.Point(321, 387);
            this.desc_textBox.Name = "desc_textBox";
            this.desc_textBox.Size = new System.Drawing.Size(425, 22);
            this.desc_textBox.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(50, 383);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 23);
            this.label15.TabIndex = 42;
            this.label15.Text = "Açıklama";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(926, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 31);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(16, 22);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 29);
            this.label16.TabIndex = 1;
            this.label16.Text = "Ürün Modülü";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 82);
            this.panel2.TabIndex = 43;
            // 
            // ProductModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.desc_textBox);
            this.Controls.Add(this.orderCount_numeric);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.prodCount_numeric);
            this.Controls.Add(this.addProdCound_numeric);
            this.Controls.Add(this.minProdCount_numeric);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_clearForm);
            this.Controls.Add(this.btn_productUpdate);
            this.Controls.Add(this.btn_productAdd);
            this.Controls.Add(this.prodName_textBox);
            this.Controls.Add(this.stockCode_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "ProductModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductModule";
            this.Load += new System.EventHandler(this.ProductModule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minProdCount_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProdCound_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodCount_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderCount_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_clearForm;
        public System.Windows.Forms.Button btn_productUpdate;
        public System.Windows.Forms.Button btn_productAdd;
        public System.Windows.Forms.TextBox prodName_textBox;
        public System.Windows.Forms.TextBox stockCode_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.NumericUpDown minProdCount_numeric;
        public System.Windows.Forms.NumericUpDown addProdCound_numeric;
        public System.Windows.Forms.NumericUpDown prodCount_numeric;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.NumericUpDown orderCount_numeric;
        public System.Windows.Forms.TextBox desc_textBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel2;
    }
}