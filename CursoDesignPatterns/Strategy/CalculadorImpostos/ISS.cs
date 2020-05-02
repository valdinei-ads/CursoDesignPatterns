namespace CursoDesignPatterns.Strategy.CalculadorImpostos
{
    public class ISS : Imposto
    {
        public double Calcular(Orcamento orcamento) => orcamento.Valor * 0.06;
    }
}
