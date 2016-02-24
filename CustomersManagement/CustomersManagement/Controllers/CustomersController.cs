using System.Linq;
using System.Web.Mvc;
using CustomersManagement.Models;
using CustomersManagement.Repository;

namespace CustomersManagement.Controllers
{
    public class CustomersController : Controller
    {
        private readonly CustomersRepository _customersRepository = new CustomersRepository();

        // GET: Customers
        public ActionResult Index()
        {
            var customers = _customersRepository.GetAllCustomers();
            var customersViewModel = new CustomersViewModel
            {
                Customers = customers,
                SelectedCustomer = null,
                CustomerNumber = customers == null ? 0 : customers.Count()
            };
            return View(customersViewModel);
        }

        public string Create()
        {
            return "Create New Customer";
        }

        public ActionResult Edit(int id)
        {
            var customer = _customersRepository.FindCustomer(id);
            if (customer == null)
            {
                ModelState.AddModelError("First", "Can't find customer with the given id");

                //return RedirectToAction("Index", "Customers");
            }
            return View(customer);
        }

        public string Delete(int id)
        {
            return "Delete";
        }

        [HttpPost]
        public ActionResult Save(
            CustomerViewModel customer)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Edit", "Customers", new { customer.Id });
            }

            if (!_customersRepository.UpdateCustomer(customer))
            {
                ModelState.AddModelError("", "Failed to update.Customer is not found!");
            }

            return RedirectToAction("Index", "Customers");
        }
    }
}