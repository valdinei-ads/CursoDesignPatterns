using System;
namespace CursoDesignPatterns.Strategy.CalculadorImpostos
{
    class Program
    {
        static void Main(string[] args)
        {
            var orcamento = new Orcamento(500);

            Imposto iss = new ISS();
            Console.WriteLine($"ISS: {iss.Calcular(orcamento)} ");

            Imposto icms = new ICMS();
            Console.WriteLine($"ICMS: {icms.Calcular(orcamento)} ");

            Imposto iccc = new ICCC();
            Console.WriteLine($"ICMS: {icms.Calcular(orcamento)} ");

            Console.ReadKey();
        }
    }
}
