using System;

namespace Celulares73A.Model.Entidades
{
    public class Pedido
    {
        private Int64 id_Pedido;
        private Aparelho aparelho;
        private int quantidade;
        private DateTime datahorapedido;
        private string observacao;

        public Int64 Id_Pedido
        {
            get { return id_Pedido; }
            set { id_Pedido = value; }
        }

        public Aparelho Aparelho
        {
            get { return aparelho; }
            set { aparelho = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public DateTime DataHoraPedido
        {
            get { return datahorapedido; }
            set { datahorapedido = value; }
        }

        public string Observacao
        {
            get
            {
                return observacao;
            }
            set
            {
                observacao = value;
            }

        }
    }
}
