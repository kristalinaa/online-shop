using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace prov.Models
{
    public class Currency
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal ExchangeRate { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }


    }
}
