using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {

        public static void Executar()
        {
            string name = "Notebook Gamer";
            var marca = "Dell";
            double preco = 5.800;

           // Console.WriteLine("O" + name + " da marca " + marca + "custa: " + preco);
            Console.WriteLine("O {0} da marca {1} custa: {2}", name, marca, preco);
            Console.WriteLine($"A marca {marca} é muito legal");
        }
    }
}
