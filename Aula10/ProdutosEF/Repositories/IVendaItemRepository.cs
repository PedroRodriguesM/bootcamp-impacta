using ProdutosEF.Models;

namespace ProdutosEF.Repositories
{
    interface IVendaItemRepository
    {
        void Salvar(VendaItem item);
    }
}
