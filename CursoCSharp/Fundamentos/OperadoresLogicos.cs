using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2; // e 
            Console.WriteLine("Comprou a Tv 50? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2; // ou 
            Console.WriteLine("Comprou o soverte? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2; // se um ou outro 
            Console.WriteLine("Comprou a Tv 32? {0}", comprouTv32);

            var comprouTv60 = executouTrabalho1 ^ executouTrabalho2; //  negação logica
            Console.WriteLine("Comprou a Tv 35? {0}", !comprouTv60);

            var comprouSorvete2 = executouTrabalho1 || executouTrabalho2; // ou 
            Console.WriteLine("Comprou a soverte 2? {0}", comprouSorvete2);


        }
    }
}
