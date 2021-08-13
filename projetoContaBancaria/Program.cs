﻿using System;
using System.Globalization;

namespace projetoContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o numero da conta: ");

            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");

            string titular = Console.ReadLine();

            Console.Write("Hávera deposito inicial(S/N)? ");

            Char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor do deposito: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre com o valor do deposito");
            double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre com o valor do saque");
             quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta);

        }   
        

    }
}
