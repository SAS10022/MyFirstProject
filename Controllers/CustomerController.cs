using Microsoft.AspNetCore.Mvc;
using MyFirstProject.Interfaces;
using MyFirstProject.Models;

namespace MyFirstProject.Controllers
{
    [Route("customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: /customers - Get all customers
        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            var customers = _customerService.GetAll();
            return Ok(customers);
        }

        // GET: /customers/{id} - Get customer by ID
        [HttpGet("{id}")]
        public IActionResult GetCustomerById(int id)
        {
            var customer = _customerService.GetById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        // POST: /customers - Create new customer
        [HttpPost]
        public IActionResult CreateCustomer(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _customerService.Create(customer);
                return Ok(new { message = "Customer created successfully", customer });
            }
            return BadRequest(ModelState);
        }
    }
}
