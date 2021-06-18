using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar() {
            //criar variavel filmes recebendo a instancia . Dictionary = chave, valor
            var filmes = new Dictionary<int, string>();

            //adicionando intem na variavel filmes
            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            //metodo para saber se esta [contido na coluna das chaves]
            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2004: " + filmes[2004]);
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004));
            }

            //metodo para saber se esta contido na coluna dos valores
            Console.WriteLine(filmes.ContainsValue("Amnésia"));
            //metodo para remover intem contido na coluna dos valores
            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            //metodo para pegar o valor passando a chave
            filmes.TryGetValue(2016, out string filme2006);
            Console.WriteLine($"Filme {filme2006}!");

            //pecorrer os intens da variavel chave com respectivos valores da chave da variavel filmes
            foreach (var chave in filmes.Keys) {
                Console.WriteLine(chave);
            }

            foreach (var valor in filmes.Values) {
                Console.WriteLine(valor);
            }

            foreach (KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }

            foreach (var filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }
        }
    }
}
