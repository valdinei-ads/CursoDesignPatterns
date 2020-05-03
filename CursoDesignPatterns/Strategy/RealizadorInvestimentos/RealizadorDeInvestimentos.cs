using System;
namespace CursoDesignPatterns.Strategy.RealizadorInvestimentos
{
    public class RealizadorDeInvestimentos
    {
        public void ExecutarInvestimento(Conta conta, TipoInvestimento tipoInvestimento) {

            var resultadoInvestimentoSemImposto = tipoInvestimento.Calcular(conta);

            var resultadoInvestimentoComImposto = CalcularImposto(resultadoInvestimentoSemImposto);

            conta.Depositar(resultadoInvestimentoComImposto);

            Console.WriteLine($"O retorno do investimento sem o imposto { resultadoInvestimentoSemImposto }");
            Console.WriteLine($"O retorno do investimento com o imposto { resultadoInvestimentoComImposto }");
            Console.WriteLine($"O saldo depois do investimento com o imposto { conta.Saldo }");
        }

        private double CalcularImposto(double valorInvestido)
            => valorInvestido * 0.75;
    }
}
