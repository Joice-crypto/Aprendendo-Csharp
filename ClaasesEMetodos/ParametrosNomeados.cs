using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClaasesEMetodos
{
    class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine($"{dia:D2}/{mes:D2}/{ano}"); // o D2 coloca um zero na frente do numero
        }

        public static void Executar()
        {
            Formatar(dia: 2, mes: 7, ano: 2001);
        }
    }
}
