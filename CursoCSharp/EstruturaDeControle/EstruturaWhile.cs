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
            //
            int palpite = 0;
            // criar um valor aleatorio emcima da class Random
            Random random = new Random();

            // emcima de random e gerado um valor aleatorio
            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativaRestante = 5;
            int tentativas  = 0;

            //enquanto as tentativas for maior q 0 e não for encontrado o numero
            while(tentativaRestante > 0 && !numeroEncontrado){
                Console.WriteLine("Insira seu palpite: ");
                string entrada = Console.ReadLine();

                int.TryParse(entrada, out palpite);

                //incrementar e decrementar a quantidade de tentativas
                tentativas++;
                tentativaRestante--;

                if(numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    //interpolar o valor mostrando o resultado das tentativas
                    Console.WriteLine(" Numero encontrado em {0} tentativas", tentativas);
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
