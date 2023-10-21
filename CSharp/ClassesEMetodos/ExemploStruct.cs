using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ExemploStruct
    {
        interface Ponto
        {
           void MoverNaDiagonal(int delta);
        }

        //criando struc
        struct Coordenada: Ponto
        {
            //atributo da struc
            public int X;
            public int Y;

            //construtor da struc
            public Coordenada(int x, int y)
            {
                X = x;
                Y = y;
            }

            //metodo da struc
            public void MoverNaDiagonal(int delta)
            {
                //atribuição aditiva
                X += delta;
                Y += delta;

            }
        }


        public static void Executar()
        {

        }
    }
}
