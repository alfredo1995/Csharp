using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativaRestante = 5;
            int tentativas  = 0;

            while(tentativaRestante > 0 && !numeroEncontrado){
                Console.WriteLine("Insira seu palpite: ");
                string entrada = Console.ReadLine();

                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativaRestante--;

                if(numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    Console.WriteLine("{0}", tentativas);
                }else if(palpite > numeroSecreto)
                {
                    numeroEncontrado = true;
                    Console.WriteLine("{0}", tentativaRestante);
                }else
                {
                    Console.WriteLine("{0}", tentativaRestante);

                }
            }

        }
    }
}
