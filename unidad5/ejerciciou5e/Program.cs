using System;

namespace ejerciciou5e
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, maxp = 0, mini = 0;
            bool bp = false, bi = false;
            Console.WriteLine("ingrese un numero");
            for(int x = 0; x < 5; x++)
            {
                n = int.Parse(Console.ReadLine());
                if(n % 2 ==0)
                {
                   if(bp == false)
                   {
                    maxp = n;
                    bp = true;
                   }
                   else if(n > maxp)
                   {
                    maxp = n;
                   }
                }
                else
                {
                    if(bi == false)
                    {
                        mini = n;
                        bi = true;
                    }
                    else if(n < mini){
                        mini = n;
                    }
                }
            }
            Console.WriteLine("EL MAXIMO PAR ES " + maxp);
            Console.WriteLine("EL MINIMO IMPAR ES " + mini);
        }
    }
}
