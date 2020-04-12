using System;
using System.Globalization;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            /*São definições de métodos encapsulados,porém expondo uma sintaxe similiar á de atributos e não métodos
             •Uma propriedade é um membro que oferece um mecanismo flexível para ler,gravar
             ou calcular o valor de um campo particular.AS Propriedades podem ser usadas como se fossem atributos públicos,
             mas na verdade elas são métodos especiais chamados "acessadores".Isso permite que os dados seham acessados facilmente
             e ainda ajuda a promover a segurança e a flexibilidade dos métodos.*/

            Produto p = new Produto("TV", 500.00, 10);
            //p.SetNome("Tv4000k");
            p.Nome= "tv40000k";
            //Console.WriteLine(p.GetNome()); Na linha de baixo ficou mais simples a chamada
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco); //Aqui também facilitou programa
        }
    }
}
