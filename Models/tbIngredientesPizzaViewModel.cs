using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroPizza.Models
{
    public class tbIngredientesPizzaViewModel : PadraoViewModel
    {
        [Required] public int pizzaId { get; set; }
        public string descricao { get; set; }
    }
}
