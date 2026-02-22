using MyFirstProject.Interfaces;
using MyFirstProject.Models;

namespace MyFirstProject.Services
{
    public class CustomerService : ICustomerService
    {
        private static List<Customer> _customers = new List<Customer>
        {
            new Customer { Id = 1, FirstName = "John", LastName = "Doe", Email = "john@example.com", Phone = "123-456-7890" },
            new Customer { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane@example.com", Phone = "098-765-4321" }
        };

        public IEnumerable<Customer> GetAll()
        {
            return _customers;
        }

        public Customer? GetById(int id)
        {
            return _customers.FirstOrDefault(c => c.Id == id);
        }

        public void Create(Customer customer)
        {
            customer.Id = _customers.Any() ? _customers.Max(c => c.Id) + 1 : 1;
            _customers.Add(customer);
        }

        public void Update(Customer customer)
        {
            var existing = _customers.FirstOrDefault(c => c.Id == customer.Id);
            if (existing != null)
            {
                existing.FirstName = customer.FirstName;
                existing.LastName = customer.LastName;
                existing.Email = customer.Email;
                existing.Phone = customer.Phone;
            }
        }

        public void Delete(int id)
        {
            var customer = _customers.FirstOrDefault(c => c.Id == id);
            if (customer != null)
            {
                _customers.Remove(customer);
            }
        }
    }
}
