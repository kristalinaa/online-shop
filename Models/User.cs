using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prov.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<BankAccount> BankAccounts { get; set; }

        public User(int Id, string Name, string Surname, string Adress, string Email, string Password, string PhoneNumber) {
            this.Id = Id;
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
