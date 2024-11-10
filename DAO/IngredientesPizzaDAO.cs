using CadastroPizza.Models;
using System.Data.SqlClient;
using System.Data;

namespace CadastroPizza.DAO
{
    public class IngredientesPizzaDAO : BaseDAO<tbIngredientesPizzaViewModel>
    {
        protected override tbIngredientesPizzaViewModel BuildModel(DataRow registro)
        {
            tbIngredientesPizzaViewModel model = new tbIngredientesPizzaViewModel();
            model.id = Convert.ToInt32(registro["id"]);
            model.pizzaId = Convert.ToInt32(registro["pizzaId"]);
            model.descricao = registro["descricao"].ToString();
            return model;
        }
        protected override SqlParameter[] CreateParameters(tbIngredientesPizzaViewModel Ingredientes)
        {
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("Id", Ingredientes.id);
            parameters[1] = new SqlParameter("pizzaId", Ingredientes.pizzaId);
            parameters[2] = new SqlParameter("descricao", Ingredientes.descricao);
            return parameters;
        }

        protected override void SetTabela()
        {
            Tabela = "tbIngredientesPizza";
        }
    }
}
