namespace Ejercicio5 {
    class EuroYdolar
    {
        static void Main(String [] args){
            int Dolar = 0;
            float Euro = 0.0f;
            Console.WriteLine("Digite La cantidad de Dolar ");
            Dolar = int.Parse(Console.ReadLine());

            Euro = Dolar * 1;

            Console.WriteLine("Dolar Y Euros El dia de hoy estan al mismo precio por lo que {0} Dolar es =  {1} Euros", Dolar , Euro);

        }
    }
}