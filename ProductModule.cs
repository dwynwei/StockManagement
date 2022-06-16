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
    public partial class ProductModule : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StockManDB.mdf;Integrated Security=True;User Instance=False;Connect Timeout=30");
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        public ProductModule()
        {
            InitializeComponent();
        }

        private void ProductModule_Load(object sender, EventArgs e)
        {

        }

        public void LoadProduct() 
        {
            com = new SqlCommand("");
        }

        private void btn_productAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ürün Bilgilerini Kaydetmek İstediğine Emin misin?", "Hammadde Kaydı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    com = new SqlCommand("INSERT INTO tbProduct(stockcode,productname,countproduct,countminproduct,countaddproduct,ordercount,description)VALUES(@stockcode,@productname,@countproduct,@countminproduct,@countaddproduct,@ordercount,@description)", con);
                    com.Parameters.AddWithValue("@stockcode", stockCode_textBox.Text);
                    com.Parameters.AddWithValue("@productname", prodName_textBox.Text);
                    com.Parameters.AddWithValue("@countproduct", prodCount_numeric.Value);
                    com.Parameters.AddWithValue("@countminproduct", minProdCount_numeric.Value);
                    com.Parameters.AddWithValue("@countaddproduct", addProdCound_numeric.Value);
                    com.Parameters.AddWithValue("@ordercount", orderCount_numeric.Value);
                    com.Parameters.AddWithValue("@description", desc_textBox.Text);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Ürün Kaydı Eklendi.");
                    Clear();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        public void Clear()
        {
            stockCode_textBox.Clear();
            prodName_textBox.Clear();
            minProdCount_numeric.Value = 0;
            prodCount_numeric.Value = 0;
            addProdCound_numeric.Value= 0;
        }

        private void btn_productUpdate_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            try
            {
                int minusTotal = (Int32.Parse(prodCount_numeric.Value.ToString()) - Int32.Parse(orderCount_numeric.Value.ToString()));
                prodCount_numeric.Value = minusTotal;

                if (stockCode_textBox.Text.Equals("") || prodName_textBox.Text.Equals(""))
                {
                    MessageBox.Show("Bilgiler Boş Olamaz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Bu Ürünü Güncellemek İstediğine Emin misin?", "Ürün Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            com = new SqlCommand("UPDATE tbProduct SET stockcode=@stockcode, productname=@productname, countproduct=@countproduct, countminproduct=@countminproduct, countaddproduct=@countaddproduct, ordercount=@ordercount, description=@description WHERE stockcode=@stockcode", con);
                            com.Parameters.AddWithValue("@stockcode", stockCode_textBox.Text);
                            com.Parameters.AddWithValue("@productname", prodName_textBox.Text);
                            com.Parameters.AddWithValue("@countproduct", prodCount_numeric.Text);
                            com.Parameters.AddWithValue("@countminproduct", minProdCount_numeric.Text);
                            com.Parameters.AddWithValue("@countaddproduct", addProdCound_numeric.Text);
                            com.Parameters.AddWithValue("@ordercount", orderCount_numeric.Text);
                            com.Parameters.AddWithValue("@description", desc_textBox.Text);
                            con.Open();
                            com.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Ürün Bilgisi Güncellendi.");
                            this.Dispose();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                            con.Close();
                        }

                    }
                    productForm.LoadProduct();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void prodCount_numeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
