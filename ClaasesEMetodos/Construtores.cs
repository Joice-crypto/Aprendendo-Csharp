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

        public carro(string Nome, string Marca, int Ano)
        {
            this.Nome = Nome; // a variavel que esta com o this é a que se refere ao objeto primario
            this.Marca = Marca;
            this.Ano = Ano;



        }

        public carro()
        {

        }

    }

    class Construtores
    {
        public static void Executar()
        {
            // FORMAS DE FAZER 
            //JEITO 1
            var MeuCarro = new carro();
            MeuCarro.Nome = "Gol";
            MeuCarro.Marca = "N sei";
            MeuCarro.Ano = 2010;

            Console.WriteLine($" Meu carro é um {MeuCarro.Nome} da marca {MeuCarro.Marca}" +
                $" e ano {MeuCarro.Ano}");

            //JEITO 2
            var MeuCarro2 = new carro("Fusca" , "AAH", 2001);
            Console.WriteLine($"{MeuCarro2.Nome} {MeuCarro2.Marca} e {MeuCarro2.Ano}");

            // JEITO 3
            var MeuCarro3 = new carro()
            {
                Nome = "Fiat",
                Marca = "Uno",
                Ano = 2018
            };
            Console.WriteLine($"{MeuCarro3.Nome},{MeuCarro3.Marca},{MeuCarro3.Ano}");

        }
    }
}
