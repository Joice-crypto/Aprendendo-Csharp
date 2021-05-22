using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClaasesEMetodos
{
    class CalculadoraComum
    {
        public int Somar(int a , int b)
        {
            return a + b;
        }

        public int Subtrair(int a , int b)
        {
            return a - b;
        }
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
        public int Dividir(int a, int b)
        {
            return a / b;
        }
    }

    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadora = new CalculadoraComum();
            var resultado = calculadora.Somar(3 , 5);

            Console.WriteLine(resultado);
        }
    }
}
