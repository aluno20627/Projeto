using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Models
{
    public class Produto
    {
        public float Preco { get; set; }

        public string Tipo { get; set; }

        public int ID { get; set; }

        public string NomeProduto { get; set; }

        public string ImagemProd { get; set; }

        public DateTime Garantia { get; set; }
    }
}