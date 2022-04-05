using System;

namespace Celulares73A.Model.Entidades
{
    public class Fabricante
    {
        private Int64 id_fabricante;
        private String nome;
        // Encapsulando os atributos
        public Int64 Id_Fabricante
        {
            get { return id_fabricante; }
            set { id_fabricante = value; }
        }
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
