using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "Olá ".ToUpper().Insert(3, " Bem Vindo!");
            Console.WriteLine(saudacao);

        }

    }
}
