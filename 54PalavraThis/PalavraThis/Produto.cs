using System;
using System.Globalization;
namespace PalavraThis
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()//Construtor padrão
        {
            Quantidade = 10;

        }

        public Produto(string nome, double preco):this()//Fiz uma referência para aproveitar do construtro padrão
        {

            Nome = nome;
            Preco = preco;
         
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}