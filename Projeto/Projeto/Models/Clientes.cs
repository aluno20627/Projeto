using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projeto.Models
{
    public class Clientes
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string NIF { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Telemovel { get; set; }

        [Required]
        public string Morada { get; set; }

        [Required]
        public int CodPostal { get; set; }

      

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