using System;
namespace CursoDesignPatterns.Strategy.RealizadorInvestimentos
{
    public class Moderado : TipoInvestimento
    {
        private Random random;

        public Moderado() => this.random = new Random();

        public double Calcular(Conta conta)
        {
            if (random.Next(2) == 0)
                return conta.Saldo * 0.007;
            else
                return conta.Saldo * 0.025;
        }
    }
}
