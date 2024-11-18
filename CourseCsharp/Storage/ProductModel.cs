using System.Globalization;

namespace CourseCsharp.Estoque
{
    internal class ProductModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

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
            return Name 
                    + ", R$ " 
                    + Price.ToString("F2", CultureInfo.InvariantCulture)
                    + ", "
                    + Quantity
                    +" unidades, Total: R$ "
                    + TotalValueStock().ToString("f2",CultureInfo.InvariantCulture);
        }



    }
}
