using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;


namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            //new instancia CentralDeExercicios( passsando Dictionary contendo chave <string , valor(action(void))>            
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                //{"string", Valor.Action}

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
                {" Programa - Estrutura Calculadora Switch ", CalculadoraSwitch.Executar},

                //Classes e Metodos (POO C#)
                {" Programa - Membros  ", Membros.Executar},
                {" Programa - Constrututores  ", Constrututores.Executar},
                {" Programa - Metodo com retorno - Calculadora Comum ", CalculadoraComRetorno.Executar},
                {" Programa - Metodo com GetSet", GetSet.Executar},
                {" Programa - Metodo Estatico ", MetodoEstatico.Executar},
                {" Programa - Metodo Propriedade ", Propriedade.Executar},
                {" Programa - Parametros Variaveis ", ParametrosVariaveis.Executar},
                {" Programa - Parametro Nomeado ", ParametroNomeado.Executar},
                {" Programa - Get Set  ", GetSet.Executar},
                {" Programa - Propriedades  ", Propriedade.Executar},
                {" Programa - Readonly  ", Readonly.Executar},
                {" Programa - Enumeracoes  ", Enumeracoes.Executar},
                {" Programa - Exemplo Struct  ", ExemploStruct.Executar}, 

                //coleções
                {" Programa - Exemplo array   ", Array1.Executar}, 
                {" Programa - Exemplo ColecoesArrayList", ColecoesArrayList.Executar},
                {" Programa - Exemplo ColecoesQueue   ", ColecoesQueue.Executar}, 
                {" Programa - Exemplo ColecoesStack   ", ColecoesStack.Executar}, 
                {" Programa - Exemplo ColecoesList   ", ColecoesList.Executar}, 
                {" Programa - Exemplo ColecoesDictionary   ", ColecoesDictionary.Executar}, 
                {" Programa - Exemplo Igualdade   ", Igualdade.Executar}, 

                //Orientação a Objetos
                {" Programa - Exemplo Abstract   ", Abstract.Executar}, 
                {" Programa - Exemplo Heranca   ", Heranca.Executar}, 
                {" Programa - Exemplo Polimorfismo   ", Polimorfismo.Executar}, 
                {" Programa - Exemplo Encapsulamento   ", Encapsulamento.Executar}, 
                {" Programa - Exemplo Interface   ", Interface.Executar}, 
                {" Programa - Exemplo Sealed   ", Sealed.Executar}, 
                {" Programa - Exemplo ConstrutorThis   ", ConstrutorThis.Executar}, 

                //Metodos e Funçoes
                {" Programa - Exemplo Delegate Função Anonima   ", DelegateFunAnonima.Executar}, 
                {" Programa - Exemplo DelegatesComoParametros   ", DelegatesComoParametros.Executar}, 
                {" Programa - Exemplo Exemplo Lambda   ", ExemploLambda.Executar}, 
                {" Programa - Exemplo LambdasDelegate   ", LambdasDelegate.Executar}, 
                {" Programa - Exemplo MetodosDeExtensao   ", MetodosDeExtensao.Executar}, 
                {" Programa - Exemplo UsandoDelegates   ", UsandoDelegates.Executar}, 

                //Exceções
                {" Programa - Exemplo PrimeiraExcecao   ", PrimeiraExcecao.Executar}, 
                {" Programa - Exemplo ExcecoesPersonalizadas   ", ExcecoesPersonalizadas.Executar}, 

                //API
                {" Programa - Exemplo Primeiro Arquivo   ", PrimeiroArquivo.Executar},
                {" Programa - Exemplo Lendo Arquivos   ", LendoArquivos.Executar},
                {" Programa - Exemplo Diretorios   ", Diretorios.Executar},
                {" Programa - Exemplo DateTime   ", ExemploDateTime.Executar},
                {" Programa - Exemplo DirectoryInfo   ", ExemploDirectoryInfo.Executar},
                {" Programa - Exemplo FileInfo   ", ExemploFileInfo.Executar},
                {" Programa - Exemplo ExemploPath   ", ExemploPath.Executar},
                {" Programa - Exemplo TimeSpan   ", ExemploTimeSpan.Executar},

                //Topicos Avançados
                {" Programa - Exemplo Dynamics   ", Dynamics.Executar},
                {" Programa - Exemplo Genericos   ", Genericos.Executar},
                {" Programa - Exemplo LINQ1   ", LINQ1.Executar},
                {" Programa - Exemplo LINQ2   ", LINQ2.Executar},
                {" Programa - Exemplo Nullables   ", Nullables.Executar},

            });

            //chamando o central de exercicio .Seleciona metodo de instancia pra executar
            central.SelecionarEExecutar();
        }
    }
}