using System.Collections.Generic;

namespace CursoDesignPatterns.ChainOfResponsibility.CalculadorDescontos
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public IList<Item> Items { get; private set; }

        public Orcamento() => Items = new List<Item>();

        public void AdicionarItem(Item item)
        {
            this.Items.Add(item);
            this.Valor += item.Valor;
        }
        
    }
}