using System.Data.SqlClient;
using System.Data;
using System.Reflection.Emit;
using CadastroPizza.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CadastroPizza.DAO
{
    public class PizzaDAO : BaseDAO<tbPizzaViewModel>
    {
        protected override tbPizzaViewModel BuildModel(DataRow registro)
        {
            tbPizzaViewModel model = new tbPizzaViewModel();
            model.id = Convert.ToInt32(registro["id"]);
            model.descricao = registro["descricao"].ToString();
            return model;
        }
        protected override SqlParameter[] CreateParameters(tbPizzaViewModel pizza)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("id", pizza.id);
            parameters[1] = new SqlParameter("descricao", pizza.descricao);
            return parameters;
        }

        protected override void SetTabela()
        {
            Tabela = "tbPizza";
        }
    }
}
