namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            if (string.IsNullOrWhiteSpace(tipoSuite))
                throw new ArgumentException("O tipo da su�te n�o pode ser vazio.");

            if (capacidade <= 0)
                throw new ArgumentException("A capacidade deve ser maior que zero.");

            if (valorDiaria <= 0)
                throw new ArgumentException("O valor da di�ria deve ser maior que zero.");

            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
    }
}