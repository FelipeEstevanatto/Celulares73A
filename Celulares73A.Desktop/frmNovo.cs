using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Celulares73A.Model.Entidades;
using Celulares73A.Model;


namespace Celulares73A.Desktop
{
    public partial class frmNovo : Form
    {
        List<Fabricante> fabricantes = new List<Fabricante>();
        
        public frmNovo()
        {
            InitializeComponent();
        }
        private void frmNovo_Load(object sender, EventArgs e)
        {
            fabricantes = Servico.TodosFabricantes();
            cmbFabricante.DataSource = fabricantes;
            cmbFabricante.ValueMember = "id_fabricante";
            cmbFabricante.DisplayMember = "Nome";
            cmbFabricante.SelectedIndex = -1;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Aparelho aparelho = new Aparelho();

            aparelho.Fabricante = (Fabricante)cmbFabricante.SelectedItem;
            aparelho.Modelo = txtBoxModelo.Text;
            aparelho.Preco = Convert.ToDecimal(numericLargura.Text);
            aparelho.Quantidade = Convert.ToInt32(numericQuantidade.Text);
            aparelho.Desconto = Convert.ToDecimal(numericDesconto.Text);
            aparelho.Altura = Convert.ToDecimal(numericAltura.Text);
            aparelho.Largura = Convert.ToDecimal(numericLargura.Text);
            aparelho.Espessura = Convert.ToDecimal(numericEspessura.Text);

            Servico.Inserir(aparelho);

            MessageBox.Show("Aparelho inserido com sucesso!", "Celulares CTI 2022", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
