using System;
namespace CursoDesignPatterns.Strategy.RealizadorInvestimentos
{
    public class ProgramRealizadorInvestimentos
    {
       public static void Start()
       {
            var conta = new Conta(300);

            Console.WriteLine($"Valor Investido {conta.Saldo}");
            Console.WriteLine($"================================================");

            Console.WriteLine("Investimento Conservador");
            Console.WriteLine($"================================================");
            TipoInvestimento conservador = new Conservador();
            new RealizadorDeInvestimentos().ExecutarInvestimento(conta, conservador);

            Console.WriteLine("Investimento Moderado");
            Console.WriteLine($"================================================");
            TipoInvestimento moderado = new Moderado();
            new RealizadorDeInvestimentos().ExecutarInvestimento(conta, moderado);

            Console.WriteLine("Investimento Arrojado");
            Console.WriteLine($"================================================");
            TipoInvestimento arrojado = new Arrojado();
            new RealizadorDeInvestimentos().ExecutarInvestimento(conta, arrojado);

            Console.ReadKey();
        }
    }
}
