using System.ComponentModel.DataAnnotations;

namespace GameReviewSystem.Models
{
    public class Platform
    {
        public int PlatformId { get; set; }

        [Required]
        public string Name { get; set; }

 public List<GamePlatform> GamePlatforms { get; set; } = new List<GamePlatform>();    }
}
