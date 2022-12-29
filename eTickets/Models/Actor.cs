using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Please enter the actor's profile picture URL")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Please enter the actor's full name")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "The actor's name must be between 2 and 50 characters")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Please enter the actor's bio")] 
        // TODO : Bio not working
        public string Bio { get; set; }


        //relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
