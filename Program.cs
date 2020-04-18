using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc_vect_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Aluguel[] vect = new Aluguel[10];
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Aluguel #{i}: ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quartos: ");
                int quartos = int.Parse(Console.ReadLine());
               

                vect[quartos] = new Aluguel(name, email, quartos);
                Console.WriteLine();

            }


            Console.WriteLine("Quartos ocupados: ");
            foreach ( Aluguel obj in vect)
            {
                if (obj != null)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine();

        }
    }
}
