using MinimalAPP.Models;

namespace MinimalAPP.Repositories
{
    public static class PessoasRepository
    {
        public static List<PessoaModel> Pessoas = new()
        {
            new() { Nome = "Matheus", Idade = 25, Casado = false, TemFilhos = false },
            new() { Nome = "Guilherme", Idade = 20, Casado = false, TemFilhos = false },
            new() { Nome = "Jorge", Idade = 30, Casado = true, TemFilhos = true },
            new() { Nome = "Jorgina", Idade = 17, Casado= false, TemFilhos = true },
            new() { Nome = "Amy", Idade = 37, Casado= true, TemFilhos = false}
        };
    }
}
