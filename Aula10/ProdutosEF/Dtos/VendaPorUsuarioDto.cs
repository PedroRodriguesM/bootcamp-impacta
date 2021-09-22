using ProdutosEF.Models;
using System.Collections.Generic;

namespace ProdutosEF.Dtos
{
    class VendaPorUsuarioDto
    {
        public string Nome { get; set; }
        public int QtdDeVendas { get; set; }
        public decimal ValorToralVendas { get; set; }
        public ICollection<Venda> Vendas { get; set; }
    }
}
