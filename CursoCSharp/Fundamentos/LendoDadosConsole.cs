using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class LendoDadosConsole
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome?");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade?");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual e o seu salario?");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"{nome} {idade} {salario}");
            
        }
    }
}
