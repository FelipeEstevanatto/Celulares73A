using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Celulares73A.Model;
using Celulares73A.Model.Entidades;

namespace Celulares73A.WEB
{
    public partial class Detalhes : System.Web.UI.Page
    {
        private Aparelho ap = new Aparelho();
        protected void Page_Load(object sender, EventArgs e)
        {
            Int64 id_aparelho = Convert.ToInt64(Request.QueryString["aparelho"]);
            ap = Servico.BuscarAparelho(id_aparelho);

            lblModelo.InnerText = ap.Modelo;
            lblFabricante.InnerText = ap.Fabricante.Nome;
            lblDimensions.InnerText = ap.Largura + " cm x " + ap.Altura  + " cm X " + ap.Espessura;
            lblQuantidadeEstoque.InnerText = ap.Quantidade.ToString();
            lblPreco.InnerText = ap.Preco.ToString();
            lblDesconto.InnerText = ap.Desconto.ToString("#0.0") + "%";
        }
    }
}