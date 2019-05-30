using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        //FK para os Clientes
        [ForeignKey("Cliente")]   //palavra reservada, tem de se por a biblioteca using....
        public int ClienteFK { get; set; }
        public virtual Clientes Viatura { get; set; }

        //FK para os Exemplares
        [ForeignKey("Exemplar")]   //palavra reservada, tem de se por a biblioteca using....
        public int ExemplarFK { get; set; }
        public virtual Exemplares Exemplar { get; set; }

        //FK para o Funcionario
        [ForeignKey("Funcionario")]   //palavra reservada, tem de se por a biblioteca using....
        public int FuncionarioFK { get; set; }
        public virtual Funcionarios Funcionario { get; set; }




    }
}