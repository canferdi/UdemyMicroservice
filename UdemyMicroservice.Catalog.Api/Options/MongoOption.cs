using System.ComponentModel.DataAnnotations;

namespace UdemyMicroservice.Catalog.Api.Options
{
    public class MongoOption
    {
        [Required]
        public string DatabaseName { get; set; } = null!;
        [Required]
        public string ConnectionString { get; set; } = null!;
    }
}
