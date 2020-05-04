namespace CursoDesignPatterns.ChainOfResponsibility.CalculadorDescontos
{
    public class Item
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }

        public Item(string nome, double Valor) {
            this.Nome = nome;
            this.Valor = Valor;
        }
    }
}