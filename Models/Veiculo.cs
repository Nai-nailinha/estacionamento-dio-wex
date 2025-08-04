namespace EstacionamentoApp.Models
{
    public class Veiculo
    {
        public string Placa { get; set; } //Placa do veículo

        public Veiculo(string placa)
        {
            Placa = placa.ToUpper(); // Normaliza a placa para maiúsculas
        }
    }
}
