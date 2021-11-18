using System;

namespace UsoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");

            int[] edades;

            edades =new int[4];

            edades[0] = 5;
            edades[2] = 6;
            edades[2] = 7;
            edades[3] = 8;

            Console.WriteLine($"{edades[0]} {edades[1]} {edades[2]} {edades[3]}");


            char[] letras = { 'a', 'b', 'c' };

            Console.WriteLine(letras[1]);

            var valoreRandom = new [] { "juan", "pedro"};

            Console.WriteLine($"{valoreRandom[0]} {valoreRandom[1]}");

            
            */
            Persona[] Personas = new Persona[2];

            Persona maria = new Persona("maria", 32);
            Persona juana = new Persona("juana", 25);

            Personas[0] = juana;
            Personas[1] = maria;

            //Console.WriteLine($"{Personas[0].Edad} {Personas[1].Nombre}");

            Animal[] Animales = new [] { new Animal("perro", 4), new Animal("pato", 2) };

            //Console.WriteLine($"{Animales[0].Nombre} {Animales[0].Patas}");
            //Console.WriteLine($"{Animales[1].Nombre} {Animales[1].Patas}");

            //array de clase anonima o de tipo anonimo*/

            var ninios = new[]
            {
                new {Nombre="bebo",Papa="eliza"},
                new { Nombre = "zaid", Papa = "esteban" },
                 new { Nombre = "moises", Papa = "gino" }
            };

            /*for (int i = 0; i < ninios.Length; i++)
            {

                Console.WriteLine(ninios[i]);

            }*/

            foreach (var ninio in ninios) {

                Console.WriteLine(ninio.Nombre);
            }



        }

       public class Persona {

            public Persona(String Nombre,int Edad) {
                this.Nombre = Nombre;

                this.Edad = Edad;
            }

            public string Nombre;

            public int Edad;
        }

        public class Animal
        {

            public Animal(String Nombre, int Patas)
            {
                this.Nombre = Nombre;

                this.Patas = Patas;
            }

            public string Nombre;

            public int Patas;
        }
    }
}
