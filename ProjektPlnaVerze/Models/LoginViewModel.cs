using System.ComponentModel.DataAnnotations;

namespace ProjektPlnaVerze.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress(ErrorMessage ="Neplatná emailová adresa")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Heslo")]
        public string Password { get; set; }
        [Display(Name ="Pamatuj si mě")]
        public bool RememberMe { get; set;}

        //Zdroj: https://www.itnetwork.cz/csharp/asp-net-core/zaklady/prihlaseni-a-registrace-v-aspnet-core-mvc
    }
}
