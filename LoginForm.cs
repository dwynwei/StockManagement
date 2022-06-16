using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stock_Management
{
    public partial class LoginForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StockManDB.mdf;Integrated Security=True;User Instance=False;Connect Timeout=30");
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPw.Checked == false) 
            {
                textBox_PW.UseSystemPasswordChar = true;
            }
            else
            {
                textBox_PW.UseSystemPasswordChar = false;
            }
        }

        private void lbl_clear_Click(object sender, EventArgs e)
        {
            textBox_PW.Clear();
            textBox_UN.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Çıkış Yapılsın mı?", "ÇIKIŞ",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes) 
            {
                Application.Exit();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                com = new SqlCommand("SELECT * FROM tbUser WHERE username=@username AND password=@password", con);
                com.Parameters.AddWithValue("@username",textBox_UN.Text);
                com.Parameters.AddWithValue("@password", textBox_PW.Text);
                con.Open();
                dr = com.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("Hoşgeldin " + dr["fullname"].ToString() + ". Başarılı Bir Şekilde Giriş Yaptınız !","GİRİŞ BAŞARILI !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm main = new MainForm();
                    this.Hide();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Geçersiz Kullanıcı Adı Veya Şifre Girildi !", "GİRİŞ BAŞARISIZ !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
