using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoContaBancaria
{
    class ContaBancaria

    {
        public int Numero { get; set; }
        public string Titular { get; set; }

        public double Saldo { get; set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;

        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

            public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

            public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5.00;
        }
        public override string ToString()
        {
            return "conta: "
                + Numero
                + ",Titular: "
                + Titular
                + ",Saldo:$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

