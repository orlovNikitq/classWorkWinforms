using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        Product product;
        bool addNew;
        public Form2(Product product, bool addNew)
        {
            InitializeComponent();
            this.product = product;
            this.addNew = addNew;
            if(addNew == false)
            {
                nameT.Text = product.Name;
                madeT.Text = product.Made_in;
                priceT.Text = product.Price.ToString();
                this.Text = "Редактирование товара";
            }
            else
            {
                this.Text = "Добавление товара товара";
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (nameT.Text == "" || madeT.Text == "" || priceT.Text == "")
            {
                MessageBox.Show("Заполните поля");
                return;
            }
            if(product == null)
            {
                product = new Product();
            }
            product.Name = nameT.Text;
            product.Made_in =  madeT.Text;
            product.Price = Convert.ToDouble(priceT.Text);
            this.DialogResult = DialogResult.Yes;
        }
    }
}
