using System;

namespace AutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            /*É uma forma simplificada de se declarar propriedades que não necessitam lógicas particulares 
             para  operações get e set.
             */
            Produto p = new Produto("TV", 500.00, 10);
            //p.SetNome("Tv4000k");
            p.Nome = "tv40000k";
            //Console.WriteLine(p.GetNome()); Na linha de baixo ficou mais simples a chamada
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco); //Aqui também facilitou programa
        }
    }
}
