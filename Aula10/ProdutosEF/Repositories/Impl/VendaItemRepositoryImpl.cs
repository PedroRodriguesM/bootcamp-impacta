using ProdutosEF.Models;

namespace ProdutosEF.Repositories.Impl
{
    class VendaItemRepositoryImpl : IVendaItemRepository
    {
        private ProdutosEFDBContext _context;

        public VendaItemRepositoryImpl(ProdutosEFDBContext context)
        {
            _context = context;
        }

        public void Salvar(VendaItem item)
        {
            _context.VendaItem.Add(item);
            _context.SaveChanges();
        }
    }
}
