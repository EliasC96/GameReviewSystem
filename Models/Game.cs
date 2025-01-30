using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameReviewSystem.Models
{
    public class Game
    {
        public int GameId { get; set; }

        [Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public List<GamePlatform> GamePlatforms { get; set; } = new List<GamePlatform>();

        public int Genid  { get; set; }
        public Genre? Genre { get; set; }

    }
}
