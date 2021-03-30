﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEnumComp.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preço { get; set; }

        public Produto(string nome, double preço)
        {
            Nome = nome;
            Preço = preço;
        }
    }
}