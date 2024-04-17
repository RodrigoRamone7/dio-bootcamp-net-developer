using ExemploFundamentos.Models;

Console.WriteLine("Digita uma letra");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    default:
        Console.WriteLine("Consoante");
        break;
}




//Estrutura if else
/*int quantidadeEmEstoque = 10;

int quantidadeCompra = 0;

bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida.");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada.");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
}*/

// Casting implicito
/*int a = 5;
double b = a;

int c = 5;
long d = c;

Console.WriteLine(b);*/


// cast - casting
/*int a = Convert.ToInt32("5");

Console.WriteLine(a);

int b = int.Parse("5");

Console.WriteLine(b);

string c = Convert.ToString(5);

Console.WriteLine(c);

int inteiro = 5;
string d = inteiro.ToString();

Console.WriteLine(d);*/



/* Operadores aritméticos
 
int a = 10;
int b = 20;

int c = a+ b;

c += 5;

Console.WriteLine(c);*/


/* Tipos de dados

string nome = "Rodrigo";
int idade = 29;

double altura = 1.75;

Console.WriteLine($"Meu nome é {nome}, tenho {idade} anos e {altura} de altura.");*/

/* Instanciando objeto

Pessoa usuario = new Pessoa();

usuario.Nome = "Rodrigo";
usuario.Idade = 29;
usuario.Apresentar();*/