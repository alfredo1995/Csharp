using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    //class Membros criando Objetos que vai receber os atributos da classe do tipo Pessoa();
    class Membros
    {
        public static void Executar()
        {
            //instanciando primeiro objeto(desenvolvedor) nos atributos do tipe Pessoa
            Pessoa desenvolvedor = new Pessoa();

            //obejeto.instanciada os atributos da class pessoa = recebendo " os atributos instaciados " ;
            desenvolvedor.Nome = "Alfredo Gomes";
            desenvolvedor.Idade = 26;

            //Exibindo dados da ($"{objeto desenvolvedor.e suas respectivas atribuições instaciadas}"; //             
            Console.WriteLine($"{desenvolvedor.Nome}{desenvolvedor.Idade}");

            //segunda opção p/ exibir os metodos direto da $"{variavel desenvolvedor.contendo os atributos do primeiro metodo(comportamento)}"
            desenvolvedor.ApresentarNoConsole();

           
            //////////// instanciando segundo objeto(mentor) nos atributos do tipe Pessoa////////////////////

            Pessoa mentor = new Pessoa();
                        
            mentor.Nome = "Igor Brandão";
            mentor.Idade = 24;

            Console.WriteLine($"{mentor.Nome}{mentor.Idade}");



            //segundo opção de exibir no console
            var ApresentacaoDoMentor = mentor.Apresentacao();
            Console.WriteLine(ApresentacaoDoMentor);
        }
    }
}


// objeto criado partir de instancia usando metodo construtor new  - criar um objeto a partir de um tipo class