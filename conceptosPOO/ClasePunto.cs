using System;

namespace conceptosPOO
{
    public class ClasePunto
    {
        public ClasePunto(int x, int y)
        {
            //Console.WriteLine($"la cordena x:{x} y la cordenada y:{y}");

            this.x = x;
            this.y = y;

            contadorDeObjetos++; 

        }

        public ClasePunto()
        {
            //Console.WriteLine($"la cordena no tienen valor en este contructor");

            this.x = 0;
            this.y = 0;
            
            contadorDeObjetos++; 

        }

        public double DitanciaHasta(ClasePunto punto)
        {
            int xDif = this.x - punto.x;
            int yDif = this.y - punto.y;

            double DitanciaPuntos = Math.Sqrt(Math.Pow(xDif,2)+Math.Pow(yDif,2));

            return DitanciaPuntos;
        }

        /*public static int ContadorDeObjetos(){
            return contadorDeObjetos;
        }*/

        public static int ContadorDeObjetos()=> contadorDeObjetos;
        

        private int x,y;
        private static int contadorDeObjetos = 0;

        public const double constanteDeprueba = 3.14;


    }
}
