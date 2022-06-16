using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_creds_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }

        private void btn_cred_cont_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductForm());
        }

        private void prod_data_control_btn_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            if(productForm.dgv_Prod.Rows.Count == 0)
            {
                MessageBox.Show("Ürün Listesi Boş !", "Liste Uyarısı !", MessageBoxButtons.OK);
            }else            
            {
                productForm.dgv_Prod.AllowUserToAddRows = false;
                for (int i = 0; i < productForm.dgv_Prod.Rows.Count; i++)
                {
                    if (productForm.dgv_Prod.Rows[i].Cells[0].Value?.ToString() == String.Empty)
                    {
                        continue;
                    }
                    else if (Int16.Parse(productForm.dgv_Prod.Rows[i].Cells[3].Value.ToString()) < Int16.Parse(productForm.dgv_Prod.Rows[i].Cells[4].Value.ToString()))
                    {
                        MessageBox.Show(productForm.dgv_Prod.Rows[i].Cells[1].Value.ToString() + " Stok Kodlu " + productForm.dgv_Prod.Rows[i].Cells[2].Value.ToString() + " Miktarı " + productForm.dgv_Prod.Rows[i].Cells[4].Value.ToString() + " Değerinin Altına Düşmüştür. Sipariş Vermeniz Gereken Ürün Miktarı = " + (Int32.Parse(productForm.dgv_Prod.Rows[i].Cells[5].Value.ToString()) + 10).ToString(), "Ürün Uyarısı !", MessageBoxButtons.OK);
                    }
                }
            }
            
        }
    }
}
