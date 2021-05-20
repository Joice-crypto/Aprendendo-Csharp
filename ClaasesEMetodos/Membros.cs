using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClaasesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa siclano = new Pessoa(); // pegou na classe Pessoa uma nova pessoa
                                           // e atribuiu a aela os dados a seguir
            siclano.Nome = "Joice";
            siclano.Idade = 19;

            //  Console.WriteLine($"{siclano.Nome} tem {siclano.Idade} anos");

            siclano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Edmilson";
            fulano.Idade = 45;

          Console.WriteLine( fulano.Apresentar());

        }
    }
}
        
        

