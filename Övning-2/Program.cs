using System;

namespace Öving_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("FOR-loop: ");
            for (int i = 40; i >= 30; i--) {
                Console.Write(i + " ");
            }
            
            Console.WriteLine(" ");
            
            Console.Write("WHILE loop: ");
            int j = 40;
            while(j >= 30) {
                Console.Write(j + " ");
                j--;
            }

            Console.WriteLine(" ");

            Console.Write("DO-WHILE loop: ");
            int z = 40;
            do {
                Console.Write(z + " ");
                z--;
            }
            while (z >= 30);
        }
    }
}
