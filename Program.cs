using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClaasesEMetodos;

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
                {"Operadores Ternarios  - Fundamentos", OperadorTernario.Executar},
                // estruturas de controle
                {" Estrutura IF - Estrutura de Controle", EstruturaIf.Executar},
                {" Estrutura For - Estrutura de Controle", EstruturaFor.Executar},
                {" Estrutura ForEach - Estrutura de Controle", EstruturaForEach.Executar},
                {" Estrutura BREAK - Estrutura de Controle", EstruturaBreack.Executar},
                //Classes e Metodos
                {" Membros - Classes e Metodos", Membros.Executar},
                {" Construtores - Classes e Metodos", Construtores.Executar},
                {" Metodos com Retorno - Classes e Metodos", MetodosComRetorno.Executar},
                {" Metodos Estaticos - Classes e Metodos", MetodosEstaticos.Executar},
                {" Atributos Estaticos - Classes e Metodos", AtributosEstaticos.Executar},
                {" Desafio Atributo - Classes e Metodos", DesafioAtributo.Executar},
                {" Params - Classes e Metodos", Params.Executar},
                {" Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Executar},
                {" GetSet - Classes e Metodos", GetSet.Executar},
                
            });

            central.SelecionarEExecutar();
        }
    }
}