<<<<<<< HEAD
﻿using System;

namespace UsoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] edades;

            edades = new int[4];

            int[] anios = new int[4] {1990,1992,1993,150};

            edades[0] = 10;
            edades[1] = 20;
            edades[2] = 30;
            edades[3] = 50;
            //edades[4] = 60;

            Console.WriteLine(edades[3]);
            Console.WriteLine(anios[2]);

        }
    }
}
=======
﻿using System;

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
>>>>>>> 939fee1c1c08cd6b47ce252a3f2361aff42e4fdd
