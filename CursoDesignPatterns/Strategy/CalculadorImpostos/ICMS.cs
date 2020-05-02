namespace CursoDesignPatterns.Strategy.CalculadorImpostos
{
    public class ICMS : Imposto
    {
        public double Calcular(Orcamento orcamento) => (orcamento.Valor * 0.5) + 50;
    }
}
