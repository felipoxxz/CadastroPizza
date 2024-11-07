using System.ComponentModel.DataAnnotations;

namespace CadastroPizza.Models
{
    public class tbPizzaViewModel : PadraoViewModel
    {
        [Required] public string descricao { get; set; }
    }
}
