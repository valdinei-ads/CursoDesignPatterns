using System;
using System.Linq;

namespace CursoDesignPatterns.ChainOfResponsibility.CalculadorDescontos
{
    public class DescontoPorVendaCasada:Desconto
    {
        public Desconto Proximo { get; set; }

        public double Descontar(Orcamento orcamento)
        {
            if (Existe("LAPIS", orcamento) && Existe("CANETA", orcamento))
                return orcamento.Valor * 0.05;

            return 0;
        }

        private bool Existe(string nomeDoItem, Orcamento orcamento)
            => orcamento.Itens
                        .Where(item => item.Nome.Contains(nomeDoItem, StringComparison.CurrentCultureIgnoreCase))
                        .Count() > 0;
    }
}
