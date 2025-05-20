using System.ComponentModel.DataAnnotations;

namespace PortfolioLAB2.Models
{
    public class Project
    {
        public int Id { get; set; }

        // lub
        // public int ProjectId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ImageSrc { get; set; }

        public string Tags { get; set; }
    }
}
