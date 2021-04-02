using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

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

        public double SubTotal()
        {
            double subtotal = Preco * Quantidade;
            return subtotal;
        }


        public override string ToString()
        {
                  
        
            return Produto.NomeProduto
                + " , $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " , Quantidade: "
                + Quantidade
                + " , Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

        //ORDER SUMMARY:
        // Order moment: 20/04/2018 11:25:09
        //Order status: Processing
        //Client: Alex Green(15/03/1985) - alex @gmail.com
        //Order items:
        //TV, $1000.00, Quantity: 1, Subtotal: $1000.00
        //Mouse, $40.00, Quantity: 2, Subtotal: $80.00
        //Total price: $1080.00




    }
}