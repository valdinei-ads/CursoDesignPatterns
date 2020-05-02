namespace CursoDesignPatterns.Strategy.CalculadorImpostos
{
    public class ICCC : Imposto
    {
        public double Calcular(Orcamento orcamento)
        {
            double valorImposto = 0;

            if (orcamento.Valor < 1000)
                valorImposto = orcamento.Valor * 0.05;

            else if(orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
                valorImposto = orcamento.Valor * 0.07;

            else if (orcamento.Valor > 3000)
                valorImposto = (orcamento.Valor * 0.08) + 30;

            return valorImposto;
        }
    }
}
