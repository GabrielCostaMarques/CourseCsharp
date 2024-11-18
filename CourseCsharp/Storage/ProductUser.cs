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
        ProductModel p = new ProductModel();

        public void ProductShow() {
            
            Console.WriteLine("Entre os dados do produto");
            Console.WriteLine("Nome: ");
            p.Name = Console.ReadLine();

            Console.WriteLine("Preço: ");
            p.Price= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantidade no estoque: ");
            p.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do Produto: "+p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser adicionados no estoque: ");
            
            int qty= int.Parse(Console.ReadLine());  
            p.AddProduct(qty);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: "+p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removidos no estoque: ");

            qty= int.Parse(Console.ReadLine());
            p.RemoveProduct(qty);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: "+p);
        }
    }
}
