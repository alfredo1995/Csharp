using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //primeiro define o tipo da variavel = double (casas dicimais )
            //seguido do nome da variavel raio 
            // Atribuindo = recebe valores do tipo double 4.5;

            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);


            // numeros boleans 

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            // numeros inteiros 

            byte idade = 45;
            Console.WriteLine("idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols" + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario" + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("Total de habitantes" + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long" + menorValorLong);

            ulong pouplulacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial" + pouplulacaoMundial);

            //pontos flutuantes - Tipo reais

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do Computador" + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000;
            Console.WriteLine("Valor de Mercado da Apple" + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre as estrelas" + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Uma unica letra" + letra);

            string texto = "Uma cadeia de caracteres";
            Console.WriteLine("Uma cadeia de caracteres" + texto);



            
        }
    }
}   
