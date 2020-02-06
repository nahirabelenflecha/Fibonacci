using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
          int f1=0, f2=1, cant, aux;
          string linea;

          Console.WriteLine("¿Cuantos numeros de la serie de Fibonacci desea ver?");
          linea = Console.ReadLine();
          cant = int.Parse(linea);
          
          for (int i=0; i<cant; i++)
          {
            aux = f1;
            f1 = f2;
            f2 = aux + f1;
            Console.WriteLine(f1);
          }
        }
    }
}