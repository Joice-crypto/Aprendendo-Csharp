using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumeros
    {
        public static void Executar()
        {
            double valor = 75.56;
            Console.WriteLine(valor.ToString("F1")); // so aparece a 1 casa decimal depois do ponto
            Console.WriteLine(valor.ToString("C")); // converte para moeda
            Console.WriteLine(valor.ToString("P")); // percentual
        }
    }
}
