namespace CursoDesignPatterns.ChainOfResponsibility.CalculadorDescontos
{
    public class DescontoMaisCincoItens : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Descontar(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
                return orcamento.Valor * 0.1;

            return Proximo.Descontar(orcamento);
        }
    }
}
