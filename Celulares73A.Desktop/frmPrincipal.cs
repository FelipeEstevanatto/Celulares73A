using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Celulares73A.Model.Entidades;
using Celulares73A.Model;

namespace Celulares73A.Desktop
{
    public partial class frmPrincipal : Form
    {
        List<Aparelho> aparelhos = new List<Aparelho>();
        List<Fabricante> fabricantes = new List<Fabricante>();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                aparelhos = Servico.BuscarAparelho();
                lstCelulares.DataSource = aparelhos;

                fabricantes = Servico.TodosFabricantes();
                cmbFabricante.DataSource = fabricantes;
                cmbFabricante.ValueMember = "id_fabricante";
                cmbFabricante.DisplayMember = "Nome";
                cmbFabricante.SelectedIndex = -1;

            } catch (ApplicationException ex)
            {
                MessageBox.Show("Erro:\n" + ex.Message, "Erro de banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSearchModelo_Click(object sender, EventArgs e)
        {
            try
            {
                aparelhos = Servico.BuscarAparelho(txtBoxSearch.Text);

                lstCelulares.DataSource = aparelhos;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show("Erro:\n" + ex.Message, "Erro de banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchFabricante_Click(object sender, EventArgs e)
        {
            if (cmbFabricante.SelectedIndex >= 0)
            {
                aparelhos = Servico.BuscarAparelho(fabricantes[cmbFabricante.SelectedIndex]);
                lstCelulares.DataSource = aparelhos;
            }
        }

        private void btnSearchPreco_Click(object sender, EventArgs e)
        {
            try
            {
                aparelhos = Servico.BuscarAparelho(numericPrecoMin.Value, numericPrecoMax.Value);
                lstCelulares.DataSource = aparelhos;
            } catch(Exception error)
            {
                MessageBox.Show(error.Message, "Celular CTI 2022", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmNovo frmNovo = new frmNovo();
            frmNovo.Show();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            // Send the currently selected item to the form
            if (lstCelulares.SelectedIndex >= 0)
            {
                frmComprar frmComprar = new frmComprar(aparelhos[lstCelulares.SelectedIndex]);
                frmComprar.Show();
            }
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            aparelhos = Servico.BuscarAparelho();
            lstCelulares.DataSource = aparelhos;
            numericPrecoMin.Value = 0;
            numericPrecoMax.Value = 0;
            txtBoxSearch.Text = "";
            cmbFabricante.SelectedIndex = -1;
        }
    }
}
