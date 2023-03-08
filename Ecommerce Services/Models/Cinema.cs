using eTickets.Models;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce_Services.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string? Logo { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        //For one to many relationship
        public List<Movie>? Movies { get; set; }

    }
}
