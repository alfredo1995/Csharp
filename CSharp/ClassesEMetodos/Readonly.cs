using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Readonly
    {
        public class Client
        {
            //criando atributos, definindo tipo e visibilidade
            public string Nome;
            readonly DateTime Nascimento;

            //setar os atributos acima
            public Client (string nome, DateTime nascimento)
            {
                Nome = nome;
                Nascimento = nascimento;
            }

            //retornando os atirbutos setados acima
            public string GetDataDeNascimento()
            {
                return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
            }
        }

        public static void Executar()   
        {
            //criar instacia = recebendo o objeto e seus (atributos como parametro) 
            var novoClient = new Client("Alfredo", new DateTime(1995, 1, 25 ));

            Console.WriteLine(novoClient.Nome);
            Console.WriteLine(novoClient.GetDataDeNascimento());
        }   
    }
}
