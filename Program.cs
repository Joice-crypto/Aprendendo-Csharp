using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variavei e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação de Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumeros.Executar},
                {"Converções  - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos  - Fundamentos", OperadoresAritmeticos.Executar},
                {" Operadores Ternarios  - Fundamentos", OperadorTernario.Executar},
                // estruturas de controle
                {" Estrutura IF - Estrutura de Controle", EstruturaIf.Executar},
                {" Estrutura For - Estrutura de Controle", EstruturaFor.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}