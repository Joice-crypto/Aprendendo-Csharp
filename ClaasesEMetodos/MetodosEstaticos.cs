using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClaasesEMetodos
{
    public class CalculadoraEstatica
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
        
    }


    class MetodosEstaticos
    {
           public static void Executar()
        {
            var resultado = CalculadoraEstatica.Somar(2, 6);
            Console.WriteLine($" O resultado é {resultado}");

            // QUANDO COLOCA STATIC EM UM METODO NAO PRECISA MAIS FAZER 
            //resultado = new CalculadoraEstatica(); 
            //PODE CHAMAR DIRETO

            var resultado2 = new CalculadoraEstatica();  // isso é nao estatico
            Console.WriteLine(resultado2.Multiplicar(14, 5));
        }

    }
}
