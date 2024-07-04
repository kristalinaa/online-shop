using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prov.Models
{
    public class User : IdentityUser
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public ICollection<BankAccount> bankAccounts { get; set; }
        //[ForeignKey(nameof(IdentityUser))]
        //public string IdentityUserId { get; private set; }
        //public IdentityUser IdentityUser { get; private set; }


        public User(string Name, string Surname, string Adress, string Email, string Password, string PhoneNumber) {
            this.Name = Name;   
            this.Surname = Surname;
            this.Adress = Adress;
            this.Email = Email;
            this.Password = Password;
            this.PhoneNumber = PhoneNumber;

        }
        public User() { 
        }



    }
}
