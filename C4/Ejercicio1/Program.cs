using System;

namespace Ejercicio4{
    class Tabla{
        static void Main(String [] args){
            int numero = 0;
            string valor = " ";
            int n = 0;
            int resultado = 0 ;

            Console.WriteLine("Introduzca el numero");
            valor = Console.ReadLine();

            numero = Convert.ToInt32(valor);

            for( n = 1; n <= 10 ; n++){
                resultado = n * numero;
                Console.WriteLine( n +"x"+ numero+"="+ resultado);
            }
            Console.ReadKey();
        }
    }
}