using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication02.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }

        public virtual List<Venda> Vendas { get; set; }
    }
}