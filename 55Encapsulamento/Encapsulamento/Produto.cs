using System;
using System.Globalization;

namespace Encapsulamento
{
    class Produto
    {
    private string _nome; //Por conversão de private a gente usa o "_"
    private double _preco;
    private int _quantidade;
 public Produto()
    {
    }
    public Produto(string nome, double preco, int quantidade) 
    {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
    }
        public string GetNome() //Usamos Get para obter o nome,no caso não vou poder imprimir no programa caso não fazer uso do Get,por ser private tenho que usar o get.
        //Criamos um metodo para retorna um nome
        {
            return _nome; 
        }
        public void SetNome(string nome)//Esse metodo não vai retorna nada como saída simplesmente vai alterar valor do nome
        {
            if(nome!=null && nome.Length > 1)
            {
                _nome = nome;
            }
           
        }
        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

    public double ValorTotalEmEstoque()
    {
        return _preco * _quantidade;
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
        _quantidade += quantidade;
    }
    public void RemoverProdutos(int quantidade)
    {
        _quantidade -= quantidade;
    }
    public override string ToString()
    {
        return _nome
        + ", $ "
        + _preco.ToString("F2", CultureInfo.InvariantCulture)
        + ", "
        + _quantidade
        + " unidades, Total: $ "
        + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
}
}