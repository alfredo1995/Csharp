using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    public class Produto {
        public string Nome;
        public double Preco;
    }   

    class ColecoesList
    {
        public static void Executar() {
            var livro = new Produto("Game of Throne", 49.9);

            //List<armazendo dentro lista carrinho, atributos do tipo produto>
            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            //criando nova list comnbo com novos atributos
            var combo = new List<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10)
            };

            //adicionando conteudo de uma lista dentro de outra (combo -> carrinho )
            carrinho.AddRange(combo);
            //carrinho.Count. quantos elementos tem no objeto
            Console.WriteLine(carrinho.Count);

            carrinho.RemoveAt(3);

            //foreach varrendo a lista e imprimir todos os intens no console
            foreach (var item in carrinho) {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
