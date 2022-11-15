using System;

namespace _3_10_programacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arreglosNumericos = {0, 18, 2, 43, 24, 56, 63, 78, 8, 99};
            int valor;
            Console.WriteLine("Ingrese un valor: ");
            valor= Convert.ToInt32(Console.ReadLine());

            buscarEnArreglo(arreglosNumericos, valor);

            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }

        private static void buscarEnArreglo(int[] numeros, int buscar)
        {
            bool encontrado = false;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == buscar)
                {
                    encontrado = true;
                }
            }
            Console.WriteLine(encontrado == true ? "El valor fue encontrado " : "El valor NO fue encontrado");
        }
    }
}
