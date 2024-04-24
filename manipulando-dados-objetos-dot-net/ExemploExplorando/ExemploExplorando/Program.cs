using ExemploExplorando.Models;

Pessoa pessoa1 = new Pessoa("Rodrigo", "Ramone");
/*pessoa1.Nome = "ROdrigo";
pessoa1.Sobrenome = "Ramone";*/

Pessoa pessoa2 = new Pessoa("João", "Vitor");
/*pessoa2.Nome = "João";
pessoa2.Sobrenome = "Vitor";*/

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Curso de Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.AdicionarAluno(pessoa2);
cursoDeIngles.ListarAlunos();
