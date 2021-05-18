using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            var preco = 1000.00;
            var desconto = 0.1;
            var imposto = 355;

            double total = preco + imposto;
            var TotalComDesconto = total - (total * desconto);
            Console.WriteLine($"O preço total é: {TotalComDesconto} ");

            //IMC 
            double peso = 49.9;
            double altura = 1.68;
            double imc = peso / Math.Pow(altura, 2); // vai elevar a altura a 2
            Console.WriteLine($"Seu IMC é de: {imc}");

        }
    }
}
