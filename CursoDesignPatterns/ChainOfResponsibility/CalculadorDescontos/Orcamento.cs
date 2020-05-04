﻿using System.Collections.Generic;

namespace CursoDesignPatterns.ChainOfResponsibility.CalculadorDescontos
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public IList<Item> Itens { get; private set; }

        public Orcamento() => Itens = new List<Item>();

        public void AdicionarItem(Item item)
        {
            this.Itens.Add(item);
            this.Valor += item.Valor;
        }
        
    }
}