using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Digite seu nome");
            string name = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o seu salario?");
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine($" {name} {age} {salary}");

        }
    }
}
