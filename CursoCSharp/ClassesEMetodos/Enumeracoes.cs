using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//entro na class e uso o enum pra ser uns do tipo de atributo dessa class
namespace CursoCSharp.ClassesEMetodos
{
    class Enumeracoes
    {
        //criando um tipo enum Genero 
        public enum Genero { Acao, Aventura, Terror, Animacao, Comedia};

        //criando um class q vai ter entre seus atributos o tipo enum
        public class Filme
        {
            public string Titulo;
            public Genero GeneroDoFilme;
        }

        //acessar o enum
        public static void Executar()
        {
            // cash - convert enum p/ int
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            ///criar variavel
            var filmeParaFamilia = new Filme();

            //setando atribuindo da variavel criada acima
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