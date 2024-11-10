using CadastroPizza.DAO;
using CadastroPizza.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroPizza.Controllers
{
    public class IngredientesPizzaController : BaseController<tbIngredientesPizzaViewModel>
    {
        public IngredientesPizzaController()
        {
            DAO = new IngredientesPizzaDAO();
            GeraProximoId = true;
        }

        protected override void ValidaDados(tbIngredientesPizzaViewModel model, string operacao)
        {
            base.ValidaDados(model, operacao);
            if (string.IsNullOrEmpty(model.descricao))
            {
                ModelState.AddModelError("descricao", "A Descrição do ingrediente é obrigatória");
            }
        }

        public IActionResult ConsultaAvancada()
        {
            return View("ConsultaAvancada");
        }
    }
}
