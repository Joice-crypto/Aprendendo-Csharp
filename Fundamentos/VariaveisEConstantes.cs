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
             * byte (1 unico byte) so numeros positivos
             * sbyte(1 unico byte) numeros negativos e positivos
             * short (2 bytes)
             * int (4 bytes)
             * long (8 byte)
             */

            byte idade = 45; // o byte nao tem sinal se quiser usar o sinal usa o sbyte
            Console.WriteLine("A idade é " + idade);
            sbyte idadeNegativo = -45;
            Console.WriteLine("Essa é a idade " + idadeNegativo);

            short salario = short.MaxValue;
            Console.WriteLine(salario);

            int MenorValor = int.MaxValue; // o int é o mais usado dos inteiros
            Console.WriteLine("Este é o int o mais usado" + MenorValor);

            float preco = 127.58f; // tem que colocar o f no final do numero
            Console.WriteLine("O preço é " + preco);

            char letra = 'a'; // so aspas simples
            Console.WriteLine("esse é o char " + letra);

            string frase = "Essa é uma string";
            Console.WriteLine(frase);


        }
    }
}
