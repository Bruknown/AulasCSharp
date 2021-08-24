using System;
using System.Collections.Generic;
using System.Text;

namespace AulaExercicio2
{
    class ContaBanco
    {
        public int ContaId { get; private set; }

        public string ContaNome { get; set; }

        public double ContaSaldo { get; private set; }

        static double taxa = 5.00;

        public ContaBanco()
        {
        }

        public ContaBanco(int contaId, string contaNome, double contaSaldo)
        {
            ContaId = contaId;
            ContaNome = contaNome;
            Deposito(contaSaldo);
        }
        public ContaBanco(int contaId, string contaNome)
        {
            ContaId = contaId;
            ContaNome = contaNome;
            ContaSaldo = 0;
        }

        public void Deposito(double valor)
        {
            ContaSaldo += valor;
        }

        public void Saque(double valor)
        {
            ContaSaldo -= (valor + taxa);
        }

        public override string ToString()
        {
            return "Conta: "
            + ContaId
            + ", Titular: "
            + ContaNome
            + ", Saldo: $ "
            + ContaSaldo;
        }
    }
}
