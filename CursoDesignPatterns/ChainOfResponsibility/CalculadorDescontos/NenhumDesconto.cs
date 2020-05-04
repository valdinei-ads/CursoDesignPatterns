namespace CursoDesignPatterns.ChainOfResponsibility.CalculadorDescontos
{
    public class NenhumDesconto : Desconto
    {
        public Desconto Proximo {  get; set; }

        public double Descontar(Orcamento orcamento) => 0;
    }
}
