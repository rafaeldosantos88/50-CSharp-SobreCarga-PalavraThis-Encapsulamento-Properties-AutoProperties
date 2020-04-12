using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do
        titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito
        inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua
        conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.
        Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado.Já
        o nome do titular pode ser alterado(pois uma pessoa pode mudar de nome por ocasião de casamento, por
        exemplo).
        Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger
        isso.O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque
        realizado, o banco cobra uma taxa de $ 5.00.Nota: a conta pode ficar com saldo negativo se o saldo não for
        suficiente para realizar o saque e / ou pagar a taxa.
        Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não
        informado o valor de depósito inicial.Em seguida, realizar um depósito e depois um saque, sempre
        mostrando os dados da conta após cada operação.*/

            ContaBancaria conta; //Instanciamento

            Console.Write("Entre com Número da conta:");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com Titular da conta:");
            string titular = Console.ReadLine();

            Console.WriteLine("Haverá deposito Inicial (s,n)?");
            char resp = char.Parse(Console.ReadLine());
            if(resp=='s' || resp== 'S'){
                Console.Write("Entre com valor de deposito inicial:");
                double depositoInciail = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero,titular,depositoInciail);  //Iniciamos nossa conta caso temos o saldo inicial

            }
            else
            {
                conta = new ContaBancaria(numero, titular);//Repare que no parametro não tem deposito incial caso não queremos iniciar com um valor.
            //Ou seja  esse construtor vai jogar saldo zero na minha conta
            }

            Console.WriteLine();

            Console.WriteLine("Dados da Conta");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entra com um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);

            Console.WriteLine("Dados da Conta Atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entra com um valor para Saque: ");
             quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);

            Console.WriteLine("Dados da Conta Atualizados:");
            Console.WriteLine(conta);

        }
    }
}
