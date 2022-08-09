using System;

namespace ejemplowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0;
            // ejemplo 1.
           // Console.WriteLine("ingrese un numero");
            //n = int.Parse(Console.ReadLine());
            //while(n != 0){
              //  con++;
               // Console.WriteLine("ingrese un numero");
                //n = int.Parse(Console.ReadLine());
           // }
            //Console.WriteLine("ingresaste " + con + " nros");

            // ejemplo 2.
            //while (con < 10)
           // {
                //con++;
                //Console.WriteLine(con);
            //}


            // ejemplo do while.

            do
            {
                Console.WriteLine("INGRESE UN NRO");
                n = int.Parse(Console.ReadLine());          
            }while(n != 0);

            //me permite entrar y luego preguntar y en el ejemplo de arriba no tengo la necesidad de escribir
            //las lineas de codigos afuera del ciclo.
            //pero si yo quisiera usarlo para contar o buscar un minumo no es recomendable.
            
        }
    }
}
