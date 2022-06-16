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
    public partial class UserModule : Form
    {
        SqlConnection _connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StockManDB.mdf;Integrated Security=True;User Instance=False;Connect Timeout=30");
        SqlCommand com = new SqlCommand();
        public UserModule()
        {

            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if(userName_textBox.Text.Equals("") || name_textBox.Text.Equals("") || password_textBox.Text.Equals(""))
                {
                    MessageBox.Show("Bilgiler Boş Olamaz !","Hata",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Bu Kullanıcıyı Kaydetmek İstediğine Emin misin?", "Kullanıcı Kaydı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            com = new SqlCommand("INSERT INTO tbUser(username,password,fullname)VALUES(@username,@password,@fullname)", _connection);
                            com.Parameters.AddWithValue("@username", userName_textBox.Text);
                            com.Parameters.AddWithValue("@password", password_textBox.Text);
                            com.Parameters.AddWithValue("@fullname", name_textBox.Text);
                            _connection.Open();
                            com.ExecuteNonQuery();
                            _connection.Close();
                            MessageBox.Show("Kullanıcı Eklendi.");
                        }
                        catch(SqlException ex) 
                        {
                            MessageBox.Show(ex.Message);
                        }
                        
                    }
                }
                    

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserModule_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            userName_textBox.Clear();
            password_textBox.Clear();
            name_textBox.Clear();
        }

        private void btn_userUpdate_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            try
            {
                if (userName_textBox.Text.Equals("") || name_textBox.Text.Equals("") || password_textBox.Text.Equals(""))
                {
                    MessageBox.Show("Bilgiler Boş Olamaz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Bu Kullanıcıyı Güncellemek İstediğine Emin misin?", "Kullanıcı Kaydı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            
                            com = new SqlCommand("UPDATE tbUser SET username=@username, password=@password, fullname=@fullname WHERE username=@username", _connection);
                            com.Parameters.AddWithValue("@username", userName_textBox.Text);
                            com.Parameters.AddWithValue("@password", password_textBox.Text);
                            com.Parameters.AddWithValue("@fullname", name_textBox.Text);
                            _connection.Open();
                            com.ExecuteNonQuery();
                            _connection.Close();
                            MessageBox.Show("Kullanıcı Güncellendi.");
                            this.Dispose();
                            
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                            _connection.Close();
                        }

                    }
                    userForm.LoadUser();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
