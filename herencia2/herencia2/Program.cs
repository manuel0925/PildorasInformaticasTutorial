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

            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = Babieca;
            almacenAnimales[1] = Manuel;
            almacenAnimales[2] = Copito;

            for(int i = 0; i < 3; i++)
            {
                almacenAnimales[i].pensar();
            }
           // Manuel.getNombre();




        }
    }

    interface IMamifereosTerrestres {
        int numeroPatas();
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

        public virtual void pensar()
        {
            Console.WriteLine("pensamineot basico instintivo");
        }

    }

    public class Ballena : Mamiferos
    {
        public Ballena(string NombreBallena) : base(NombreBallena)
        {

        }
        public void nadar(){
            Console.WriteLine("ballena que nade");
            
        }
    }

    class Caballo : Mamiferos, IMamifereosTerrestres
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
