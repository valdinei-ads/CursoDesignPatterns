using System;
namespace CursoDesignPatterns.Strategy.RealizadorInvestimentos
{
    public class Arrojado : TipoInvestimento
    {
        private Random random;

        public Arrojado() => random = new Random();

        public double Calcular(Conta conta)
        {
            var valorObtido = random.Next(101);

            if (valorObtido <= 20)
                return conta.Saldo * 0.05;

            if (valorObtido <= 50)
                return conta.Saldo * 0.03;

            return conta.Saldo * 0.06;
        }
    }
}
