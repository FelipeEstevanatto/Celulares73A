using System;
using System.Collections.Generic;
using Npgsql;
using Celulares73A.Model.Entidades;
using Celulares73A.Model.Suporte;

namespace Celulares73A.Model
{
    public static class Servico
    {
        // Metodos que criam os objetos que representam
        // as entidades utilizadas no projeto
        public static Fabricante ObjFabricante(ref NpgsqlDataReader dtr)
        {
            Fabricante fabricante = new Fabricante
            {
                Id_Fabricante = Convert.ToInt64(dtr["id_fabricante"]),
                Nome = dtr["nome"].ToString()
            };

            return fabricante;
        }

        public static Aparelho ObjAparelho(ref NpgsqlDataReader dtr)
        {
            Aparelho aparelho = new Aparelho
            {
                Id_Aparelho = Convert.ToInt64(dtr["id_aparelho"]),

                Fabricante = ObjFabricante(ref dtr),

                Modelo = dtr["modelo"].ToString(),
                Altura = Convert.ToDecimal(dtr["altura"]),
                Largura = Convert.ToDecimal(dtr["largura"]),
                Espessura = Convert.ToDecimal(dtr["espessura"]),
                Peso = Convert.ToDecimal(dtr["peso"]),
                Preco = Convert.ToDecimal(dtr["preco"]),
                Quantidade = Convert.ToInt32(dtr["quantidade"]),
                Desconto = Convert.ToDecimal(dtr["desconto"])
            };

            return aparelho;
        }

        private static Pedido ObjPedido (ref NpgsqlDataReader dtr)
        {
            Pedido pedido = new Pedido
            {
                Id_Pedido = Convert.ToInt64(dtr["id_pedido"]),
                Aparelho = ObjAparelho(ref dtr),

                Quantidade = Convert.ToInt32(dtr["quantidade"]),
                DataHoraPedido = Convert.ToDateTime(dtr["datapedido"]),
                Observacao = dtr["observação"].ToString()
            };

            return pedido;
        }

        // Métodos para realizar as operações de Salvar, Incluir e alterar os dados no banco
        private static void Salvar(Aparelho aparelho)
        {
            string sql;

            List<object> param = new List<object>
            {
                aparelho.Fabricante.Id_Fabricante,
                aparelho.Modelo,
                aparelho.Altura,
                aparelho.Largura,
                aparelho.Espessura,
                aparelho.Peso,
                aparelho.Preco,
                aparelho.Quantidade,
                aparelho.Desconto
            };

            if (aparelho.Id_Aparelho == 0)
            {
                sql = "INSERT INTO aparelho (";
                sql +=      "id_fabricante, ";
                sql +=      "modelo, ";
                sql +=      "altura, ";
                sql +=      "largura, ";
                sql +=      "espessura, ";
                sql +=      "peso, ";
                sql +=      "preco, ";
                sql +=      "quantidade, ";
                sql +=      "desconto, ";
                sql += "VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9);";
            }
            else
            {
                param.Add(aparelho.Id_Aparelho);

                sql = "UPDATE aparelho SET ";
                sql +=      "id_fabricante=@1, ";
                sql +=      "modelo=@2, ";
                sql +=      "altura=@3, ";
                sql +=      "largura=@4, ";
                sql +=      "espessura=@5, ";
                sql +=      "peso=@6, ";
                sql +=      "preco=@7, ";
                sql +=      "quantidade=@8, ";
                sql +=      "desconto=@9 ";
                sql += "WHERE id_aparelho = @10;";
            }

            ConexaoBanco.executar(sql, param);
        }

        public static void Salvar(Fabricante fabricante)
        {
            string sql;

            List<object> param = new List<object>
            {
                fabricante.Nome
            };

            if (fabricante.Id_Fabricante == 0)
            {
                sql = "INSERT INTO fabricante " +
                        "(nome) " +
                    "VALUES (@1);";
            }
            else
            {
                sql = "UPDATE fabricante SET nome = @1;";
            }

            ConexaoBanco.executar(sql, param);
        }

        public static Pedido FazerPedido(Aparelho aparelho, string observacoes = null)
        {
            string sql;
            Pedido pedido = new Pedido();

            try
            {
                sql = "SELECT CURRENT_TIMESTAMP AT TIME ZONE 'BRT' as databaseserver";
                NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
                dtr.Read();
                pedido.DataHoraPedido = Convert.ToDateTime(dtr["databaseserver"]);
                dtr.Close();

                pedido.Aparelho = aparelho;
                pedido.DataHoraPedido = DateTime.Now;

                ConexaoBanco.executar("BEGIN");
 
                List<object> param = new List<object>
                {
                    pedido.Aparelho.Id_Aparelho,
                    observacoes
                };
                
                aparelho.Quantidade--;
                Salvar(aparelho);

                sql = "INSERT INTO pedido (" +
                        "id_aparelho, " +
                        "datahorapedido, " +
                        "observacao) ";
                sql += "VALUES (@1, '" + pedido.DataHoraPedido.ToString("yyyy-MM-dd HH:mm:ss") + "', @3);";
  
                ConexaoBanco.executar(sql, param);
                
                ConexaoBanco.executar("COMMIT");
                
            } catch (Exception ex)
            {
                ConexaoBanco.executar("ROLLBACK");
                throw new ApplicationException("Não foi possível realizar o pedido. \n\nMais detalhes:" + ex.Message);
            }
            return pedido;
        }

        //Métodos que permitem todas as pesquisas e filtros do sistema
        public static List<Aparelho> BuscarAparelho()
        {
            List<Aparelho> aparelhos = new List<Aparelho>();

            string sql;
            sql = "SELECT * " +
                    "FROM aparelho INNER JOIN fabricante " +
                    "ON aparelho.id_fabricante = fabricante.id_fabricante " +
                  "ORDER BY aparelho.modelo";

            NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
            while (dtr.Read())
                aparelhos.Add(ObjAparelho(ref dtr));

            dtr.Close();
            return aparelhos;
        }
        public static List<Aparelho> BuscarAparelho(string modelo)
        {
            List<Aparelho> aparelhos = new List<Aparelho>();
            List<object> param = new List<object>
            {
                "%" + modelo.ToLower() + "%"
            };

            string sql;
            sql = "SELECT * " +
                    "FROM aparelho A INNER JOIN fabricante F " +
                    "ON A.id_fabricante = F.id_fabricante " +
                    "WHERE LOWER(A.modelo) LIKE @1 " +
                  "ORDER BY A.modelo;";
            NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql, param);
            while(dtr.Read())
                aparelhos.Add(ObjAparelho(ref dtr));

            dtr.Close();
            return aparelhos;
        }
        public static List<Aparelho> BuscarAparelho(decimal precoMin,
                                                        decimal precoMax)
        {
            if (precoMin > precoMax)
                throw new Exception("O preço mínimo não pode ser maior que o preço máximo");
            
            List<Aparelho> aparelhos = new List<Aparelho>();
            List<object> param = new List<object>
            {
                precoMin,
                precoMax
            };

            string sql;
            sql = "SELECT * " +
                    "FROM aparelho INNER JOIN fabricante " +
                    "ON aparelho.id_fabricante = fabricante.id_fabricante " +
                    "WHERE preco BETWEEN @1 and @2 " +
                  "ORDER BY aparelho.preco";

            NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql, param);
            while (dtr.Read())
                aparelhos.Add(ObjAparelho(ref dtr));

            dtr.Close();
            return aparelhos;
        }
        public static List<Aparelho> BuscarAparelho(Fabricante fabricante)
        {
            List<Aparelho> aparelhos = new List<Aparelho>();
            List<object> param = new List<object>
            {
                "%" + fabricante.Nome.ToLower() + "%"
            };

            string sql;
            sql = "SELECT * " +
                    "FROM aparelho A INNER JOIN fabricante F " +
                    "ON A.id_fabricante = F.id_fabricante " +
                    "WHERE LOWER(F.nome) LIKE @1 " +
                  "ORDER BY F.nome";

            NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql, param);
            while (dtr.Read())
                aparelhos.Add(ObjAparelho(ref dtr));

            dtr.Close();
            return aparelhos;
        }
        public static List<Fabricante> TodosFabricantes()
        {
            List<Fabricante> fabricantes = new List<Fabricante>();

            string sql;
            sql = "SELECT * " +
                    "FROM fabricante " +
                    "ORDER BY fabricante.nome";

            NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
            while (dtr.Read())
                fabricantes.Add(ObjFabricante(ref dtr));

            dtr.Close();
            return fabricantes;
        }
        // Método para inserir um novo aparelho no sistema
        public static void Inserir(Aparelho aparelho)
        {
            string sql;
            
            List<object> param = new List<object>
            {
                aparelho.Fabricante.Id_Fabricante,
                aparelho.Modelo,
                aparelho.Altura,
                aparelho.Largura,
                aparelho.Espessura,
                aparelho.Peso,
                aparelho.Preco,
                aparelho.Quantidade,
                aparelho.Desconto,
            };

            sql = "INSERT INTO aparelho (" +
                    "id_fabricante, " +
                    "modelo, " +
                    "altura, " +
                    "largura, " +
                    "espessura, " +
                    "peso, " +
                    "preco, " +
                    "quantidade, " +
                    "desconto) ";
            sql += "VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9);";

            ConexaoBanco.executar(sql, param);
        }
    }
}
