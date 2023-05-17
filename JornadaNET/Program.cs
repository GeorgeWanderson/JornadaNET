using System;
using System.Globalization;

namespace JornadaNET
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Recursos básicos da lingaugem C#

            // Entrada e saída de dados | Concatenação.
            var nome = Console.ReadLine();
            var idade = Console.ReadLine();
            Console.WriteLine("Hello, " + nome + "! Você tem " + idade + "anos.");
            Console.WriteLine($"Hello, {nome}! Você tem {idade} anos.");
            Console.WriteLine("Hello, {0}! Você tem {1} anos.", nome, idade);

            var umaString = "Jornada .NET"; // string umaString = "Jornada .NET";
            var numeroInt = 5; // int numeroInt = 5;
            var numeroFloat = 5.4f; // float numeroFloat = 5.4f;
            var numeroDouble = 5.4; // double numeroDouble = 5.4;
            var numeroDecimal = 5.4m; // decimal numeroDecimal = 5.4m;
            var caractere = 'a'; // char caractere = 'a';
            var data = new DateTime(1991, 1, 1); // Ano | mês | dia
            var dataDehoje = DateTime.Now;

            Console.WriteLine(umaString);
            Console.WriteLine(numeroInt);
            Console.WriteLine(numeroFloat);
            Console.WriteLine(numeroDouble);
            Console.WriteLine(numeroDecimal);
            Console.WriteLine(caractere);
            Console.WriteLine(data);
            Console.WriteLine(dataDehoje);

           // Estruturas condicionais
            Console.WriteLine("Digite uma opção entre 1 e 3");
            var opcao = Console.ReadLine();

            Console.WriteLine("Utilizando a estrutura IF \n");
            if (opcao == "1")
            {
                Console.WriteLine("Opção 1 selecionada.");
            }
            else if (opcao == "2")
            {
                Console.WriteLine("Opção 2 selecionada.");
            }
            else if (opcao == "3")
            {
                Console.WriteLine("Opção 3 selecionada.");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }

            Console.WriteLine();
            Console.WriteLine("Com Switch:");
            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Opção 1 selecionada.");
                    break;
                case "2":
                    Console.WriteLine("Opção 2 selecionada.");
                    break;
                case "3":
                    Console.WriteLine("Opção 3 selecionada");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            // Estruturas de repetição
            var valores = "0 1 2 3 4 5";
            var numeros = valores.Split(' '); // [0, 1, 2, 3, 4, 5]

            Console.WriteLine("Repetição com for");
            for (var i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Repetição com while");
            var contador = 0;
            while (contador < numeros.Length)
            {
                Console.WriteLine(numeros[contador]);
                contador++;

            }

            // Sintaxe opcional: Foreach
            foreach(var numero in numeros)
            {
                Console.WriteLine(numero);
            }
            
            // Operador Ternário
            var opcaoEh3 = opcao == "3" ? "Sim" : "Não";
            Console.WriteLine(opcaoEh3);
        }
    }
}