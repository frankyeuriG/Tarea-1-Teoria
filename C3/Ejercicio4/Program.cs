using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4 
 {
    class DiasSemana
    {
        static void Main(String [] args){

            
            Console.WriteLine("1-Domingo");
            Console.WriteLine("2-Lunes");
            Console.WriteLine("3-Marte");
            Console.WriteLine("4-Miercole");
            Console.WriteLine("5-Jueves");
            Console.WriteLine("6-Viernes");
            Console.WriteLine("7-Sabado");

            int opcion =0;
            Console.WriteLine("Digite el numero:");
            opcion = int.Parse(Console.ReadLine());
            

            switch(opcion){
                case 1: 
                 Console.WriteLine("Es Domingo");
                  break;
                case 2:
                 Console.WriteLine("Es Lunes");
                 break;
                case 3: 
                  Console.WriteLine("Es Marte");
                  break; 
                case 4: 
                  Console.WriteLine("Es Miercole");
                  break;
                case 5: 
                  Console.WriteLine("Es Jueve");
                  break;  
                 case 6: 
                  Console.WriteLine("Es vierne");
                  break;
                case 7: 
                  Console.WriteLine("Es Sabado");
                  break;
                default :
                    Console.WriteLine("Eligio una opcion No validad");
                    break; 
                }
            }

        }
 }