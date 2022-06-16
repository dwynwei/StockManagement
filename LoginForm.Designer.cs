namespace Stock_Management
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_UN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_PW = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.checkBox_ShowPw = new System.Windows.Forms.CheckBox();
            this.lbl_clear = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 106);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(395, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(41, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "HAMMADDE KONTROL GİRİŞ PANELİ";
            // 
            // textBox_UN
            // 
            this.textBox_UN.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UN.Location = new System.Drawing.Point(138, 232);
            this.textBox_UN.Name = "textBox_UN";
            this.textBox_UN.Size = new System.Drawing.Size(232, 27);
            this.textBox_UN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // textBox_PW
            // 
            this.textBox_PW.Location = new System.Drawing.Point(138, 285);
            this.textBox_PW.Name = "textBox_PW";
            this.textBox_PW.Size = new System.Drawing.Size(232, 30);
            this.textBox_PW.TabIndex = 3;
            this.textBox_PW.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_login.Location = new System.Drawing.Point(136, 352);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(234, 46);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // checkBox_ShowPw
            // 
            this.checkBox_ShowPw.AutoSize = true;
            this.checkBox_ShowPw.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_ShowPw.Location = new System.Drawing.Point(256, 462);
            this.checkBox_ShowPw.Name = "checkBox_ShowPw";
            this.checkBox_ShowPw.Size = new System.Drawing.Size(114, 23);
            this.checkBox_ShowPw.TabIndex = 6;
            this.checkBox_ShowPw.Text = "Şifreyi Göster";
            this.checkBox_ShowPw.UseVisualStyleBackColor = true;
            this.checkBox_ShowPw.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbl_clear
            // 
            this.lbl_clear.AutoSize = true;
            this.lbl_clear.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clear.ForeColor = System.Drawing.Color.Red;
            this.lbl_clear.Location = new System.Drawing.Point(41, 462);
            this.lbl_clear.Name = "lbl_clear";
            this.lbl_clear.Size = new System.Drawing.Size(75, 25);
            this.lbl_clear.TabIndex = 7;
            this.lbl_clear.Text = "Temizle";
            this.lbl_clear.Click += new System.EventHandler(this.lbl_clear_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 563);
            this.Controls.Add(this.lbl_clear);
            this.Controls.Add(this.checkBox_ShowPw);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_PW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_UN);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_UN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_PW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.CheckBox checkBox_ShowPw;
        private System.Windows.Forms.Label lbl_clear;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

