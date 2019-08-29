using System.ComponentModel.DataAnnotations;

namespace Map.Site.ViewModels
{
    public class MapViewModel
    {
        [Display(Name = @"Location")]
        [Required]
        public string Location { get; set; } = "London";

        public string Latitude { get; set; } = "51.47813";
        public string Longitude { get; set; } = "-0.09898";
    }
}
