using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionaisBoleanos
    {
        public static void Executar()
        {
            double nota = 6.0;
            double notaDeCorte = 7.0;

            //Notas aprovadas

            Console.WriteLine("nota invalida? {0}", nota > 10.0);
            Console.WriteLine("nota invalida? {0} ", nota < 0.0);
            Console.WriteLine("perfeito?  {0}", nota == 10.0);
            Console.WriteLine("tem como melhorar ? {0} ", nota != 10.0);
            Console.WriteLine("passou po media ? {0} ", nota >= notaDeCorte);
            Console.WriteLine("Recuperação ?  {0}", nota < notaDeCorte);
            Console.WriteLine("Reprovado ? {0} ", nota <= 3.0);

        }
    }
}
