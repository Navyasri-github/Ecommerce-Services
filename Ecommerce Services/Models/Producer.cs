using eTickets.Models;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce_Services.Models
{
    public class Producer
    {
        [Key]
        public int Actorid { get; set; }
        public string? Profilepictureurl { get; set; }
        public string? Fullname { get; set; }
        public string? Biography { get; set;  }
        //For one to many relationship
        public List<Movie>? Movies { get; set; }
    }
}
