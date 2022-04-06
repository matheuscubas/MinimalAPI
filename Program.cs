using Microsoft.AspNetCore.Mvc;
using MinimalAPP.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IPessoaService, PessoaService>();
builder.Services.AddSingleton<IProdutosService, ProdutosService>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!"); // Aqui que cria-se os EndPoints Ex app.MapGet("/") pega um Get no root. 

app.MapGet("/pessoa",
    (IPessoaService service) =>
    {
        var pessoa = service.Get();
        return Results.Ok(pessoa);
    });

app.MapGet("/pessoas", (IPessoaService service) =>
    {
        var pessoas = service.List();
        return Results.Ok(pessoas);
    });

app.MapGet("/produto",
    ([FromServices] IProdutosService service) =>
    {
        var produto = service.Get();
        return Results.Ok(produto);
    });

app.MapGet("/veiculo", () => "Veiculo do Get é um Gol");
app.MapPost("/veiculo", () => "Veiculo do Post é um Fiat");
app.MapDelete("/veiculo", () => "Veiculo do Delete é um Volkswagen");

//app.MapGet(pattern: "/informaproduto{nome}", handler: (string nome) => $"O Parametro passado foi {nome}");  // aparentemente preciso de um controler pra essa route

app.Run();
