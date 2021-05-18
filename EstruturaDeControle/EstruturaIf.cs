using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota); // ele vai pegar o numero que o usuario
                                                       // digitou e colocar em variavel

            Console.WriteLine("Possui bom corpormanto? S/N");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //    bomComportamento = true;  CTRL + K + C 

           // bomComportamento = entrada == "S" || entrada == "s";

            bomComportamento = entrada.ToLower() == "s"; // nao precisa comparar se é maiusculo ou min.

            if (nota >= 8.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra");
            }





        }
    }
}
