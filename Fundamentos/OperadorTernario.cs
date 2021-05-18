using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar ()
        {
            var nota = 7.0;
            string resultado = nota >= 7.0 ? "Aprovado" : "Reprovado"; // se a nota for maior
            Console.WriteLine(resultado);                                           // ou igual a 7 vai ser aprovado se não reprovado
        }
    }
}
