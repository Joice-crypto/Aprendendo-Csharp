using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClaasesEMetodos
{
    public class produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto;

        public produto (string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;

        }

        public produto()
        {

        }
        public double prodComDesconto()
        {
            return Preco - Preco * Desconto; 
        }

    }


    class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new produto("Caneta",1.50,0.2);
            var produto2 = new produto()
            {
                Nome = "borracha",
                Preco = 5.0,
         
            };
            produto.Desconto = 0.5;
            Console.WriteLine($"O preco com desconto do produto 1 é: {produto1.prodComDesconto()}");
            Console.WriteLine($"O preco com desconto do produto 2 é: {produto2.prodComDesconto()}");

        }
    }
}
