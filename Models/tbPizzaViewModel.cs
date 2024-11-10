using System.ComponentModel.DataAnnotations;

namespace CadastroPizza.Models
{
    public class tbPizzaViewModel : BaseViewModel
    {
        [Required] public string descricao { get; set; }
    }
}
