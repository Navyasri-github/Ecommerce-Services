using eTickets.Models;

namespace Ecommerce_Services.Models
{
    public class Actor_Movie
    {
        public int Movieid { get; set; }
        public int Actorid { get; set; }
        public Movie Movies { get; set; }
        public Actor Actors{get;set;}

}
}
