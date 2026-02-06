using System.ComponentModel.DataAnnotations;
namespace FragranceStore__L00183767.Models.Models
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }
        [Required]

        public string Name { get; set; }
        

    }
}
