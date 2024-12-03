using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCsharp.Hotel
{
    public class HotelUser

    {
        public void HotelShow()
        {
            HotelModal[] vetor = new HotelModal[10];


            Console.WriteLine("Quantos quartos vao ser reservados?");
            int r = int.Parse(Console.ReadLine());


            for (int i = 1; i <= r; i++)
            {
                Console.WriteLine("Reserva #" +i);

                Console.Write("Name: ");
                string name = Console.ReadLine();


                Console.Write("E-mail: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                Console.WriteLine();

                vetor[room] = new HotelModal(name, email, room);

            }

            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] != null) {
                    Console.WriteLine(i+": " + vetor[i]);
                }

            }



        }

    }
}
