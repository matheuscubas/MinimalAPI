using MinimalAPP.Models;

namespace MinimalAPP.Repositories
{
    public static class ProdutosRepository
    {
        public static List<ProdutoModel> Produtos = new()
        {
            new() { Nome = "Nescau", Quantidade = 2 },
            new() { Nome = "Toddy", Quantidade = 1 },
            new() { Nome = "Nesquik", Quantidade = 0 },
            new() { Nome = "Leite em pó", Quantidade = 4 },
            new() { Nome = "Lata", Quantidade = 20 }
        };
    }
}