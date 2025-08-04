using EstacionamentoApp.Models;

namespace EstacionamentoApp.Services
{
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<Veiculo> veiculos = new();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo(string placa)
        {
            veiculos.Add(new Veiculo(placa));
            Console.WriteLine($"Veículo com placa {placa.ToUpper()} adicionado.");
        }

        public void RemoverVeiculo(string placa)
{
    var veiculo = veiculos.FirstOrDefault(v => v.Placa == placa.ToUpper());

    if (veiculo != null)
    {
        Console.Write("Informe o número de horas que o veículo permaneceu estacionado: ");
        if (int.TryParse(Console.ReadLine(), out int horas))
        {
            int horasAdicionais = Math.Max(horas - 1, 0); // Considera apenas as horas além da primeira
            decimal total = precoInicial + precoPorHora * horasAdicionais;

            veiculos.Remove(veiculo);
            Console.WriteLine($"Veículo removido. Valor a pagar: R$ {total:F2}");
        }
        else
        {
            Console.WriteLine("Valor inválido para horas.");
        }
    }
    else
    {
        Console.WriteLine("Veículo não encontrado.");
    }
}

        public void ListarVeiculos()
        {
            if (veiculos.Any()) // Verifica se há algum veículo na lista (usando .Any() do LINQ)
            {
                Console.WriteLine("Veículos estacionados:"); // Se houver veículos, mostra um cabeçalho
                foreach (var v in veiculos) 
                {
                    Console.WriteLine($"- {v.Placa}"); // Percorre a lista de veículos e imprime cada placa
                }
            }
            else
            {
                Console.WriteLine("Nenhum veículo estacionado."); // Se a lista estiver vazia, informa que não há veículos
            }
        }
    }
}
