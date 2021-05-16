using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            double raio = 4.5; // variavel para numeros quebrados
            const double PI = 3.14; // define uma constante ou sejna nao pode ser alterada

            raio = 5.5;
            double area = PI * raio * raio;
            Console.WriteLine("A area é " + area);

            /*Variaveis numericas
             * byte (1 unico byte)
             * short (2 bytes)
             * int (4 bytes)
             * long (8 byte)
             */


        }
    }
}
