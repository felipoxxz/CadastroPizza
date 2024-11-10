﻿using CadastroPizza.DAO;
using CadastroPizza.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroPizza.Controllers
{
    public class PizzaController : BaseController<tbPizzaViewModel>
    {
        public PizzaController()
        {
            DAO = new PizzaDAO();
            GeraProximoId = true;
        }

        protected override void ValidaDados(tbPizzaViewModel model, string operacao)
        {
            base.ValidaDados(model, operacao);
            if (string.IsNullOrEmpty(model.descricao))
            {
                ModelState.AddModelError("descricao", "Preencha a decrição da pizza");
            }
        }

        public IActionResult ConsultaAvancada()
        {
            return View("ConsultaAvancada");
        }
    }
}
