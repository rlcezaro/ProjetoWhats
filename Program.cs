using ProjetoWhats.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        var whatsapp = new Whatsapp();

        var contato1 = new Contatinho("Alice", "123456789");
        var contato2 = new Contatinho("Bob", "987654321");

        whatsapp.Contatos.Add(contato1);
        whatsapp.Contatos.Add(contato2);

        var msgTexto = new MsgTexto(contato1, "10:00", "Olá, tudo bem?", 12);
        var msgAudio = new MsgAudio(contato2, "10:05", "Mensagem de áudio", 30);
        var msgFoto = new MsgFoto(contato1, "10:10", "Foto de viagem", 2048);

        whatsapp.Mensagens.Add(msgTexto);
        whatsapp.Mensagens.Add(msgAudio);
        whatsapp.Mensagens.Add(msgFoto);

        Console.WriteLine("Contatos:");
        whatsapp.ListarContatos();

        Console.WriteLine("\nMensagens:");
        whatsapp.ListarMensagens();
    }
}
