using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductTable_Practice
{
    public partial class Form1 : Form
    {
        NORTHWNDEntities db;
        public Form1()
        {
            InitializeComponent();
            db = new NORTHWNDEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = db.Products.ToList();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            NewProduct newProduct = new NewProduct(-1);
            newProduct.ShowDialog();
        }
        int productID = 0;
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvProducts.SelectedRows[0];
            productID = (int)selected.Cells["ProductID"].Value;

            NewProduct frm = new NewProduct(productID);
            frm.ShowDialog();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bir kategori seçiniz");
                return;
            }
            DataGridViewRow selected = dgvProducts.SelectedRows[0];
            productID = (int)selected.Cells["ProductID"].Value;
            Product current = (from c in db.Products where c.ProductID == productID select c).Single();
            db.Products.Remove(current);
            db.SaveChanges();
        }
    }
}
