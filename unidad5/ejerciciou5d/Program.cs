using System;

namespace ejerciciou5d
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, con = 0;
            Console.WriteLine("ingrese un numero");
            n = int.Parse(Console.ReadLine());
            for(int x = 1; x <= n; x++)
            {
               if(n % x == 0)
                con++;
            }
            if(con == 2)
                Console.WriteLine("es primo");
            else
                Console.WriteLine("no es primo");
            
        }
    }
}
