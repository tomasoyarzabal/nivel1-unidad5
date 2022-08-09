using System;

namespace ejerciciou5b
{
    class Program
    {
        static void Main(string[] args)
        {
            //max se inicializa en 0 para el que el compilador lo entienda
            // la verdad es que arranca con el valor que contenga "n" en la primera vuelta.
           int n, max = 0;

           for(int x = 0; x < 5; x++){
            Console.WriteLine("ingrese un nro");
            n = int.Parse(Console.ReadLine());
            if( x == 0)
                max = n;
            else
            {
                if(n > max)
                max = n;
            }
           }
           Console.WriteLine("el maximo es " + max);
        }
             
            
    }
}
