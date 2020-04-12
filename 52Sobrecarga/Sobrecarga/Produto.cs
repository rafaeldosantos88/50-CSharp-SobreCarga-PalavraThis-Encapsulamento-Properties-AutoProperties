using System;
using System.Globalization;

namespace Sobrecarga
{
    /*• Vamos criar um construtor opcional, o qual recebe apenas nome e
    preço do produto.A quantidade em estoque deste novo produto, por padrão, deverá então ser iniciada com o valor zero.
  • Nota: é possível também incluir um construtor padrão(semparâmetros)*/
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
        public Produto(String nome,double preco){     //Agora fazemos um outro construtor com 2 argumentos

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