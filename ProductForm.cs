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
    public partial class ProductForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StockManDB.mdf;Integrated Security=True;User Instance=False;Connect Timeout=30");
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        private readonly int addingVal = 10;
        public ProductForm()
        {
            InitializeComponent();
            LoadProduct();
        }

        public void LoadProduct()
        {
            int i = 1;
            dgv_Prod.Rows.Clear();
            con.Open();
            com = new SqlCommand("SELECT * FROM tbProduct", con);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                dgv_Prod.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(),dr[5].ToString(),dr[6].ToString());
                i++;
            }
            dr.Close();
            con.Close();
        }

        private void btn_addProd_Click(object sender, EventArgs e)
        {
            ProductModule productModule = new ProductModule();
            productModule.btn_productAdd.Enabled = true;
            productModule.btn_productUpdate.Enabled = false;
            productModule.ShowDialog();
            LoadProduct();
        }

        private void dgv_Prod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_Prod.Columns[e.ColumnIndex].Name;
            if (colName == "Column4")
            {
                ProductModule prodModule = new ProductModule();
                prodModule.stockCode_textBox.Text = dgv_Prod.Rows[e.RowIndex].Cells[1].Value.ToString();
                prodModule.prodName_textBox.Text = dgv_Prod.Rows[e.RowIndex].Cells[2].Value.ToString();
                prodModule.prodCount_numeric.Text = dgv_Prod.Rows[e.RowIndex].Cells[3].Value.ToString();
                prodModule.minProdCount_numeric.Text = dgv_Prod.Rows[e.RowIndex].Cells[4].Value.ToString();
                prodModule.addProdCound_numeric.Text = dgv_Prod.Rows[e.RowIndex].Cells[5].Value.ToString();
                prodModule.orderCount_numeric.Text = dgv_Prod.Rows[e.RowIndex].Cells[6].Value.ToString();
                prodModule.desc_textBox.Text = dgv_Prod.Rows[e.RowIndex].Cells[7].Value.ToString();
                prodModule.btn_productAdd.Enabled = false;
                prodModule.btn_productUpdate.Enabled = true;
                prodModule.ShowDialog();
            }
            else if (colName == "Column5")
            {
                if (MessageBox.Show("Bu Ürün Bilgisini Silmek İstediğine Emin misin?", "Ürün Bilgisini Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    com = new SqlCommand("DELETE FROM tbProduct WHERE stockcode LIKE '" + dgv_Prod.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    com.ExecuteNonQuery();
                    con.Close();
                    LoadProduct();
                    MessageBox.Show("Ürün Bilgisi Silindi !");

                }
            }
            LoadProduct();
        }
    }

}
