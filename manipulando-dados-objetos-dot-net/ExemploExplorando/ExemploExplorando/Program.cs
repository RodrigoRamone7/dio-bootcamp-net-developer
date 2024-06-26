﻿using ExemploExplorando.Models;
using Newtonsoft.Json;
using System.Globalization;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("../../../arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto} - Preço: R${venda.Preco}");
}











/*List<Venda> listaVendas = new List<Venda>();
DateTime dataVenda = DateTime.Now;

Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataVenda);
Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataVenda);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("../../../arquivos/vendas.json", serializado);

Console.WriteLine(serializado);*/

/*int numero = 20;
bool ePar = false;

ePar = numero % 2 == 0;

Console.WriteLine($"O número {numero} é " + (ePar ? "par" : "ímpar"));*/

/*Pessoa pessoa1 = new Pessoa("Rodrigo", "Ramone");

(string nome, string sobrenome) = pessoa1;

Console.WriteLine($"{nome} {sobrenome}");*/

/*LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("../../../arquivos/arquivoLeitura.txt");

if (sucesso)
{
    //Console.WriteLine($"Quantidade de linhas do arquivo: {quantidadeLinhas}");
    foreach(string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}*/

/*//Tupla
(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Rodrigo", "Ramone", 1.7M);

ValueTuple< int, string, string, decimal> outroExemploTupla = (1, "Rodrigo", "Ramone", 1.7M);

var outroExemploTuplaCreate = Tuple.Create(1, "Rodrigo", "Ramone", 1.7M);

Console.WriteLine($"Id: {outroExemploTupla.Item1}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Altura}");
*/

/*Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("GO", "Goiás");
estados.Add("DF", "Distrito Federal");
estados.Add("BA", "Bahia");

foreach (var estado in estados)
{
    Console.WriteLine($"Chave: {estado.Key}, Valor: {estado.Value}");
}

Console.WriteLine("------------");

estados.Remove("BA");

foreach (var estado in estados)
{
    Console.WriteLine($"Chave: {estado.Key}, Valor: {estado.Value}");
}

Console.WriteLine("------------");

estados["DF"] = "Brasília";

foreach (var estado in estados)
{
    Console.WriteLine($"Chave: {estado.Key}, Valor: {estado.Value}");
}

Console.WriteLine("------------");

string chave = "BA";
Console.WriteLine($"Verificando o elemento: {chave}");
if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {estados[chave]}");
}
else
{
    estados.Add(chave, "Bahia");
}

foreach (var estado in estados)
{
    Console.WriteLine($"Chave: {estado.Key}, Valor: {estado.Value}");
}*/




/*//pilha

Stack<int> pilha = new Stack<int>();

pilha.Push(2);
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

foreach(int item in pilha)
{
    Console.WriteLine(item);
}*/

/*//FIla
Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);
fila.Enqueue(10);

foreach (int item in fila)
{
    Console.WriteLine(item);
}


Console.WriteLine($"Removendo elemento: {fila.Dequeue()}");

foreach (int item in fila)
{
    Console.WriteLine(item);
}*/

//new ExemploExcecao().Metodo1();

//Blocos try catch
/*
//string[] linhas = File.ReadAllLines("../../../arquivos/leitu/arquivo_Leitura.txt");


try
{
    string[] linhas = File.ReadAllLines("../../../arquivos/leitura/arquivo_Leitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro de leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genética. {ex.Message}");
}
finally
{
    Console.WriteLine("Chegou até aqui");
}*/


/*string dataString = "2022-04-17 18:00";\

bool sucesso = DateTime.TryParseExact(
    dataString,
    "yyyy-MM-dd HH:mm",
    CultureInfo.InvariantCulture,
    DateTimeStyles.None,
    out DateTime data);

if (sucesso)
{
    Console.WriteLine($"Convertido com sucesso!\nData: {data}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida.");
}*/


/*CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 82.40M;

Console.WriteLine(valorMonetario.ToString("N1"));

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;

Console.WriteLine(numero.ToString("##-##-##"));*/



/*string n1 = "10";
string n2 = "20";

string res = n1 + n2;

Console.WriteLine(res);*/



/*Pessoa pessoa1 = new Pessoa("Rodrigo", "Ramone");
pessoa1.Nome = "ROdrigo";
pessoa1.Sobrenome = "Ramone";

Pessoa pessoa2 = new Pessoa("João", "Vitor");
pessoa2.Nome = "João";
pessoa2.Sobrenome = "Vitor";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Curso de Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.AdicionarAluno(pessoa2);
cursoDeIngles.ListarAlunos();*/
