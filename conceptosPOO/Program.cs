using System;
using static System.Math;
using static System.Console;

namespace conceptosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //RealizarTarea();
            /*
            double raiz = Sqrt(9);
            double potencia = Pow(3,4);

            WriteLine(raiz);
            WriteLine(potencia);
            */

            var miVariableX = new {NOmbre="emmanuel", edad=28};
            //WriteLine($"mi nombre es {Nombre} y mi edad")
        }

        static void RealizarTarea()
        {
            // TODO:APARTIR DE 
            ClasePunto origen= new ClasePunto();
            ClasePunto destino = new ClasePunto(128,80);
            ClasePunto otroPunto = new ClasePunto();


          

            double distancia = origen.DitanciaHasta(destino);
            Console.WriteLine(distancia);
            Console.WriteLine($"numero de objetos creados {ClasePunto.ContadorDeObjetos()} Y LA CONcontante de prueba es iguaa a {ClasePunto.constanteDeprueba}");


        }
             
        


    }
}
