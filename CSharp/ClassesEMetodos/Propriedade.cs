using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Propriedade
    {   //setar o construtudor criado
        public static void Executar()   {        }

        //criando class com atributos privados e publico
        public class CarroOpcional
        {
            double desconto = 0.1;            
            private string nome;

            //atribuir valor para a propriedade privada;
            public string Nome
            {
                get
                {
                    return "Opcional: " + nome;
                }
                set
                {
                    nome = value;
                }
            }

            //propriedades autoimplementada
            public double Preco {get; set; }

            //propriedade somente leitura
            public double PrecoComDesconto
            {
                get => Preco - (desconto * Preco);
            } 

        }        
    }
}
