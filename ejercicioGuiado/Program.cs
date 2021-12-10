using System;

namespace ejercicioGuiado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Vehiculo
    {
        public void ArrancarMotor()
        {

        }

          public void apagarMotor()
        {

        }

        public virtual void Conduicir()
        {
            
        }
    }

    public class Avion: Vehiculo
    {
        public override void Conduicir()
        {
            
        }
    }

    public class coche: Vehiculo
    {
         public override void Conduicir()
        {
            
        }
    }
}
