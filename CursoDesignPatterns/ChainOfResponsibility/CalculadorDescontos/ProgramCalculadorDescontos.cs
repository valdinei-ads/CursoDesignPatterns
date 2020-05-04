using System;
namespace CursoDesignPatterns.ChainOfResponsibility.CalculadorDescontos
{
    public class ProgramCalculadorDescontos
    {
        public static void Start()
        {
            Orcamento orcamento = new Orcamento();

            for (int cont = 0; cont < 30; cont++)
                orcamento.AdicionarItem(new Item("Caneta BIC", 1.0));

            for (int cont = 0; cont < 3; cont++)
                orcamento.AdicionarItem(new Item("Caderno 30 materias", 10));

            Desconto descMaisCincoItens = new DescontoMaisCincoItens();

            descMaisCincoItens.Proximo = new DescontoMaiorQueQuinhentos();

            Console.WriteLine(descMaisCincoItens.Descontar(orcamento));

            Console.ReadKey();
        }
    }
}
