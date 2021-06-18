using System;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    class ColecoesArrayList
    {
        public static void Executar() {
            //array list com tipos de dados heterogeneos
            var arraylist = new ArrayList {
                "Palavra",
                3,
                true
            };

            //adicionanado valor boleando
            arraylist.Add(3.14);

            //arraylist.Count

            //percorrer todos os elementos do array list
            foreach (var item in arraylist) {
                // 0 e 1, apontando p/ intm, item.GetType
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}
