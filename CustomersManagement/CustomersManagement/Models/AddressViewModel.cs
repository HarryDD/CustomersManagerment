using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CustomersManagement.Models
{
    public class AddressViewModel
    {
        [Required]
        [DisplayName("Line 1")]
        public string Line1 { get; set; }

        [DisplayName("Line 2")]
        public string Line2 { get; set; }

        [Required]
        public string Suburb { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string PostCode { get; set; }
    }
}