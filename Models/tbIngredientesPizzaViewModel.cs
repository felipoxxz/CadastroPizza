using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroPizza.Models
{
    public class tbIngredientesPizzaViewModel : BaseViewModel
    {
        public int pizzaId { get; set; }
        [Required(ErrorMessage = "A descrição do ingrediente é obrigatório")]
        public string descricao { get; set; }
    }
}
