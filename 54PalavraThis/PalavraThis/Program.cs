using System;
using System.Globalization;

namespace PalavraThis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Palavra This é uma referência para o próprio objeto
            //Diferenciar atrubutos de variáveis local(Java)
            //Referenciar outro construtor  em um construtor
            //Passar o próprio objeto com argumento na chamada de um método ou construtor.

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Produto p = new Produto(nome, preco);
            Produto p2 = new Produto();

            Produto p3 = new Produto()//Aqui fiz uma inicialização com Valores
            {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 20
            };


            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}