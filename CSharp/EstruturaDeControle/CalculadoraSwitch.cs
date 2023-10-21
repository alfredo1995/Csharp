using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class CalculadoraSwitch
    {

        public static void Executar()
        {

            Console.WriteLine("Avalie meu atendimento com uma nota de 1 a 5 ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Pessimo!");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim!");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Boa");
                    break;
                case 5:
                    Console.WriteLine("Otimo");
                    break;
                default:
                    Console.WriteLine("Nota Invalida");
                    break;

            }

            Console.WriteLine("Fim!");
        }
    }
}

