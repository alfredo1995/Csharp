using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComRetorno
    {
        public class CalculadoraComum
        {
            public int Somar(int a, int b)
            {
                return a + b;
            }

            public int Subtrair(int a, int b)
            {
                return a - b;
            }

            public int Multiplicar(int a, int b)
            {
                return a * b;
            }

            public int Dividir(int a, int b)
            {
                return a / b;
            }
        }
        public static void Executar()
        {
            // instanciando a variavel CalculadoraComum = recebendo o construtor com seus atributos 
            var CalculadoraComum = new CalculadoraComum();

            // variavel resultado = recebendo a variavel instanciada CalculadoraComum para (setar valores)
            var resultado = CalculadoraComum.Somar(5, 5);

            Console.WriteLine(resultado);

            Console.WriteLine(CalculadoraComum.Subtrair(5, 5));
            Console.WriteLine(CalculadoraComum.Multiplicar(5, 5));
            Console.WriteLine(CalculadoraComum.Dividir(5, 5));

        }
    }
}
