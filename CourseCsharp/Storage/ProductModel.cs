using System.Globalization;
using System.Xml.Linq;

namespace CourseCsharp.Estoque
{
    internal class ProductModel
    {
        private string _name;
        public double Price { get; private set; }
        public int Quantity { get; private set; }


        public ProductModel() { }

        public ProductModel(string name, double price, int quantity)
        {
            _name = name;
            Price = price;
            Quantity = quantity;
        }

        /*Propriert*/
        public string Name
        {
            get { return _name; }
            set
            { 
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
                else
                {
                    _name = "ERRO";
                }
            }
        }


        public double TotalValueStock()
        {
            return Price * Quantity;

        }

        public void AddProduct(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveProduct(int quantity)
        {
            Quantity -= quantity;
        }

        public override string ToString()
        {
            return _name
                    + ", R$ "
                    + Price.ToString("F2", CultureInfo.InvariantCulture)
                    + ", "
                    + Quantity
                    + " unidades, Total: R$ "
                    + TotalValueStock().ToString("f2", CultureInfo.InvariantCulture);
        }



    }
}
