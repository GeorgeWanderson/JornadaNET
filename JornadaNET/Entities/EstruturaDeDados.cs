using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JornadaNET.Entities
{
    public class EstruturaDeDados
    {
        public static void ExibirAulaDeEstruturaDeDados()
        {
            var matriz = new int[5] { 0, 1, 2, 3, 4 };

            var matrizV2 = new int[5];
            matrizV2[0] = 1;
            matrizV2[1] = 2;
            matrizV2[2] = 3;
            matrizV2[3] = 4;
            matriz[4] = 5;

            Console.WriteLine(matrizV2[3]);

            var lista = new List<int> { 0, 1, 2, 3, 4 };
            var listaV2 = new List<int>();
            listaV2.Add(0);
            listaV2.Add(1);
            listaV2.Add(2);
            listaV2.Add(3);
            listaV2.Add(4);

            var maiorQue2 = lista.Where(n => n > 2);
            foreach(var numero in maiorQue2)
            {
                Console.WriteLine(numero);
            }

            var sum = lista.Sum();
            var media = lista.Average();
            var max = lista.Max();
            var min = lista.Min();

            Console.WriteLine($"Soma: {sum}");
            Console.WriteLine($"Media: {media}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
        }
    }
}
