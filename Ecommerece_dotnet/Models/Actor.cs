using System.ComponentModel.DataAnnotations;

namespace Ecommerece_dotnet.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is Required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name ="Full Name")]
        [Required(ErrorMessage = "Full Name is Required")]
        [StringLength(50 , MinimumLength = 6, ErrorMessage = "Full Name should be within 6 to 50 characters")]
        public string FullName { get; set; }

        [Display(Name ="Biography")]
        [Required(ErrorMessage = "Biography is Required")]
        public string Bio { get; set; }

        //Relationship
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
