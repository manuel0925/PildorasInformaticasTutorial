using System;

namespace conceptosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            RealizarTarea();

        }

        static void RealizarTarea()
        {
            // TODO:APARTIR DE 
            ClasePunto origen= new ClasePunto();
            ClasePunto destino = new ClasePunto(128,80);

            double distancia = origen.DitanciaHasta(destino);
            Console.WriteLine(distancia);

        }
             
        


    }
}
