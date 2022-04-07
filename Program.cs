using Microsoft.AspNetCore.Mvc;
using MinimalAPP.Models;
using MinimalAPP.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IPessoaService, PessoaService>();
builder.Services.AddSingleton<IProdutosService, ProdutosService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});


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


app.MapGet("/veiculo", () => "Veiculo do Get é um Gol");
app.MapPost("/veiculo", () => "Veiculo do Post é um Fiat");
app.MapDelete("/veiculo", () => "Veiculo do Delete é um Volkswagen");

app.MapGet("/produto",
    (IProdutosService service) =>
    {
        var produto = service.Get();
        return Results.Ok(produto);
    });

app.MapGet("/informaproduto",
    (string? nome, int? quantidade, IProdutosService service) =>
    {
        if(nome == null || quantidade == null)
        {
            return Results.BadRequest("Você deve informar nome e quantidade do produto!");
        }
        
        ProdutoModel? prod = service.Get(nome, quantidade);
        if(prod == null)
        {
            return Results.BadRequest($"O produto {nome} não existe no nosso banco de dados");
        }
        return Results.Ok(prod);
    });

app.Run();
