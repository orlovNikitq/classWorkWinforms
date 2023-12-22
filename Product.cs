using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class Product
    {
        private string name;
        private string made_in;
        private double price;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Made_in
        {
            get { return made_in; }
            set { made_in = value; }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (price < 0 || value < 0)
                    throw new Exception("Цуна товара не может быть меньше нуля");
                else price = value;
            }
        }
        public Product()
        {
            Name = "tovar1";
            Made_in = "Kitay";
            price = 1;
        }
        public override string ToString()
        {
            return $"название: {Name}, изготовитель {Made_in}, цена: {Price}";
        }
    }
}
