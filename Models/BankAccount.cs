using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace prov.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int Balance { get; set; }
        public bool isActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

    }
}
