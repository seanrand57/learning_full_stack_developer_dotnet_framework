using System;
using System.ComponentModel.DataAnnotations;

namespace learning_full_stack_developer_dotnet_framework.Models
{
    public class Gig
    {
        public int Id { get; set; }

        public ApplicationUser Artist { get; set; }

        // Foreign Key Property
        [Required] public string ArtistId { get; set; }

        public DateTime DateTime { get; set; }

        [Required] [StringLength(255)] public string Venue { get; set; }

        public Genre Genre { get; set; }

        // Foreign Key Property
        [Required] public int GenreId { get; set; }
    }
}