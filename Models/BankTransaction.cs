using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace prov.Models
{
    public class BankTransaction
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("BankAccountId")]
        public BankAccount BankAccount { get; set; }
        public int BankAccountId { get; set; }

        [Required]
        public int Action  { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public bool isActive { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }


    }
}
