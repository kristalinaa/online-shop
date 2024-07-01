using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace prov.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        [Required]
        public string LongDescription { get; set; }
        [Required]
        public bool IsSoldOut { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public int CategoryId { get; set; }

        [Required]
        public string Image { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }




    }
}
