using System;

namespace ex24
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("\nTribonnaci \n");

            Tribonnaci conta = new Tribonnaci(10);
            Console.WriteLine("\nQuadrinacci \n");
            Quadrinacci conta2 = new Quadrinacci(10);
            Console.WriteLine("\nQuintenacci \n");
            Quintenacci conta3 = new Quintenacci(10);
            Fatorial fat = new Fatorial();
            
            Console.WriteLine("\nFatorial \n");
            Console.WriteLine(fat.fat(25));
            
        }
    }
}
