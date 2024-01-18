using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Bulky.Models
{
    public class Category
    {
        [Key]
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [Required]
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [JsonPropertyName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1 and 100 only!!")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
