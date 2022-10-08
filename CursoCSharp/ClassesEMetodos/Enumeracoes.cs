using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Enumeracoes
    {
        public enum Genero { Acao, Aventura, Terror, Animacao, Comedia};

        public class Filme
        {
            public string Titulo;
            public Genero GeneroDoFilme;
        }

        public static void Executar()
        {
            // cash - convert enum p/ int
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();

            filmeParaFamilia.Titulo = "Efeito Borboleta";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine("{0}{1}", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);            
        }
    }
}

//Uma das boas práticas de programação em C# é o uso do enum.
//A palavra-chave enum é usada para declarar uma enumeração,
//um tipo distinto que consiste em um conjunto de constantes. ...
//O Enum é um tipo de valor e não pode herdar ou ser herdado.
//usar-se String ou int para valores constantes.

//Enum tipo é a classe base abstrata de todos os tipos de enumeração.
//Ele fornece vários métodos para obter informações sobre um tipo de enumeração e seus valores.
