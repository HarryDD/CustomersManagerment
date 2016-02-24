using System.Collections.Generic;

namespace CustomersManagement.Models
{
    public class CustomersViewModel
    {
        public IEnumerable<CustomerViewModel> Customers { get; set; }
        public CustomerViewModel SelectedCustomer { get; set; }
        public int CustomerNumber { get; set; }
    }
}