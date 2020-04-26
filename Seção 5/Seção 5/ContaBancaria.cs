using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_5 {
    class ContaBancaria {
        public string Nome { get; set; }
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string nome) {
            Numero = numero;
            Nome = nome;
        }

        public ContaBancaria(int numero, string nome, double depositoInicial) : this(numero, nome) {
            Deposito(depositoInicial);
        }

        public void Deposito(double deposito) {
            Saldo += deposito;
        }
        public void Saque(double saque) {
            Saldo -= saque + 5;
        }

        public override string ToString() {
            return "Conta: " + Numero + ", Titular: " + Nome + ", Saldo: R$" + Saldo.ToString("F2");
        }
    }
}
