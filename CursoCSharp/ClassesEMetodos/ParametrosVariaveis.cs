using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosVariaveis
    {
        public static void Recepcionar(params string[] pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }


        public static void Executar()
        {
            Recepcionar("Alfredo", "Tassia", "Moises");
        }   
       
    }
}
