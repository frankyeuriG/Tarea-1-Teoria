namespace Ejercicio1
{
    class Pares {
        static void Main(String [] args){

           Console.WriteLine("Este programa me dices si el entero que introduzca es par o inpar");
            int numero = 0;
            
            Console.WriteLine("Introduzca el numero: "); 

            numero = int.Parse(Console.ReadLine());
            int resultado = 0;
            resultado = numero % 2;

            if (resultado == 0 ){
                Console.WriteLine("eL NUMERO es par {0}", numero);
            }else {
                Console.WriteLine("El numero es impar {0}", numero);
            }Console.WriteLine("El residuo es igual a {0}", resultado);     

        }
    }
}
