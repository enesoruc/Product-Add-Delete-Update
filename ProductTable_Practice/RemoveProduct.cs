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
    public partial class RemoveProduct : Form
    {
        int productID = 0;
        NORTHWNDEntities db;
        Product Product;
        public RemoveProduct(int currentPorductID)
        {
            InitializeComponent();
            productID = currentPorductID;
            db = new NORTHWNDEntities();
        }

        private void RemoveProduct_Load(object sender, EventArgs e)
        {
            Product = (from a in db.Products where a.ProductID == productID select a).Single();
            textBox1.Text = Product.ProductName;
        }
    }
}
