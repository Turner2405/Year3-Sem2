using System.ComponentModel.DataAnnotations;


namespace RP1__L00183767.Models.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string? Name { get; set; }


    }
}
