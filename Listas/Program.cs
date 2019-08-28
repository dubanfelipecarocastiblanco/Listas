using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            numeros.Add(0);
            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(4);
            numeros.Add(5);
            numeros.Add(6);
            numeros.Add(7);
            numeros.Add(8);
            numeros.Add(9);
            numeros.Add(10);

            Console.WriteLine("Esta es la lsita de los numeros: ");

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Esta es la lista de los dias de la semana: ");

            var DiasSemanas = new List<string>();
            DiasSemanas.Add("Lunes");
            DiasSemanas.Add("Martes");
            DiasSemanas.Add("Miercoles");
            DiasSemanas.Add("Jueves");
            DiasSemanas.Add("Viernes");
            DiasSemanas.Add("Sabado");
            DiasSemanas.Add("Domingo");

            foreach (var item2 in DiasSemanas)
            {
                Console.WriteLine(item2);
            }

            Console.WriteLine();

            Console.Write("Eliminar numeros: ");
            numeros.Remove(0);

            Console.WriteLine();

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
        }
    }
}
