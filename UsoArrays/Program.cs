using System;

namespace UsoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Nombre = new string[] { "emmanuelk", "edwaerdo", "felix" };
            ProcesarDatos();
        }

        static int[] ProcesarDatos()
        {

            Console.WriteLine("Cuanbto elemento quires que tenga el array");
            string respuesta = Console.ReadLine();    

            int numeroElementos = int.Parse(respuesta);
            
            int[] elementos = new int[numeroElementos];

            for (int i = 0; i < numeroElementos; i++)
            {
                elementos[i] = i + 1;
            }

            return elementos;
           
        }

    }
}
