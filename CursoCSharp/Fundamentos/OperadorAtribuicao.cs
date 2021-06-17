using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadorAtribuicao
    {
        public static void Executar()
        {
            // num1 = num1 + 10  

            var num1 = 3;
            num1 = 7;
            num1 += 10;      
            num1 -= 10;
            num1 *= 5;
            num1 /= 5;

            Console.WriteLine(num1);

            //

            int a = 1;
            int b = a;

            a++;
            b--;

            Console.WriteLine($"{a}{b}");

            //

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "alfredo";

            Console.WriteLine(c.nome);
        }
    }
}
