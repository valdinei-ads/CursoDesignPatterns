using System;
namespace CursoDesignPatterns.ChainOfResponsibility.CalculadorDescontos
{
    public class ProgramCalculadorDescontos
    {
        public static void Start()
        {
            Orcamento orcamento = new Orcamento();

            for (int cont = 0; cont < 2; cont++)
                orcamento.AdicionarItem(new Item("Caneta BIC", 1.0));

            for (int cont = 0; cont < 2; cont++)
                orcamento.AdicionarItem(new Item("Lapis", 10));

            Desconto descMaisCincoItens = new DescontoMaisCincoItens();

            Desconto descontoPorMaisDeQuinhentosReais = new DescontoMaiorQueQuinhentos();

            Desconto descontoVendaCasada = new DescontoPorVendaCasada();

            descMaisCincoItens.Proximo = descontoPorMaisDeQuinhentosReais;

            descontoPorMaisDeQuinhentosReais.Proximo = descontoVendaCasada;

            Console.WriteLine(descMaisCincoItens.Descontar(orcamento));

            Console.ReadKey();
        }
    }
}
