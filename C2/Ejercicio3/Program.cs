
namespace Ejercicio3
{
    class CalculoRadian {

        static void Main(String [] srgs){
            int grados = 0;
            Console.WriteLine("Digite la cantidad de grados :");
             grados = int.Parse(Console.ReadLine());
             Double Radian = 0;

             Radian = grados * Math.PI / 180;

        Console.WriteLine("Grados traducidos a Radianes: {0} rad", Radian);
        } 
    }
    
}