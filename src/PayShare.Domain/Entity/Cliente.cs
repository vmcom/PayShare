using System;
using System.Collections.Generic;
using System.Text;

namespace PayShare.Domain.Entity
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Celular { get; set; }

        public ICollection<ClienteCartao> Cartoes { get; set; }

        public Cliente()
        {
            Cartoes = new HashSet<ClienteCartao>();
        }
    }
}
