using System;

namespace Övning_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("FOR loop: ");
            for(int i = 1; i <= 10; i++) {

                Console.Write(i + " ");

            }

            Console.WriteLine(" ");
            
            Console.Write("WHILE loop: ");
            int j = 1;
            while (j <= 10) {
                Console.Write(j + " ");
                j ++;
            }

            Console.WriteLine(" ");

            Console.Write("DO-WHILE loop: ");
            int z = 1;
            do {

                Console.Write(z + " ");
                z ++;
            }
            while (z <= 10);

            Console.WriteLine(" ");
            
            Console.Write("FOREACH loop: ");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int n in numbers) Console.Write(n + " ");
        }
    }
}
