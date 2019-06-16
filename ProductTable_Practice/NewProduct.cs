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
    public partial class NewProduct : Form
    {
        NORTHWNDEntities db;
        Product Product;
        Supplier sp;
        Category category;
        bool discontinued;
        int ProductID = 0;
        public NewProduct(int CurrentProductID)
        {
            InitializeComponent();
            db = new NORTHWNDEntities();
            ProductID = CurrentProductID;
        }

        private void NewProduct_Load(object sender, EventArgs e)
        {
            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryID";
            cmbCategories.DataSource = db.Categories.ToList();

            cmbSuppliers.DisplayMember = "CompanyName";
            cmbSuppliers.ValueMember = "SupplierID";
            cmbSuppliers.DataSource = db.Suppliers.ToList();

            if (ProductID>0)
            {
                Product = (from a in db.Products where a.ProductID == ProductID select a).Single();
                txtProductName.Text = Product.ProductName;
                txtQPU.Text = Product.QuantityPerUnit;
                nmUP.Value = (decimal)Product.UnitPrice;
                nmUIS.Value = (decimal)Product.UnitsInStock;
                nmUIO.Value = (decimal)Product.UnitsOnOrder;
                nmReorderLevel.Value = (decimal)Product.ReorderLevel;
                if (Product.Discontinued)
                {
                    rdbT.Checked = true;
                }
                else
                {
                    rdbF.Checked = true;
                }
            } 
        }
        
        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            if (cmbSuppliers.SelectedIndex>0)
            {
                if (cmbCategories.SelectedIndex>0)
                {
                   
                    if (ProductID<0)
                    {
                        Product = new Product();
                    }                   
                    Product.ProductName = txtProductName.Text;
                    Product.SupplierID =(int)cmbSuppliers.SelectedValue;
                    Product.CategoryID = (int)cmbCategories.SelectedValue;
                    Product.QuantityPerUnit = txtQPU.Text;
                    Product.UnitPrice = nmUP.Value;
                    Product.UnitsInStock = (short)nmUIS.Value;
                    Product.UnitsOnOrder = (short)nmUIO.Value;
                    Product.ReorderLevel = (short)nmReorderLevel.Value;
                    Product.Discontinued = discontinued;
                    if (ProductID<0)
                    {
                        db.Products.Add(Product);
                    }                                    
                }
            }
            int resut = db.SaveChanges();
            if (resut>0)
            {
                MessageBox.Show("İşlem Başarıyla Gerçekleştirildi");
            }
            else
            {
                MessageBox.Show("bir hata oluştu");
            }
        }        
        private void rdbF_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbF.Checked)
            {
                discontinued = false;
            }
            else if (rdbT.Checked)
            {
                discontinued = true;
            }
        }

    }
}
