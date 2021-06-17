using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//public static nao precisa criar um obejto pra executar os metodos
//public class define o obj // //a instancia e o processo usando o metodo construtor new pra defini o objeto

// com metodo static acesivel atraves da class             -  public static int Somar  / com metodo static
// sem metodo static acesivel a traves da instancia Objeto  -  public int Multiplicacao / sem metodo static   / metodo new

namespace CursoCSharp.ClassesEMetodos
{
    class MetodoEstatico
    {
        //com metodo static
        public class CalculadoraEstatica
        {
            public static int Multiplicacao(int a, int b)
            {
                return a * b;
            }
        }

        //sem metodo static
        public class CalculadoraEstatica2
        {
            public int Somar(int a, int b)
            {
                return a + b;
            }
        }
       
        public static void Executar()
        {
            //com metodo static
            var resultado = CalculadoraEstatica.Multiplicacao(2, 2);
            Console.WriteLine(resultado);

            //sem metodo static
            CalculadoraEstatica2 calc = new CalculadoraEstatica2();
            Console.WriteLine(calc.Somar(4, 4));  
        }
    }
}       
