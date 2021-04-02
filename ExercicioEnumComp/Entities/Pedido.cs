using System;
using System.Collections.Generic;
using System.Text;
using ExercicioEnumComp.Entities.Enums;
using System.Globalization;


namespace ExercicioEnumComp.Entities
{
    class Pedido
    {
        public DateTime Data { get; set; }
        public PedidoStatus PedStatus { get; set; }
        public Cliente Clientes { get; set; }
        public List<ItemPedido> ItemPedido { get; set; } = new List<ItemPedido>();

        public Pedido(DateTime data, PedidoStatus pedStatus, Cliente clientes)
        {
            Data = data;
            PedStatus = pedStatus;
            Clientes = clientes;
        }

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
                total += itemPedido.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("Order moment: " + Data.ToString("dd / mm / yyyy hh: mm: ss"));
            sb.AppendLine("Order status: " + PedStatus.ToString());
            Console.WriteLine("Cliente: " + Clientes);
            Console.WriteLine("Order items: ");
            foreach (ItemPedido item in ItemPedido)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: " + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();

        }

    }
}