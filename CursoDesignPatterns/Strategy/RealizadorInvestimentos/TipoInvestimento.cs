namespace CursoDesignPatterns.Strategy.RealizadorInvestimentos
{
    public interface TipoInvestimento
    {
        double Calcular(Conta conta);
    }
}
