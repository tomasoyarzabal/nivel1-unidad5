using System;

namespace ejerciciou5c
{
    class Program
    {
        static void Main(string[] args)
        {
            int e, acu = 0, con = 0, promedio;
            for(int x = 0; x < 5; x++)
            {
                Console.WriteLine("ingrese su edad");
                e = int.Parse(Console.ReadLine());
                if(e > 18)
                {
                    acu+=e;
                    con++;
                } 
            }
            promedio = acu/con;
            Console.WriteLine("el promedio es " + promedio);
        }
    }
}
