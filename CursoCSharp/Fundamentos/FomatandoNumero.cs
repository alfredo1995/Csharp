using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class FomatandoNumero
    {
        public static void Executar()
        {
            //convertendo o valor
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));    // 15,2
            Console.WriteLine(valor.ToString("C"));     // Celsius  
            Console.WriteLine(valor.ToString("P"));     // porcentagem
            Console.WriteLine(valor.ToString("P"));     // porcentagem

        }
    }
}
