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
    public partial class _Default : Page
    {
        protected List<Aparelho> aparelhos = new List<Aparelho>();
        protected void Page_Load(object sender, EventArgs e)
        {
            aparelhos = Servico.BuscarAparelho();
        }
    }
}