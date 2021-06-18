using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.Api;
using CursoCSharp.Excecoes;
using CursoCSharp.MetodosEFuncoes;


namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                // fundamentos 
                {" Programa - Fundamentos", PrimeiroPrograma.Executar},
                {" Programa - Comentario", Comentarios.Executar},
                {" Programa - Variaveis e Constantes", VariaveisEConstantes.Executar},
                {" Programa - Inferencia", Inferencia.Executar},
                {" Programa - Interpolação", Interpolacao.Executar},
                {" Programa - Notação Ponto", NotacaoPonto.Executar},
                {" Programa - Lendo Dados", LendoDadosConsole.Executar},
                {" Programa - Formatando Numero", FomatandoNumero.Executar},  
                {" Programa - Converteção", Conversao.Executar},
                {" Programa - Operadores", OperadoresAritmeticos.Executar},
                {" Programa - Operadores Relacionais Boleanos", OperadoresRelacionaisBoleanos.Executar},
                {" Programa - Operadores Logicos / Caso ", OperadoresLogicos.Executar},
                {" Programa - Operador de Atribuicao ", OperadorAtribuicao.Executar},
                {" Programa - Operadores Unitarios ", OperadoresUnitario.Executar},
                {" Programa - Operadores Ternarios ", OperadoresTernario.Executar},

                //estrutura de controle
                {" Programa - Estrutura if ", EstruturaIf.Executar},
                {" Programa - Estrutura if e else", EstruturaIfElse.Executar},
                {" Programa - Estrutura if, else e if", EstruturaIfElfeIf.Executar},
                {" Programa - Estrutura Switch", EstruturaSwitch.Executar},
                {" Programa - Calculadora Switch", CalculadoraSwitch.Executar},
                {" Programa - Estrutura While ", EstruturaWhile.Executar},
                {" Programa - Estrutura Do While  ", EstruturaDoWhile.Executar},
                {" Programa - Estrutura For  ", EstruturaFor.Executar},
                {" Programa - Estrutura Foreach ", EstruturaForeach.Executar},

                //Classes e Metodos (POO C#)
                {" Programa - Membros  ", Membros.Executar},
                {" Programa - Constrututores  ", Constrututores.Executar},
                {" Programa - Metodo com retorno - Calculadora Comum ", CalculadoraComRetorno.Executar},
                {" Programa - Metodo Estatico ", MetodoEstatico.Executar},
                {" Programa - Parametros Variaveis ", ParametrosVariaveis.Executar},
                {" Programa - Parametro Nomeado ", ParametroNomeado.Executar},
                {" Programa - Get Set  ", GetSet.Executar},
                {" Programa - Propriedades  ", Propriedade.Executar},
                {" Programa - Readonly  ", Readonly.Executar},
                {" Programa - Enumeracoes  ", Enumeracoes.Executar},
                {" Programa - Exemplo Struct  ", ExemploStruct.Executar}, 

                //coleções
                {" Programa - Exemplo array   ", Array1.Executar}, 
                //{" Programa - Exemplo array   ", ColecoesList.Executar}, 
                //{" Programa - Exemplo ColecoesArrayList", ColecoesArrayList.Executar}, 
                //{" Programa - Exemplo array   ", ColecoesSet.Executar}, 
                //{" Programa - Exemplo array   ", ColecoesQueue.Executar}, 
                //{" Programa - Exemplo array   ", Igualdade.Executar}, 
                //{" Programa - Exemplo array   ", ColecoesStack.Executar}, 

                //Orientação a Objetos
                {" Programa - Exemplo Abstract   ", Abstract.Executar}, 
                {" Programa - Exemplo Heranca   ", Heranca.Executar}, 
                {" Programa - Exemplo Polimorfismo   ", Polimorfismo.Executar}, 
                {" Programa - Exemplo Encapsulamento   ", Encapsulamento.Executar}, 
                {" Programa - Exemplo Interface   ", Interface.Executar}, 
                {" Programa - Exemplo Sealed   ", Sealed.Executar}, 
                {" Programa - Exemplo ConstrutorThis   ", ConstrutorThis.Executar}, 

            }); 
            

            central.SelecionarEExecutar();
        }
    }
}