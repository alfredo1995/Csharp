using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        //function executar
        public static void Executar() {
            //var fila recebendo a instancia do Tipo string - Queue = fila
            var fila = new Queue<string>();

            //adicionar o intem na fila, enfilerados
            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Beltrano");

            //fila.Peek( pegar o primeiro elemento p/ exibir no console)
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            //pecorrendo os elementos de pessoa
            foreach(var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("Item"));
        }
    }
}
