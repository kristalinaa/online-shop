using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace prov.Models
{
    public class BankAccount
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }
        public int CurrencyId { get; set; }

        [Required]
        public int Balance { get; set; }
        [ForeignKey("ClientId")]
        public User user { get; set; }
        public string ClientId { get; set; }
        [Required]
        public bool isActive { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        public List<BankTransaction> BankTransaction { get; set; }

    }
}
