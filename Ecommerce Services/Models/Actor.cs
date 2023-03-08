using System.ComponentModel.DataAnnotations;

namespace Ecommerce_Services.Models
{
    public class Actor
    {
        [Key]
        public int Actorid { get; set; }
        public string? Profilepictureurl { get; set; }
        public string? Fullname { get; set; }
        public string? Biography { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
