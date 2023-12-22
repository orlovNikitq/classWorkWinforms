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
    public partial class Form1 : Form
    {
        Product product = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Для удаления выбирите товар");
                return;
            }
            else
                listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void add_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(product,true);
            product = new Product();
            if (form.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(product);
            }
        }

        private void redact_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Для редактирования выбирите товар");
                return;
            }
            int temp = listBox1.SelectedIndex;
            product = (Product)listBox1.Items[temp];
            Form2 form = new Form2(product, false);
            DialogResult result = form.ShowDialog();
            if(result == DialogResult.OK)
            {
                listBox1.Items.RemoveAt(temp);
                listBox1.Items.Insert(temp, product);
                listBox1.SelectedIndex = temp;

            }
        }
    }
}
