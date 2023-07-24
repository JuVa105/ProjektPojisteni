using System.ComponentModel.DataAnnotations;

namespace ProjektPlnaVerze.Models
{
    public class Insurance
    {
        public int Id { get; set; }
        [Display(Name ="Pojištěnec")]
        public int? CustomerId { get; set; }
        [Display(Name ="Pojištěnec")]
        public Customer? Customer { get; set; }
        [Display(Name="Typ pojištění")]
        public string TypeOfInsurance { get; set; }
        [Display(Name ="Částka")]
        public int Value { get; set; }
        [Display(Name ="Předmět pojištění")]
        public string ObjectOfInsurance { get; set; }
        [Display(Name ="Platnost od")]
        public string StartingFrom { get; set; }
        [Display(Name ="Platnost do")]
        public string Ending { get; set; }
    }
}
