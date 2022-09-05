using System;

namespace Ejercicio2 {
    class potencia{
        static void Main(String [] args){

            int resultado = 1;
            int n = 0;
            int p = 0;
            int cont = 0;

            Console.WriteLine("Digite el numero:");
            n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite la potencia a la cual debemos elevar:");
            p = int.Parse(Console.ReadLine());
            

        while(cont <= p){
            resultado = resultado * n;
            cont ++;
        }
       Console.WriteLine(resultado);
        }
    }
}