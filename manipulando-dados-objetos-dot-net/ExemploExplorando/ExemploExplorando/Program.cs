using ExemploExplorando.Models;
using System.Globalization;

string dataString = "2022-04-17 18:00";

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
}





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
