using System;
namespace CursoDesignPatterns.Strategy.RealizadorInvestimentos
{
    public class Conta
    {
        public double Saldo { get; private set; }

        public Conta(double saldo) 
            => Saldo = saldo;

        public void Depositar(double valor)
            => Saldo += valor;
    }
}
