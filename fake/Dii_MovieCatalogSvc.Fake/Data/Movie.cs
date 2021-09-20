using System.ComponentModel.DataAnnotations;
//test
namespace Dii_MovieCatalogSvc.Fake.Data
{
    public class Movie
    {
        public string MovieId { get; set; }

        public MovieMetadata MovieMetadata { get; set; }

        [Required]
        public string Title { get; set; }
    }
}
