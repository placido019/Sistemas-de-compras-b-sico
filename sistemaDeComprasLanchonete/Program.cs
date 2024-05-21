using System;
using System.Globalization;

namespace uri1038
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, (string, double)> produtos = new Dictionary<string, (string, double)>
            {
                {"cod1", ("Cachorro quente", 7.00) },
                {"cod2", ("X-Salada", 8.00) },
                {"cod3", ("X-bacon", 10.00) },
                 {"cod4", ("Torrada Simples", 5.00) },
                  {"cod5", ("Refri", 2.50) }
            };
            double total = 0; //Valor total dos itens

            Console.WriteLine("Seja bem vindo usuário ao sistema dde compras (Pressione enter para continuar)");
            Console.ReadLine();

            string resposta;

            do
            {

                Console.WriteLine("Selecione um produto pelo seu codigo (EXEMPLO: cod1, cod2...)");
                string codigo = Console.ReadLine().ToLower();

                if (produtos.ContainsKey(codigo))
                {
                    var produto = produtos[codigo];
                    Console.WriteLine($"Você selecionou: {produto.Item1} - valor de: {produto.Item2:F2}");
                    total += produto.Item2;
                }
                else
                {
                    Console.WriteLine("Código invalido. Por favor, insira um código valido.");
                }
                Console.WriteLine("Deseja adicionar mais algum item? (Sim/Não)");
                resposta = Console.ReadLine().Trim().ToLower();
            } while (resposta == "sim");


            Console.WriteLine($"Total a pagar sera de: R${total:F2}");
        }
    }
}