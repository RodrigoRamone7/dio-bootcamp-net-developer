using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp();

int n1 = 5;
int n2 = 10;

Console.WriteLine($"{n1} + {n2} = {c.Somar(n1, n2)}");