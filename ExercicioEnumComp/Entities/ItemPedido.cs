using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEnumComp.Entities
{
    class ItemPedido
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }

        public ItemPedido()
        {
        }

        public ItemPedido(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double Subtotal()
        {
            double subtotal = Preco * Quantidade;
            return subtotal;
        }

    }
}