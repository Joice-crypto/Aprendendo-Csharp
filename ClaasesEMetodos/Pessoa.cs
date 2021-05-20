using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClaasesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade; 

        public string Apresentar ()// vai retornar uma string 
        {
            return string.Format($"Olá me chamo  {Nome} e tenho {Idade} anos");

        }

        public void ApresentarNoConsole() // void nao retorna nada
        {
            Console.WriteLine(Apresentar());
        }
    }
}
