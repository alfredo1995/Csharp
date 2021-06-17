using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class GetSet
    {
        public class Moto
        {
            private string Marca;
            private string Modelo;

            public Moto(string marca, string modelo, int cilindrada)
            {
                Marca = marca;
                Modelo = modelo;
                //SetMarca(marca);
                //SetModelo(marca);

            }

            //construtor padrao para definir os metodos get e set
            public Moto() {              
            }

            //metodo Get para retornar valor (leitura)
            public string GetMarca()
            {
                return Marca;
            }

            //metodo Set para alterar a marcar 
            public void SetMarca(string marca)            {
                Marca =  marca;
            }

            //metodo Get para retornar valor (leitura)
            public string GetModelo()
            {
                return Modelo;
            }

            //metodo Set para alterar a marcar 
            public void SetModelo(string modelo)
            {
                Modelo = modelo;
            }
          
        }
        public static void Executar()
        {
            var moto1 = new Moto();
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
        }
    }
}
    