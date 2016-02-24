using System.Collections.Generic;
using System.Linq;
using CustomersManagement.Models;

namespace CustomersManagement.Repository
{
    public class CustomersRepository
    {
        private static readonly List<CustomerViewModel> Customers = new List<CustomerViewModel>
        {
            new CustomerViewModel
            {
                FirstName = "Cat",
                LastName = "Shaw",
                Address = "Macquarie",
                Id = 1,
                Mobile = "04888888",
                PostalAddress = new AddressViewModel
                {
                    Line1 = "Macquarie",
                    Line2 = "Macquarie",
                    Suburb = "North Ryde",
                    PostCode = "2000",
                    State = "NSW"
                },
                ResidentialAddress = new AddressViewModel
                {
                    Line1 = "Macquarie11",
                    Line2 = "Macquarie11",
                    Suburb = "North Ryde11",
                    PostCode = "2000",
                    State = "NSW"
                }
            },
            new CustomerViewModel
            {
                FirstName = "Mic",
                LastName = "Flarit",
                Address = "Hornsby",
                Id = 2,
                Mobile = "04188888",
                PostalAddress = new AddressViewModel
                {
                    Line1 = "Hornsby",
                    Line2 = "Hornsby",
                    Suburb = "Hornsby",
                    PostCode = "2000",
                    State = "NSW"
                },
                ResidentialAddress = new AddressViewModel
                {
                    Line1 = "Hornsby11",
                    Line2 = "Hornsby11",
                    Suburb = "Hornsby11",
                    PostCode = "2000",
                    State = "NSW"
                }
            },
            new CustomerViewModel
            {
                FirstName = "Mar",
                LastName = "GVA",
                Address = "Artarmon",
                Id = 3,
                Mobile = "04388888",
                PostalAddress = new AddressViewModel
                {
                    Line1 = "Artarmon",
                    Line2 = "Artarmon",
                    Suburb = "Artarmon",
                    PostCode = "2000",
                    State = "NSW"
                },
                ResidentialAddress = new AddressViewModel
                {
                    Line1 = "Artarmon11",
                    Line2 = "Artarmon11",
                    Suburb = "Artarmon11",
                    PostCode = "2000",
                    State = "NSW"
                }
            },
            new CustomerViewModel
            {
                FirstName = "Nir",
                LastName = "Wine",
                Address = "Straigthfield",
                Id = 4,
                Mobile = "04588888",
                PostalAddress = new AddressViewModel
                {
                    Line1 = "Straigthfield",
                    Line2 = "Straigthfield",
                    Suburb = "Straigthfield",
                    PostCode = "2000",
                    State = "NSW"
                },
                ResidentialAddress = new AddressViewModel
                {
                    Line1 = "Straigthfield11",
                    Line2 = "Straigthfield11",
                    Suburb = "Straigthfield11",
                    PostCode = "2000",
                    State = "NSW"
                }
            },
            new CustomerViewModel
            {
                FirstName = "DA",
                LastName = "Pip",
                Address = "Roseville",
                Id = 5,
                Mobile = "04688888",
                PostalAddress = new AddressViewModel
                {
                    Line1 = "Roseville",
                    Line2 = "Roseville",
                    Suburb = "Roseville",
                    PostCode = "2000",
                    State = "NSW"
                },
                ResidentialAddress = new AddressViewModel
                {
                    Line1 = "Roseville11",
                    Line2 = "Roseville11",
                    Suburb = "Roseville11",
                    PostCode = "2000",
                    State = "NSW"
                }
            }
        };

        public bool AddCustomer(CustomerViewModel customer)
        {
            if (!IsExistingCustomer(customer))
            {
                Customers.Add(customer);
                return true;
            }

            return false;
        }

        public void DeleteCustomer(int id)
        {
            var customer = FindCustomer(id);

            if (customer != null)
            {
                Customers.Remove(customer);
            }
        }

        public bool IsExistingCustomer(CustomerViewModel customer)
        {
            return customer != null && FindCustomer(customer.Id) != null;
        }

        public bool UpdateCustomer(CustomerViewModel customer)
        {
            if (customer == null)
            {
                return false;
            }

            var existingCustomer = FindCustomer(customer.Id);

            if (existingCustomer != null)
            {
                DeleteCustomer(customer.Id);
            }

            Customers.Add(customer);

            return true;
        }

        public CustomerViewModel FindCustomer(int id)
        {
            return Customers.SingleOrDefault(c => c.Id == id);
        }

        public IEnumerable<CustomerViewModel> GetAllCustomers()
        {
            return Customers;
        }
    }
}