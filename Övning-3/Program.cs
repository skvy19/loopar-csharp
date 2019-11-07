using System;

namespace Övning_3
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "";
            int i = 1;
            while( input != "Q" ) {

                Console.WriteLine("och sedan då?");
                input = Console.ReadLine();
                i *= 2;

                for(int j = 2; j <= i; j++) {

                    if( input != "Q" ) Console.WriteLine("och sedan då?");
                    
                };

            };

        }
    }
}
