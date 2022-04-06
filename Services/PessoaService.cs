using MinimalAPP.Models;
using MinimalAPP.Repositories;

namespace MinimalAPP.Services
{
    public class PessoaService : IPessoaService
    {
        static Random rnd = new Random();

        public PessoaModel? Get()
        {
            int r = rnd.Next(PessoasRepository.Pessoas.Count);    //devolve uma pessoa aleatória do meu repositório de pessoas.
            var Pessoa = PessoasRepository.Pessoas[r];            

            //var Pessoa = PessoasRepository.Pessoas.First();     //Caso não desse certo devolve só a primeira.
            return Pessoa;
        }

        public List<PessoaModel> List()
        {
            var Pessoas = PessoasRepository.Pessoas;
            return Pessoas;
        }
    }
}
