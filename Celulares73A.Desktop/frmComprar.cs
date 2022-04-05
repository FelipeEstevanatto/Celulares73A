using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Celulares73A.Model.Entidades;
using Celulares73A.Model;

namespace Celulares73A.Desktop
{
    public partial class frmComprar : Form
    {
        Aparelho aparelho;

        public frmComprar(Aparelho ap)
        {
            InitializeComponent();
            this.aparelho = ap;
        }

        private void frmComprar_Load(object sender, EventArgs e)
        {
            this.valueFabricante.Text = aparelho.Fabricante.Nome;
            this.valueModelo.Text = aparelho.Modelo;
            this.valueDimensoes.Text = aparelho.Espessura + "mmX" + aparelho.Largura + "mmX" + aparelho.Altura;
            this.valuePeso.Text = aparelho.Peso + "g";
            this.valueQuantidade.Text = aparelho.Quantidade.ToString();

            this.valueDesconto.Text = aparelho.Desconto.ToString() + "%";
            this.valuePreco.Text = aparelho.Preco.ToString("C");

        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            //Servico.FazerPedido(this.aparelho, txtBoxObservacoes.Text);
        }
    }
}
