using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Constrututores
    {
        class carro
        {
            public string Modelo;
            public string Fabricante;
            public int Ano;                    
        }

        public static void Executar()
        {
            var carro1 = new carro();
            carro1.Modelo = "XXX ";
            carro1.Fabricante = "FERRAI ";
            carro1.Ano = 2021 ;

            Console.Write($"{carro1.Modelo}{carro1.Fabricante}{carro1.Ano}");           
        }
    }
}
