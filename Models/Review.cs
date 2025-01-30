using System.ComponentModel.DataAnnotations;

namespace GameReviewSystem.Models
{
    public class Review
    {
        public int ReviewId { get; set; }

        [Required]
        public int? GameId { get; set; }

        [Required]
        public Game? Game { get; set; }

        [Required]
        [Range(1, 10)]
        public int Rating { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReviewDate { get; set; }
    }
}
