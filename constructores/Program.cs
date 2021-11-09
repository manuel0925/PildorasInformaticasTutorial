using System;

namespace constructores
{
    class Program
    {
        static void Main(string[] args)
        {
           Coche coche1 = new Coche();

           Coche coche2 = new Coche();

           Coche coche3 = new Coche(25.5,800.7);

          

           Console.WriteLine(coche1.infoCoche());
           Console.WriteLine(coche3.infoCoche());

        }
    }

    class Coche 
    {
        
        private int ruedas {get;set;}
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;

        public Coche()
        {
            ruedas = 4;

            largo = 2300.5;

            ancho = 0.800;
        }

        public Coche(double largo,double ancho)
        {
            ruedas = 4;

            this.largo = largo;

            this.ancho = ancho;
        }

        public string  infoCoche(){
            return $"las ruedas del con son {ruedas} el largo es {largo} y el ancho es {ancho}";
        }

    }
}
