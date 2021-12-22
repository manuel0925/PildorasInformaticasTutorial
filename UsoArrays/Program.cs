
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
