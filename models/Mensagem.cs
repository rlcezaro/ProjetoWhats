namespace ProjetoWhats.Models
{
    public abstract class Mensagem
    {
        public Contatinho Destinatario { get; set; }
        public string HoraEnvio { get; set; }
        public string Conteudo { get; set; }

        public Mensagem(Contatinho destinatario, string horaEnvio, string conteudo)
        {
            Destinatario = destinatario;
            HoraEnvio = horaEnvio;
            Conteudo = conteudo;
        }

        public override string ToString()
        {
            return $"Para: {Destinatario.Nome}, Hora: {HoraEnvio}, Conteúdo: {Conteudo}";
        }
    }
}
