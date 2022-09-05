using System;

namespace Ejercicio5 {
    class AreaYperimetro{
        static void Main(String [] args){
            Console.WriteLine("Elija una opcion  1 o 2: ");
             Console.WriteLine("1-Calcular Area de poligono regular:");
            Console.WriteLine("2- Calcular Perimetro del poligono regular: ");

            int opcion = int.Parse(Console.ReadLine());

            double apotemo = 0.0f;
            int lado = 0;
            int cantl = 0;
            double resultado = 0.0f;

            
             
        switch(opcion){
                case 1:
                    Console.WriteLine("Introduzca el apotemo del poligono: ");
                    apotemo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Introduzca el valor del tama;o de un lado del poligono:");
                    lado = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca el numero de lados del poligono: ");
                    cantl = int.Parse(Console.ReadLine());

                    resultado = (lado * cantl * apotemo) / 2;
                    Console.WriteLine("El area del poligono es {0}: ", resultado);

                break;

                case 2:
                    Console.WriteLine("Introduzca el valor del tama;o de un lado del poligono:");
                    lado = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca el numero de lados del poligono: ");
                    cantl = int.Parse(Console.ReadLine());

                    resultado = lado * cantl;
                    Console.WriteLine("El perimetro del poligono es {0}: ", resultado);

                break;

                default: 
                    Console.WriteLine("la opcion elegida no es valida");
                break;
                }
            
        }
    }
}