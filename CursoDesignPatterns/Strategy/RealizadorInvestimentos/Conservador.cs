namespace CursoDesignPatterns.Strategy.RealizadorInvestimentos
{
    public class Conservador : TipoInvestimento
    {
        public double Calcular(Conta conta) => conta.Saldo * 0.008;
    }
}
