using ProdutosEF.Dtos;
using ProdutosEF.Models;
using System.Collections.Generic;

namespace ProdutosEF.Repositories
{
    interface IVendaRepository
    {
        void Salvar(Venda venda);
        void Atualizar(Venda venda);
        List<VendaPorUsuarioDto> ObterVendasPorUsuario();
    }
}
