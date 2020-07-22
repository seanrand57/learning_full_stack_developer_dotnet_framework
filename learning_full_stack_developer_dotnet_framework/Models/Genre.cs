using System.ComponentModel.DataAnnotations;

namespace learning_full_stack_developer_dotnet_framework.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required] [StringLength(255)] public string Name { get; set; }
    }
}