using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnitario
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var num1 = 2;
            var num2 = 3;
            var boleano = true;

            Console.WriteLine(-valorNegativo);  // invertendo
            Console.WriteLine(!boleano);  // um unico operando

            num1++;
            Console.WriteLine(num1);  // um unico operando

            num2++;
            Console.WriteLine(num2);  // um unico operando



        }
    }
}
