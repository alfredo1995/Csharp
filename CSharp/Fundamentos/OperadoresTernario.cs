using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresTernario
    {
        public static void Executar()
        {
            var nota = 7.0;
            string resultado = nota >= 7.0 ? "aprovado" : "reprovado";

            Console.WriteLine(resultado);
        }
    }
}
