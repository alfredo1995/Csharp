using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesSet
    {
        public static void Executar() {
            var livro = new Produto("Game of Throne", 49.9);
            
            //HashSet não e indexada como o list (não aceita repetições )
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10),
                new Produto("Poster", 10)
            };

            //UnionWith alterando o carrinho p/ ser uma uniao de um conjuto com uma lista
            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            // carrinho.RemoveAt(3);

            foreach (var item in carrinho) {
                // Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
            // Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
