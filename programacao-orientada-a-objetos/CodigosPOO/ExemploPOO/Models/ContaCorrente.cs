using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    internal class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }

        private decimal saldo;

        public void Sacar (decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
            }
            else
            {
                Console.WriteLine("Valor desejado é maior que o saldo disponível");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo disponível é: R$ {saldo}");
        }
    }
}
