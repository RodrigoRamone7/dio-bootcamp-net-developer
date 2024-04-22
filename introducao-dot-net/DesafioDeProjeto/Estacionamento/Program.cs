using Estacionamento.Models;

Vagas estacionamento = new Vagas();

int precoInicial = 0;
int precoPorHora = 0;
int horasEstacionado = 0;
int valorTotal = 0;
string opcao;
bool exibirMenu = false;

bool op = true;
Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
do
{
    Console.WriteLine("Digite o preço inicial: ");
    precoInicial = Convert.ToInt32(Console.ReadLine());
    if (precoInicial <= 0)
    {
        Console.WriteLine("Valor inicial Inválido.");
    }
    else
    {
        op = false;
        Console.Clear();
    }
} while (op != false);

do
{
    op = true;
    Console.WriteLine("Digite o preço por hora: ");
    precoPorHora = Convert.ToInt32(Console.ReadLine());
    if (precoPorHora <= 0)
    {
        Console.WriteLine("Preço por hora Invalido.");
    }
    else
    {
        op = false;
        exibirMenu = true;
        Console.Clear();
    }
} while(op != false);





while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Cadastrar veículo");
            Console.WriteLine("Digite a placa do veículo: ");
            estacionamento.CadastraVeiculo(Console.ReadLine());
            break;
        case "2":

            Console.Clear();
            Console.WriteLine("Remover veículo");
            Console.WriteLine("Digite a placa do veículo: ");
            string placa = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
            horasEstacionado = Convert.ToInt32(Console.ReadLine());
            if(horasEstacionado == 0)
            {
                Console.WriteLine($"O veículo {placa} foi removido e preço total foi de: R$ {precoInicial}");
                estacionamento.RemoveVeiculo(placa);
                Console.ReadLine();
            } else if(horasEstacionado >= 1)
            {
                Console.WriteLine($"O veículo {placa} foi removido e preço total foi de: R$ {precoInicial + (precoPorHora * horasEstacionado)}");
                estacionamento.RemoveVeiculo(placa);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Quantidade de horas inválida.");
                Console.ReadLine();
            }
            break;
        case "3":
            Console.Clear();
            Console.WriteLine("Veículos estacionados");
            estacionamento.ListarVeiculos();
            Console.ReadLine();
            break;
        case "4":
            Console.Clear();
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Opção inválida");
            break;
    }
}
