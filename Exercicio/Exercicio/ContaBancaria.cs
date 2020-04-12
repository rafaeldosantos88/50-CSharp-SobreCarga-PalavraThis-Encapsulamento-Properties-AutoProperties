using System;
using System.Globalization;


namespace Exercicio
{
    class ContaBancaria{
        public int Numero { get; private set; } //Número da conta não fode ser alterado
        public string Titular { get; set; }//Não colocamos private porque as vezes a pessoa pode mudar de nome
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular) //Construtor com 2 argumentos
        {
            Numero = numero;
            Titular = titular;
            
        }
        public ContaBancaria(int numero, string titular,Double depositoInicial) : this(numero, titular) //Usei o this para fazer o reaproveitamento This
        {
            Deposito(depositoInicial); //É melhor porque quem contem a lógica de deposito é operação Deposito abaixo
    

        }
        public void Deposito(double quantia)//Vai ser void porque não vai retorna uma saída.Simplesmente vai no saldo e na caixinha do saldo alterar valor dela.
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia; //Desconta quantia
            Saldo -= 5.0;     //Desconta Taxa.
        }



        public override string ToString()
        {
            return "Conta"
                + Numero
                + ",Titular: "
                + Titular
                + ",Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
