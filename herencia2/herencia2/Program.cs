using System;

namespace herencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Caballo Babieca = new Caballo("babieca");
             Humanos Manuel = new Humanos("eliza");
             Gorilla Copito = new Gorilla("copito");

             Mamiferos[] almacenAnimales = new Mamiferos[3];

             almacenAnimales[0] = Babieca;
             almacenAnimales[1] = Manuel;
             almacenAnimales[2] = Copito;

             for(int i = 0; i < 3; i++)
             {
                 almacenAnimales[i].pensar();
             }

             IMamifereosTerrestres ImiBabieca = Babieca;
             // Manuel.getNombre();

             Console.WriteLine(ImiBabieca.numeroPatas());*/


            lagartija juancho = new ("juancho");

            juancho.respirar();

            juancho.getNombre();


            Humanos manuel = new("manuel");

            manuel.respirar();
            manuel.getNombre();




        }
    }

    interface IMamifereosTerrestres {
        int numeroPatas();
    }

    interface IAnimlaesYDeportes
    {
        String tipoDeporte();
        Boolean esOlimpico();
    }

    interface ISaltoConPatas
    {
       int numeroPatas();
    }

    abstract class Animales {

        public void respirar() {
            Console.WriteLine("soy capz de repisrar");
        }

        public abstract void getNombre();
        

    }

    class Mamiferos : Animales
    {
        private string nombreServivo;
        public Mamiferos(string nombre) 
        {
            nombreServivo = nombre;
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan pos is solas");
        }

        public override void getNombre() { 
            
            Console.WriteLine($"el nombre del mamifero es {nombreServivo}");
        }

        public virtual void pensar()
        {
            Console.WriteLine("pensamineot basico instintivo");
        }

    }

    class lagartija : Animales
    {

        public lagartija(string nombre)
        {
            nombrerEPTIL = nombre;
        }

        public override void getNombre()
        {
            Console.WriteLine($"el nombre del rEPTIL es {nombrerEPTIL}");
        }
        private string nombrerEPTIL;
   
    }

    class Ballena : Mamiferos
    {
        public Ballena(string NombreBallena) : base(NombreBallena)
        {

        }
        public void nadar(){
            Console.WriteLine("ballena que nade");
            
        }

        public int numeroPatas()
        {
            return 1;
        }
    }

    class Caballo : Mamiferos, IMamifereosTerrestres, IAnimlaesYDeportes, ISaltoConPatas
    {   
        public Caballo(string nombreCaballo): base(nombreCaballo)
        {
             
        }
        public void galopar()
        {
            Console.WriteLine("soy capaz de galopar");
        }

        int IMamifereosTerrestres.numeroPatas() {
            return 4;
        }

        public string tipoDeporte() {
            return "es un caballo de carreras hipica";
        }

        public Boolean esOlimpico() { 
            return true;
        }

        int ISaltoConPatas.numeroPatas()
        {
            return 2;
        }


    }

    class Humanos : Mamiferos
    {
        public Humanos(string nombreHumano) : base(nombreHumano)
        {

        }
        
         public override void pensar()
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

        public override void pensar()
        {
            Console.WriteLine("pensamiento instintivo avanzado de gorilla");
        }
    }

}
