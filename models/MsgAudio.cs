namespace ProjetoWhats.Models
{
    public class MsgAudio : Mensagem
    {
        public int Duracao { get; set; }

        public MsgAudio(Contatinho destinatario, string horaEnvio, string conteudo, int duracao)
            : base(destinatario, horaEnvio, conteudo)
        {
            Duracao = duracao;
        }

        public override string ToString()
        {
            return base.ToString() + $", Duração: {Duracao} segundos";
        }
    }
}
