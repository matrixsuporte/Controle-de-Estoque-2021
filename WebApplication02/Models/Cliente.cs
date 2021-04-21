using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication02.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public virtual List<Venda> Vendas { get; set; }
    }
}