using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        //atributos do tipo Pessoa
        public string Nome;
        public int Idade;

        //primeiro metodo(comportamento) do tipo Pessoa
        public string Apresentar()
        {
            //primeiro metodo(comportamento) retorna uma string
            return string.Format($"{Nome}{Idade}");
        }

        //segundo metodo(comportamento) do Tipo Pessoa - reaproveitando o primeiro metodo Apresentar()  
        public void ApresentarNoConsole()
        {
            //segundo metodo exibir os atributos do primeiro comportamento
            Console.WriteLine(Apresentar());
        }



        ////////////////////////////////////////////////////////////////
       
        public string Apresentacao()
        {
            return string.Format($"{Nome}{Idade}");
        }

        //segundo metodo p/ exibir retornado os dados do primeiro metodo
        public void ApresentacaoDoMentor()
        {
            Console.WriteLine(Apresentacao());
        }
    }
}
