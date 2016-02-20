using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class CustomerViewModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        public string Address { get; set; }

        [Required]
        public string Mobile { get; set; }

        [Required]
        [DisplayName("Postal Address")]
        public AddressViewModel PostalAddress { get; set; }

        [DisplayName("Residential Address")]
        public AddressViewModel ResidentialAddress { get; set; }
    }
}