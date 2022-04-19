using System;
using System.Windows.Forms;
using Celulares73A.Model.Entidades;
using Celulares73A.Model;

namespace Celulares73A.Desktop
{
    public partial class frmComprar : Form
    {
        Aparelho aparelho;
        Pedido pedido;

        public frmComprar(Aparelho ap)
        {
            InitializeComponent();
            this.aparelho = ap;
        }

        private void frmComprar_Load(object sender, EventArgs e)
        {
            lblFabricante.Text = lblFabricante.Text.PadRight(19) + "\t" + aparelho.Fabricante.Nome;
            lblModelo.Text = lblModelo.Text.PadRight(20) + "\t" + aparelho.Modelo;
            lblDimensoes.Text = lblDimensoes.Text.PadRight(17) + "\t" + aparelho.Espessura + "mmX" + aparelho.Largura + "mmX" + aparelho.Altura;
            lblPeso.Text = lblPeso.Text.PadRight(22) + "\t" + aparelho.Peso.ToString() + " g";
            lblQuantidade.Text = lblQuantidade.Text.PadRight(17) + "\t" + aparelho.Quantidade.ToString();

            lblDesconto.Text = lblDesconto.Text.PadRight(13) + "\t" + aparelho.Desconto.ToString() + "%";
            lblPreço.Text =  aparelho.Preco.ToString("C");
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                Servico.FazerPedido(this.aparelho, txtBoxObservacoes.Text);
                MessageBox.Show("Pedido realizado com sucesso!", "Celulares CTI 2022", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } catch (ApplicationException ex)
            {
                MessageBox.Show("Erro ao realizar o pedido: " + ex.Message, "Celulares CTI 2022", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
