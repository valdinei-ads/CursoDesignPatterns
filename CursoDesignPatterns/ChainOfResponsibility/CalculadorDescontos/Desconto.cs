namespace CursoDesignPatterns.ChainOfResponsibility.CalculadorDescontos
{
    public interface Desconto
    {
        Desconto Proximo { get; set; }
        double Descontar(Orcamento  orcamento);
    }
}
