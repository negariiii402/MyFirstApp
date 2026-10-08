using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstApp.Server.Storage;
using MyFirstApp.Server.Dtos;
using entity;
using System.Globalization;
using Microsoft.EntityFrameworkCore;
namespace MyFirstApp.Server.Controllers
{
     [Route("api/[controller]")]
     [ApiController]
    public class CustomerController
    {
        public class CustomersController: Controller
        {
            private readonly RepositoryDbContext _dbContext;
            public CustomersController(RepositoryDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            [HttpGet]
            public IActionResult GetAllCustomers()
            {
                 var customers = _dbContext.Customers.ToList();
                 
                List<CustomerDto> customerDto= new();
                foreach(var customer in customers)
                {
                    var customersDto = new CustomerDto()
                    {
                        PhoneNumber= customer.PhoneNumber,
                        Name= customer.Name,
                        Address= customer.Address
                    };
                    customerDto.Add(customersDto);
                }
                return Ok(customerDto);
            }
            [HttpGet("{Id}")]
            public IActionResult GetCustomerById(int Id)
            {
                var customer= _dbContext.Customers.Find(Id);
                var customerDto = new CustomerDto()
                {
                    PhoneNumber= customer.PhoneNumber,
                    Name= customer.Name,
                    Address= customer.Address
                };

                return Ok(customerDto);
            }
            [HttpPost]
            public IActionResult createCustomer(CustomerDto customerDto)
            {
                var customer= new Customer()
                {
                  PhoneNumber= customerDto.PhoneNumber,
                  Name= customerDto.Name,
                  Address= customerDto.Address

                };
                _dbContext.Customers.Add(customer);
                _dbContext.SaveChanges();
                return Ok(customer);
            }

            [HttpPut("{Id}")]
            public IActionResult UpdateCustomer(int Id)
            {
                var customer= _dbContext.Customers.Find(Id);
                if (customer is null)
                {
                    return NotFound();
                }
                customer.PhoneNumber= customer.PhoneNumber;
                customer.Name= customer.Name;
                customer.Address= customer.Address;

                return Ok(customer);
            }
            
            [HttpDelete("{Id}")]
            public IActionResult DeleteCustomer(int Id)
            {
                var customer= _dbContext.Customers.Find(Id);
                if (customer is null)
                {
                    return NotFound();
                }
                _dbContext.Customers.Remove(customer);
                _dbContext.SaveChanges();
                return Ok();
            }
            
        }
    }
}