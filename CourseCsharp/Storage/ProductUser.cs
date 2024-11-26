using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCsharp.Estoque
{
    internal class ProductUser
    {
                
        public void ProductShow() {

           ProductModel product = new ProductModel("TV",500.00,10);

            product.Name ="T";
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Quantity) ;
            Console.WriteLine(product.Price) ;
        }
    }
}
