using MinimalAPP.Models;
using MinimalAPP.Repositories;

namespace MinimalAPP.Services
{
    public class ProdutosService : IProdutosService
    {
        static Random rnd = new Random();

        public ProdutoModel? Get()
        {
            int r = rnd.Next(ProdutosRepository.Produtos.Count);    //devolve um produto aleatória do meu repositório de pessoas.
            var Produto = ProdutosRepository.Produtos[r];

            return Produto;
        }
    }
}