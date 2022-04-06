using MinimalAPP.Models;

namespace MinimalAPP.Services
{
    public interface IPessoaService
    {
        public PessoaModel? Get(); //Pegar o priemiro da lista ou random se exisitr método para random
        public List<PessoaModel> List(); //Testar o GetAll dps
    }
}
