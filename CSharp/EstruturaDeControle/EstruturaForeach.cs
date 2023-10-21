using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaForeach
    {
        public static void Executar()
        {
            var palavra = "Opa! ";

            foreach(var letra in palavra)
            {
                Console.Write(letra);
            }

            var alunos = new string[] { "Emanuela", "Rotelo", "Quaresma" };

            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
