using System;

namespace Celulares73A.Model.Entidades
{
    public class Cliente
    {
        private Int64 id_cliente;
        private string nome;
        private string cnpj;
        private string email;
        public long Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Email { get => email; set => email = value; }
    }
}
