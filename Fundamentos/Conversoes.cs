using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int NotaQuebrada =(int) nota;
            Console.WriteLine(NotaQuebrada);

            Console.WriteLine("Digite sua idade: ");
            string idade = Console.ReadLine();
           int idadeN = int.Parse(idade);
          //  Console.WriteLine(idadeN);

            idadeN = Convert.ToInt32(idade);
            Console.Write(idadeN); 

        }
    }
}
