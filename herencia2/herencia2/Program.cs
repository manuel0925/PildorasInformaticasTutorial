using System;

namespace herencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caballo Babieca = new Caballo("babieca");
            Humanos Manuel = new Humanos("eliza");
            Gorilla Copito = new Gorilla("copito");


            Manuel.getNombre();


        }
    }

    class Mamiferos
    {
        private string nombreServivo;
        public Mamiferos(string nombre) 
        {
            nombreServivo = nombre;
        }

        public void respirar()
        {
            Console.WriteLine("soy capz de repisrar");
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan pos is solas");
        }

        public void getNombre() { 
            Console.WriteLine(nombreServivo);
        }

    }

    class Caballo : Mamiferos
    {   
        public Caballo(string nombreCaballo): base(nombreCaballo)
        {

        }
        public void galopar()
        {
            Console.WriteLine("soy capaz de galopar");
        }
    }

    class Humanos : Mamiferos
    {
        public Humanos(string nombreHumano) : base(nombreHumano)
        {

        }
        public void pensar()
        {
            Console.WriteLine("soy capaz de pensar");
        }
    }

    class Gorilla : Mamiferos
    {
        public Gorilla(string nombreGorilla) : base(nombreGorilla)
        {

        }
        public void trepar()
        {
            Console.WriteLine("soy capaz de trepar");
        }
    }

}
