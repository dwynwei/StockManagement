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
    public partial class UserForm : Form
    {
        SqlConnection _connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StockManDB.mdf;Integrated Security=True;User Instance=False;Connect Timeout=30");
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        public UserForm()
        {
            
            InitializeComponent();
            LoadUser();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_user.Columns[e.ColumnIndex].Name;
            if(colName == "Column4") 
            {
                UserModule userModule = new UserModule();
                userModule.name_textBox.Text = dgv_user.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModule.password_textBox.Text = dgv_user.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.userName_textBox.Text = dgv_user.Rows[e.RowIndex].Cells[2].Value.ToString();

                userModule.btn_Add.Enabled = false;
                userModule.btn_userUpdate.Enabled = true;
                userModule.ShowDialog();
            }else if(colName == "Column5") 
            {
                if(MessageBox.Show("Bu Kullanıcıyı Silmek İstediğine Emin misin?","Kayıt Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) 
                {
                    _connection.Open();
                    com = new SqlCommand("DELETE FROM tbUser WHERE username LIKE '"+dgv_user.Rows[e.RowIndex].Cells[2].Value.ToString()+"'",_connection);
                    com.ExecuteNonQuery();
                    _connection.Close();
                    MessageBox.Show("Kullanıcı Silindi !");
                }
            }
            LoadUser();
        }

        public void LoadUser()
        {
            int i = 0;
            dgv_user.Rows.Clear();
            _connection.Open();
            com = new SqlCommand("SELECT * FROM tbUser",_connection);            
            dr = com.ExecuteReader();
            while (dr.Read()) 
            {
                i++;
                dgv_user.Rows.Add(i,dr[2].ToString(), dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            _connection.Close();
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            UserModule userModule = new UserModule();
            userModule.btn_Add.Enabled = true;
            userModule.btn_userUpdate.Enabled = false;
            userModule.ShowDialog();
            LoadUser();
        }
    }
}
