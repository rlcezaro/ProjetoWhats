using System;
using System.Collections.Generic;

namespace ProjetoWhats.Models
{
    public class Whatsapp
    {
        public List<Contatinho> Contatos { get; set; } = new List<Contatinho>();
        public List<Mensagem> Mensagens { get; set; } = new List<Mensagem>();

        public void ListarContatos()
        {
            foreach (var contato in Contatos)
            {
                Console.WriteLine($"Nome: {contato.Nome}, Celular: {contato.Celular}");
            }
        }

        public void ListarMensagens()
        {
            foreach (var mensagem in Mensagens)
            {
                Console.WriteLine(mensagem.ToString());
            }
        }
    }
}
