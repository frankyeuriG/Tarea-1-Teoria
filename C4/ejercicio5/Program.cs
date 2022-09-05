using System;

namespace Ejercicio5{
    class edad
    {
        static void Main(String [] args){
            int edad = 1;
            int suma = 0;
            int c = 0;
            int mayor = 0;
            float promedio = 0.0f;
            while(edad != 10){
                Console.WriteLine("Ingrese la edad: ");
                edad = int.Parse(Console.ReadLine());
                if (edad > 0){
                    suma = suma + edad;
                    c++;
                    promedio = suma/c;
                    Console.WriteLine("marque 0 para terminar");
                if (edad > mayor){
                        mayor = edad;  
                   }
                }
            }
            Console.WriteLine("El promedio es {0}", promedio);
            Console.WriteLine("Mayor edad: {0}", mayor);

        }
    }
}