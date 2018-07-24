using System;
using System.Collections.Generic;
using System.Text;

namespace PayShare.Domain.Entity
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string NomeFanatasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Token { get; set; }
        public string Email { get; set; }
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
    }
}
