using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Home
    {
        [Required(ErrorMessage = "Fill in the REGNO")]
        public int Regno { get; set; }
        [Required(ErrorMessage = "Fill in the NAMES")]
        public string Name { get; set; }
    }
}