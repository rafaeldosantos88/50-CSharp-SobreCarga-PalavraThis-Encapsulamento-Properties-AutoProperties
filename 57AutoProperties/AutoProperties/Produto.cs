using System;
using System.Globalization;

namespace AutoProperties
{
    class Produto
    {
        private string _nome; //Por conversão de private a gente usa o "_"
        //O nome não dá pra usar altoProperties porque tem uma logica particular,tem uma verficação se o valor não é nulo ou é maior que 1
        public double Preco { get; private set; } //No caso coloquei o private dizendo que esse preço não pode ser alterado
        public int Quantidade { get; private set; } //Posso usar prop + tab tab para facilitar .
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {// Nome d maiusculo na forma de propriedade
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value; //Quando não tenho definição do parametro de entrada ai uso value no lugar nome.Ou seja estaria ultilizando o parametro que chegaria no metodo set.
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
            /*Quando sua função retorna algum valor, repare que a própria chamada da função é um valor, 
             que pode ser atribuído a uma variável ou impresso na tela, por exemplo:
            
            double x = prod.ValorEmEstoque();
            Console.WriteLine("Valor = " + prod.ValorEmEstoque());

            Já uma função void significa que a chamada dela não é um valor, 
            mas sim apenas uma ação a ser executada, sem que ela retorne no final um valor no programa que chamou a função.
            Não faz sentido chamar funções void da forma mostrada acima*/
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
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}