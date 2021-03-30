using System;
using System.Collections.Generic;
using System.Text;
using ExercicioEnumComp.Entities.Enums;
using ExercicioEnumComp.Entities;


namespace ExercicioEnumComp.Entities
{
    class Pedido
    {
        public DateTime Data { get; set; }
        public PedidoStatus PedidoStatus { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemPedido> ItemPedido { get; set; }

        public void AddItem(ItemPedido itemPedido)
        {
            ItemPedido.Add(itemPedido);
        }
        public void RemoveItem(ItemPedido itemPedido)
        {
            ItemPedido.Remove(itemPedido);
        }

        public double Total()
        {
            double total = 0;
            foreach (ItemPedido itemPedido in ItemPedido)
            {
                total += itemPedido.Subtotal();
            }
            return total;
        }

    }
}