using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEnumComp.Entities
{
    class Produto
    {
        public string NomeProduto { get; set; }
        public double Preco { get; set; }

        public Produto(string nomeProduto, double preco)
        {
            NomeProduto = nomeProduto;
            Preco = preco;
        }
    }
}