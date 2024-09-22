namespace ProjetoWhats.Models
{
    public class MsgTexto : Mensagem
    {
        public int NumChar { get; set; }

        public MsgTexto(Contatinho destinatario, string horaEnvio, string conteudo, int numChar)
            : base(destinatario, horaEnvio, conteudo)
        {
            NumChar = numChar;
        }

        public override string ToString()
        {
            return base.ToString() + $", Número de Caracteres: {NumChar}";
        }
    }
}
