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
            Servico.Salvar(fabricantes[cmbFabricante.SelectedIndex]);
        }

    }
}
