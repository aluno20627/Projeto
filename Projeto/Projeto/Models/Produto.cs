using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Models
{
    public class Produto
    {
        public int ID { get; set; }

        public float Preco { get; set; }

        public string NomeProduto { get; set; }

        public string ImagemProd { get; set; }

        public string Descricao { get; set; }

        public int Stock { get; set; }

    }
}