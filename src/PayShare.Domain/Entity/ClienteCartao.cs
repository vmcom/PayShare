using System;
using System.Collections.Generic;
using System.Text;

namespace PayShare.Domain.Entity
{
    public class ClienteCartao
    {
        public int Id { get; set; }
        public string Bandeira { get; set; }
        public string Numero { get; set; }
        public string Validade { get; set; }
        public string CodigoSeguranca { get; set; }
        public string Titular { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
