﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaBreack
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 10);

            Console.WriteLine($"O numero que queremos é: {numero}");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"O numeros que queremos é o {i}?");

                if(i == numero)
                {
                    Console.WriteLine("Sim");
                    break;

                }else
                {
                    Console.WriteLine("Não");
                }
            }

            Console.WriteLine("Chegamos ao fim!!!");


        }

    }
}
