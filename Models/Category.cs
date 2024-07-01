using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace prov.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public ICollection<Product> Products { get; set; }


    }
}
