using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto.Models
{
    public class Funcionarios
    {
        public int ID { get; set; }

        [Required]
        public string NomeFunc { get; set; }

        public string Telemovel { get; set; }

        public DateTime DataEntrada { get; set; }

        public string Morada { get; set; }
    }
}