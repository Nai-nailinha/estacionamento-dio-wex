using EstacionamentoApp.Services; // Importa o namespace onde está a classe Estacionamento

Console.OutputEncoding = System.Text.Encoding.UTF8; // Configura a codificação do console para aceitar acentuação e símbolos como R$

// Definindo os valores para o estacionamento...
decimal precoInicial = 5.00m;     // Valor fixo cobrado ao estacionar
decimal precoPorHora = 2.00m;     // Valor cobrado por hora adicional

var estacionamento = new Estacionamento(precoInicial, precoPorHora); // Cria uma instância da classe Estacionamento com os valores

bool exibirMenu = true; // Controla se o menu deve continuar sendo exibido

while (exibirMenu) //Loop principal (usado só quando o usuario escolher sair)
{
    Console.Clear();  // Limpa a tela a cada repetição do menu

    // Exibe as opções disponíveis no menu
    Console.WriteLine("Sistema de Estacionamento 🚗");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    Console.Write("\nEscolha uma opção: ");

    // Lê a opção digitada pelo usuário e executa o caso correspondente
    switch (Console.ReadLine())
    {
        case "1": // Solicita a placa do veículo e adiciona à lista
            Console.Write("Digite a placa do veículo: ");
            string placaEntrada = Console.ReadLine();
            estacionamento.AdicionarVeiculo(placaEntrada);
            break;

        case "2": // Solicita a placa do veículo a ser removido e calcula o valor
            Console.Write("Digite a placa do veículo para remover: ");
            string placaSaida = Console.ReadLine();
            estacionamento.RemoverVeiculo(placaSaida);
            break;

        case "3": // Lista todos os veículos cadastrados
            estacionamento.ListarVeiculos();
            break;

        case "4": // Encerra o loop e finaliza o programa
            exibirMenu = false;
            Console.WriteLine("Encerrando o sistema...");
            break;

        default: // Caso o usuário digite algo fora das opções válidas
            Console.WriteLine("Opção inválida.");
            break;
    }

    if (exibirMenu) // Pausa o sistema antes de voltar ao menu (se ainda não for encerrar)
    {
        Console.WriteLine("\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}
