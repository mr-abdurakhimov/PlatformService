using System.ComponentModel.DataAnnotations;

namespace PlatformService.DTOS
{
    public class PlatfromCreateDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public string Cost { get; set; }
    }
}
