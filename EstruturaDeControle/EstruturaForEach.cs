using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "Joice"; 

            foreach(var letra in palavra)//cada letra da var palavra vai ser alocada na var letra
            {
                Console.WriteLine(letra);
            }
        }
    }
}
