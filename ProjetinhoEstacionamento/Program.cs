using ProjetinhoEstacionamento;

Console.WriteLine("Bem-Vindo ao estacionamento dos CodaRuim");
Console.WriteLine("----------------------------------------");
Console.WriteLine("--O valor inicial é de R$5 + R$3 a hora--\n");
Console.WriteLine("Você vai estacionar? S/N");
string? continua = Console.ReadLine();

string caminhoDoArquivo = "C:\\Users\\edson.cordeiro\\source\\repos\\ProjetinhoEstacionamento\\ProjetinhoEstacionamento\\PlacasArmazenadas.txt";
ManipuladorArquivoDeTexto manipuladorArquivo = new(caminhoDoArquivo);

if (continua == "S" || continua == "s")
{

    while (true)
    {
        Console.WriteLine("Escolha uma dasopções abaixo");
        Console.WriteLine("1 - Adicionar placa");
        Console.WriteLine("2 - Remover placa");
        Console.WriteLine("3 - Veículos estacionados");
        Console.WriteLine("4 - Sair");

        string? opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.WriteLine("Digite a placa que deseja adicionar");
                string? adicionarPlaca = Console.ReadLine();
                manipuladorArquivo.AdicionarStringAoArquivo(adicionarPlaca);
                Console.Clear();
                break;

            case "2":
                Console.WriteLine("Quanto tempo você ficou estacionado? ");
                int tempoEstacionado = Convert.ToInt32(Console.ReadLine());
                int valorAPagar;
                if (tempoEstacionado > 1)
                {
                    valorAPagar = 5 + (tempoEstacionado * 3);
                }
                else valorAPagar = 5;
                Console.WriteLine($"O valor a pagar é de: {valorAPagar}");
                Console.WriteLine("Digite aqui a placa que deseja remover");
                string? removerPlaca = Console.ReadLine();
                manipuladorArquivo.RemoverStringDoArquivo(removerPlaca);
                Console.Clear();
                break;

            case "3":
                manipuladorArquivo.ImprimirConteudoArquivo();
                Console.WriteLine("\n");
                break;

            case "4":
                Console.WriteLine("Sair");
                return;
            default:
                Console.WriteLine("Escolha uma opção válida");
                break;
        }

    }
}

if (continua == "N" || continua == "n")
{
    Console.WriteLine("Tudo bem então, estamos disponíveís caso deseje estacionar");
}
else
{
    Console.WriteLine("Opção Inválida");
}