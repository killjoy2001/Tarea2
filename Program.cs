using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] empleado = { "Kenny", "Maria", "Pablo", "Ana", "Mauricio" };
            int[] salario = { 800, 1200, 600, 1500, 1000 };

            for (int i = 0; i < salario.Length; i++)
            {
                salario[i] *= 12;
                Console.WriteLine("El aguinaldo de " + empleado[i] + " equivale a " + salario[i] );
            }

            Console.ReadKey();
        }
    }
}
