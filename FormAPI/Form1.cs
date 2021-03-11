using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Product Id", 100);
            listView1.Columns.Add("Product Name", 250);
            listView1.Columns.Add("Category Name", 250);
            listView1.Columns.Add("Units in Stock", 150);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetProductDetails())
            {
                string id = "", productName = "", categoryName = "", unitsInStock = "";
                id = Convert.ToString(product.ProductId);
                productName = product.ProductName;
                categoryName = product.CategoryName;
                unitsInStock = Convert.ToString(product.UnitsInStock);
                string[] details = { id, productName, categoryName, unitsInStock };

                ListViewItem viewItem = new ListViewItem(details);
                listView1.Items.Add(viewItem);
            }
        }
    }
}
