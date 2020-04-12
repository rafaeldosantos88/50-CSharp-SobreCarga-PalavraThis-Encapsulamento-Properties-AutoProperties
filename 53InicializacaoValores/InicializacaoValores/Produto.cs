using System;
using System.Globalization;

namespace InicializacaoValores
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()//Construtor padrão
        {

        }

        public Produto(string nome, double preco, int quantidade)//Construtor geralmente é depois dos atributos
        {

            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto(String nome, double preco)
        {     //Agora fazemos um outro construtor com 2 argumentos

            Nome = nome;
            Preco = preco;
            Quantidade = 5;
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