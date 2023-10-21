using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            //preço com desconto 
            var preco = 1000.00;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("{0}", totalComDesconto);

            //IMC

            double peso = 91.2;
            double altura = 1.82;
            double IMC = peso / (altura * altura);

            Console.WriteLine("O valor do IMC é: " + IMC);

            //Numero par e impar

            int par = 26;
            int impar = 25;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);

        }
    }
}
