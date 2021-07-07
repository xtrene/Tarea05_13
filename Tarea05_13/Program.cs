using System;

namespace Tarea05_13
{
    class Program
    {

        static Random alea = new Random();
        static public int generaNumero(int n1, int n2)
        {
            int resultado = alea.Next(n1, n2);
            return resultado;
        }


        static void Main(string[] args)
        {

            int dimension = 0;
            Console.Write("Dimensión del array: ");
            dimension = Convert.ToInt32( Console.ReadLine());

            int[] lista = new int[dimension];

            for (int i=0; i < lista.Length; i++)
            {
                lista[i] = generaNumero(1, 10);
            }
            Console.WriteLine("La lista generada es: ");
            
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write(" {0} ", lista[i]);
            }


            Console.ReadKey();

        }
    }
}
