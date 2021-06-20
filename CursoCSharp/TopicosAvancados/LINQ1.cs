using System;
using System.Collections.Generic;
using System.Linq;

//Linq = consulta sql integrada na linguagem
namespace CursoCSharp.TopicosAvancados
{   
    //recebendo atributos do metodo executar da class LINQ1
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }

    class LINQ1
    {
        public static void Executar()
        {
            //setando a class aluno acima
            var alunos = new List<Aluno> {
                new Aluno() {Nome = "Pedro", Idade = 24, Nota = 8.0 },
                new Aluno() {Nome = "Andre", Idade = 21, Nota = 4.3 },
                new Aluno() {Nome = "Ana", Idade = 25, Nota = 9.5 },
                new Aluno() {Nome = "Jorge", Idade = 20, Nota = 8.5 },
                new Aluno() {Nome = "Ana", Idade = 21, Nota = 7.7 },
                new Aluno() {Nome = "Julia", Idade = 22, Nota = 7.5 },
                new Aluno() {Nome = "Marcio", Idade = 18, Nota = 6.8 }
            };

            Console.WriteLine("== Aprovados ===============");
            //Where(a => a.Nota >= 7) Lambda gerando uma nova lista filtrada com where(passando parametro de filtro)- OrderBy(ordem da lista)
            var aprovados = alunos.Where(a => a.Nota >= 7)
                .OrderBy(a => a.Nome);
            //varendo os atributos do objeto com foreach p/ exibir na tela
            foreach (var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("\n== Chamada ===============");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach (var aluno in chamada)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n== Aprovados (por Idade) ===============");
            //lista de Alunos - lista de string
            var alunosAprovados =
                from aluno in alunos
                //filtrando a exibição de alunos com nota >= 7
                where aluno.Nota >= 7
                //ordenando a lista aluno por idade
                orderby aluno.Idade
                //selecionando o aluno por nome = alunos transformado em string
                select aluno.Nome;

            //pecorrendo a lista de aluno para exibição 
            foreach (var aluno in alunosAprovados)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}