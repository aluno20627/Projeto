﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Models
{
    public class Clientes
    {
        public int ID { get; set; }

        public string NIF { get; set; }

        public string Nome { get; set; }

        public string Telemovel { get; set; }

        public string Morada { get; set; }

        public int CodPostal { get; set; }

    }
}