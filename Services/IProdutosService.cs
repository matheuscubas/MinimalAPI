using MinimalAPP.Models;

namespace MinimalAPP.Services
{
    public interface IProdutosService
    {
        public ProdutoModel? Get();

        public ProdutoModel Get(string? nome, int? quantidade);
    }
}
