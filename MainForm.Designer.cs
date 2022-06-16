namespace Stock_Management
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_creds = new System.Windows.Forms.Button();
            this.btn_product = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.prod_data_control_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.prod_data_control_btn);
            this.panel1.Controls.Add(this.btn_creds);
            this.panel1.Controls.Add(this.btn_product);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1589, 98);
            this.panel1.TabIndex = 0;
            // 
            // btn_creds
            // 
            this.btn_creds.BackColor = System.Drawing.Color.Black;
            this.btn_creds.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_creds.ForeColor = System.Drawing.Color.Transparent;
            this.btn_creds.Location = new System.Drawing.Point(1429, 20);
            this.btn_creds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_creds.Name = "btn_creds";
            this.btn_creds.Size = new System.Drawing.Size(144, 64);
            this.btn_creds.TabIndex = 2;
            this.btn_creds.Text = "Kullanıcılar";
            this.btn_creds.UseVisualStyleBackColor = false;
            this.btn_creds.Click += new System.EventHandler(this.btn_creds_Click);
            // 
            // btn_product
            // 
            this.btn_product.BackColor = System.Drawing.Color.Black;
            this.btn_product.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product.ForeColor = System.Drawing.Color.Transparent;
            this.btn_product.Location = new System.Drawing.Point(1256, 20);
            this.btn_product.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(144, 64);
            this.btn_product.TabIndex = 1;
            this.btn_product.Text = "Ürünler";
            this.btn_product.UseVisualStyleBackColor = false;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Takip Sistemi";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 753);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1589, 27);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 98);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1589, 655);
            this.panel3.TabIndex = 2;
            // 
            // prod_data_control_btn
            // 
            this.prod_data_control_btn.BackColor = System.Drawing.Color.Black;
            this.prod_data_control_btn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_data_control_btn.ForeColor = System.Drawing.Color.Transparent;
            this.prod_data_control_btn.Location = new System.Drawing.Point(1078, 20);
            this.prod_data_control_btn.Margin = new System.Windows.Forms.Padding(4);
            this.prod_data_control_btn.Name = "prod_data_control_btn";
            this.prod_data_control_btn.Size = new System.Drawing.Size(144, 64);
            this.prod_data_control_btn.TabIndex = 3;
            this.prod_data_control_btn.Text = "Ürün Veri Kontrolü";
            this.prod_data_control_btn.UseVisualStyleBackColor = false;
            this.prod_data_control_btn.Click += new System.EventHandler(this.prod_data_control_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 780);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_creds;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button prod_data_control_btn;
    }
}