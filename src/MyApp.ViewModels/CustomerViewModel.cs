using System.ComponentModel.DataAnnotations;

namespace MyApp.ViewModels
{
    public class CustomerViewModel
    {
        public long Id { get; set; }

        [Display(Name = "Név")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Telefonszám")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string PhoneNumber { get; set; }
    }
}
