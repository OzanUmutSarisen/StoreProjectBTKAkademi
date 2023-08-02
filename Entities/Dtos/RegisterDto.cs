using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record RegisterDto
    {
        [Required(ErrorMessage ="User name is required")]
        public String? UserName { get; init; }

        [Required(ErrorMessage ="Email name is required")]
        public String? Email { get; init; }

        [Required(ErrorMessage ="Password name is required")]
        public String? Password { get; init; }
    }
}