namespace Stock_Management
{
    partial class UserModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserModule));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.userName_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_userUpdate = new System.Windows.Forms.Button();
            this.btn_userDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(730, 67);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(697, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
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
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Modülü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı İsmi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(203, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(203, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(203, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = ":";
            // 
            // userName_textBox
            // 
            this.userName_textBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_textBox.Location = new System.Drawing.Point(242, 169);
            this.userName_textBox.Name = "userName_textBox";
            this.userName_textBox.Size = new System.Drawing.Size(425, 27);
            this.userName_textBox.TabIndex = 7;
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textBox.Location = new System.Drawing.Point(242, 215);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(425, 27);
            this.name_textBox.TabIndex = 8;
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textBox.Location = new System.Drawing.Point(242, 262);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(425, 27);
            this.password_textBox.TabIndex = 9;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Add.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(242, 319);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(116, 45);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_userUpdate
            // 
            this.btn_userUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_userUpdate.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_userUpdate.ForeColor = System.Drawing.Color.White;
            this.btn_userUpdate.Location = new System.Drawing.Point(397, 319);
            this.btn_userUpdate.Name = "btn_userUpdate";
            this.btn_userUpdate.Size = new System.Drawing.Size(116, 45);
            this.btn_userUpdate.TabIndex = 11;
            this.btn_userUpdate.Text = "Güncelle";
            this.btn_userUpdate.UseVisualStyleBackColor = false;
            this.btn_userUpdate.Click += new System.EventHandler(this.btn_userUpdate_Click);
            // 
            // btn_userDelete
            // 
            this.btn_userDelete.BackColor = System.Drawing.Color.Chocolate;
            this.btn_userDelete.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_userDelete.ForeColor = System.Drawing.Color.White;
            this.btn_userDelete.Location = new System.Drawing.Point(551, 319);
            this.btn_userDelete.Name = "btn_userDelete";
            this.btn_userDelete.Size = new System.Drawing.Size(116, 45);
            this.btn_userDelete.TabIndex = 12;
            this.btn_userDelete.Text = "Form İçeriğini Temizle";
            this.btn_userDelete.UseVisualStyleBackColor = false;
            this.btn_userDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 419);
            this.Controls.Add(this.btn_userDelete);
            this.Controls.Add(this.btn_userUpdate);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.userName_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserModule";
            this.Load += new System.EventHandler(this.UserModule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btn_Add;
        public System.Windows.Forms.Button btn_userUpdate;
        public System.Windows.Forms.Button btn_userDelete;
        public System.Windows.Forms.TextBox userName_textBox;
        public System.Windows.Forms.TextBox name_textBox;
        public System.Windows.Forms.TextBox password_textBox;
    }
}