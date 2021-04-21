using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication02.Models
{
    public class Venda
    {
        public int VendaID { get; set; }
        public int ProdutoID { get; set; }
        public virtual Produto Produto { get; set; }
        public int ClienteID { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}