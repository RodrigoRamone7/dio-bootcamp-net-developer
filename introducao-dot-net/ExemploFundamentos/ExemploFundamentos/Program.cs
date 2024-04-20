using ExemploFundamentos.Common.Models;


//Removendo elemementos de listas
List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("GO");
listaString.Add("DF");
listaString.Add("BA");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");


listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("BA");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// Criando Listas
/*List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("GO");
listaString.Add("DF");
listaString.Add("BA");

for (int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
}*/

//Copiando arrays
/*int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Valor da posição {contador} é {arrayInteiros[contador]}");
}*/

//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


//Criando e percorrendo um array
/*int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Valor da posição {contador} é {arrayInteiros[contador]}");
}

int contadorForeach = 0;
foreach(int valor in arrayInteiros)
{
    Console.WriteLine($"Valor da posição {contadorForeach} é {arrayInteiros[contadorForeach]}");
    contadorForeach++;
}*/

//Exeplo de uso de classe de outro projeto de mesma solução
/*Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Rodrigo";
pessoa1.Idade = 29;
pessoa1.Apresentar();*/


//Exemplo de menu
/*string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.WriteLine("Digite a sua opção");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Bucar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("Busca de cliente");
            break;
        case "3":
            Console.Clear();
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.Clear();
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;
    }
}
Console.WriteLine("O programa encerrou.");*/




// Estrutura de repetição Do While
/*int numero = 5;
int contador = 0;

do
{
    int res = numero * contador;
    Console.WriteLine($"{numero} x {contador} = {res}");
    contador++;
} while (contador < 10);*/


// Estrutura de repetição while
/*int numero = 5;
int contador = 0;

while (contador <= 10)
{
    int res = numero * contador;
    Console.WriteLine($"{numero} x {contador} = {res}");
    contador++;
}*/


// Estrutura de repetição FOR
/*Tabuada tabuada4 = new Tabuada();
tabuada4.CalculaTabuada10(4);
tabuada4.CalculaTabuadaNVezes(4, 1000);*/


//Utilizando classe Calculadora
/*Calculadora calc = new Calculadora();

calc.Somar(5, 5);
calc.Subtrair(10, 50);
calc.Multiplicar(10, 50);
calc.Dividir(100, 50);
Console.WriteLine("--------");
calc.Potencia(3, 3);
Console.WriteLine("--------");
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
Console.WriteLine("--------");
calc.RaizQuadrada(9);*/



// Estrutura Switch case
/*Console.WriteLine("Digita uma letra");
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
}*/




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