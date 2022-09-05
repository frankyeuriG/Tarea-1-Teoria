using System;

namespace Ejercicio1
{
    class program {
        static void Main(String [] args){

           int valor1 = 0;
           int valor2 = 0;
           float Perimetro = 0.0f;

            Console.WriteLine("Digite el numero de lados:"); 
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la medida de un lado del poligono");
            valor2 = int.Parse(Console.ReadLine());

            Perimetro = valor1 *valor2;
            Console.WriteLine("Perimetro regular es {0} M", Perimetro);
        
        }

    
    }
    
}