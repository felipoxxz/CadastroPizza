using System.ComponentModel.DataAnnotations;

namespace CadastroPizza.Models
{
    public class BaseViewModel
    {
        [Required] public int id { get; set; }
    }
}
