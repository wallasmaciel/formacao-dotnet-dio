using System.Globalization;
using Arquivos.models;
using Newtonsoft.Json;

// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = [];

// Venda v1 = new(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new(2, "Licença de software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("vendas.json", serializado);

// Console.WriteLine(serializado);
// --------------------------------------------------------------------------
// string conteudoArquivo = File.ReadAllText("vendas.json");
// List<Venda> lsitaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in lsitaVenda)
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm:ss")}");
// --------------------------------------------------------------------------
// var tipoAnonimo = new { Nome = "Wallas", Sobrenome = "Maciel", Altura = 1.60 };
// Console.WriteLine($"Olá meu nome é {tipoAnonimo.Nome} e meu sobrenome é {tipoAnonimo.Sobrenome} e tenho {tipoAnonimo.Altura} de altura.");
// --------------------------------------------------------------------------
// string conteudoArquivo = File.ReadAllText("vendas.json");
// List<Venda> lsitaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// var listaAnonimo = lsitaVenda.Select(x => new { x.Produto, x.Preco });
// foreach (var venda in listaAnonimo) 
//     Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// --------------------------------------------------------------------------
// MeuArray<int> arrayInteiro = new();
// arrayInteiro.AdicionarElementoArray(30);

// Console.WriteLine(arrayInteiro[0]);
// --------------------------------------------------------------------------
int numero = 20;
bool par = false;

par = numero.ehPar();

Console.WriteLine("O número " + numero + " é " + (par ? "par" : "ímpar"));