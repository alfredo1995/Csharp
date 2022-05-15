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
            //1° FONTE DE DADOS
            var alunos = new List<Aluno> {
                new Aluno() {Nome = "Pedro", Idade = 24, Nota = 8.0 },
                new Aluno() {Nome = "Andre", Idade = 21, Nota = 4.3 },
                new Aluno() {Nome = "Ana", Idade = 25, Nota = 9.5 },
                new Aluno() {Nome = "Jorge", Idade = 20, Nota = 8.5 },
                new Aluno() {Nome = "Ana", Idade = 21, Nota = 7.7 },
                new Aluno() {Nome = "Julia", Idade = 22, Nota = 7.5 },
                new Aluno() {Nome = "Marcio", Idade = 18, Nota = 6.8 }
            };
            
            // 2° CRIANDO MINHA CONSULTA LINQ
            Console.WriteLine("== Aprovados ===============");
            var aprovados = alunos.Where(a => a.Nota >= 7)
                .OrderBy(a => a.Nome);

            // 3° EXECUTANDO MINHA CONSULTA
            foreach (var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);
            }

            // FIM :)
            
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
