using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.Xml;

namespace MagicVilla_VillaAPI.Model.Dto
{
   // Data Transfer Object — один из шаблонов проектирования, используется для передачи данных между подсистемами приложения.
   // Data Transfer Object, в отличие от business object или data access object не должен содержать какого-либо поведения.
    public class VillaDTO
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [JsonProperty("_name")]
        public string? Name { get; set; }
        [JsonProperty("_occupancy")]
        public int Occupancy { get; set; }
        [JsonProperty("_sqft")]
        public int Sqft { get; set; }

    }
}
