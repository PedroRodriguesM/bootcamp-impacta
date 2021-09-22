using ProdutosEF.Models;
using System.Linq;

namespace ProdutosEF.Repositories.Impl
{
    class UsuarioRepositoryImpl : IUsuarioRepository
    {
        private ProdutosEFDBContext _context;

        public UsuarioRepositoryImpl(ProdutosEFDBContext context)
        {
            _context = context;
        }

        public Usuario SelecionarPorId(int idUsuario)
        {
            return _context.Usuario.FirstOrDefault(usuario => usuario.Id == idUsuario);
        }
    }
}