namespace CursoDesignPatterns.ChainOfResponsibility.CalculadorDescontos
{
    public class DescontoMaiorQueQuinhentos : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Descontar(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
                return orcamento.Valor * 0.07;

            return Proximo.Descontar(orcamento);
        }
    }
}
