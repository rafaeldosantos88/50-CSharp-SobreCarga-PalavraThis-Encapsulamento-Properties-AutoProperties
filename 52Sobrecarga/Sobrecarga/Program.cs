using System;
using System.Globalization;

namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {//Sobrecarga É um recurso que uma classe possui de oferecer mais de uma operação com o mesmo nome,porém com diferentes listas de parametros.
         //Vamos criar um construtor opcional,o qual recebe apenas nome e preço do produto.A quantidade em estoque deste novo produto por padrão deverá então ser iniciada com valor zero.
         //Nota :É possível  inclui um  construtor padrão(sem parâmetros).



            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            Produto p = new Produto(nome, preco);//Agora aqui na instanciação fiz um construtor de 2 argumentos(nome,preco)
            Produto p2 = new Produto();//Agora aqui outra instaciação com construtor padrão qual criei na classe Produto

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
