using System;
using System.Globalization;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            /* É um princípio que consiste em esconder detalhes de implementação de um componente,
             expondo apenas operações seguras e que o matenha em um estado consistente.
             •Regra de ouro:O objeto deve sempre estar em um estado consistente,e a própria classe deve garantir isso.
             •Todo atributo é definido como private.
             •implementa-se métodos Get(obter→Caso quero obter um valor de atributo Eu uso Get) e Set(definir→Defiinir alterar atributo) para cada atributo,conforme regras de negócios.
             •Nota:Não é usual na plataforma c#.*/

            Produto p = new Produto("TV", 500.00, 10);
            p.SetNome("Tv4000k");
            Console.WriteLine(p.GetNome());//No caso o nome tv vai ser alterado porque usamos set
            Console.WriteLine(p.GetPreco());//No caso vai obter o preço mais não vai poder ser alterado ,porque não temos set

        }
    }
}
