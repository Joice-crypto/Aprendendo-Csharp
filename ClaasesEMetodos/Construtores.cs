using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClaasesEMetodos
{
    class carro
    {
        public string Nome;
        public string Marca;
        public int Ano;
    }

    class Construtores
    {
        public static void Executar()
        {
            var MeuCarro = new carro();
            MeuCarro.Nome = "Gol";
            MeuCarro.Marca = "N sei";
            MeuCarro.Ano = 2010;

            Console.WriteLine($" Meu carro é um {MeuCarro.Nome} da marca {MeuCarro.Marca}" +
                $" e ano {MeuCarro.Ano}");


        }
    }
}
