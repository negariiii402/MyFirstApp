using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyFirstApp.Server.Storage;

namespace MyFirstApp.Server.Controllers
{
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly RepositoryDbContext _dbContext;

        public CustomerController(ILogger<CustomerController> logger, RepositoryDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        
    }
}