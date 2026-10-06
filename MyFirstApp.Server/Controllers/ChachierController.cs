using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entity;
using Humanizer;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using MyFirstApp.Server.Dtos;
using MyFirstApp.Server.Storage;

namespace MyFirstApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChachierController: Controller
    {
        private readonly RepositoryDbContext _dbContext;
        public ChachierController(RepositoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllChachiers()
        {
            var chachier = _dbContext.Chashiers.ToList();

            List<ChachierDto> chachierDtos = new();
            foreach (var Chachier in chachier)
            {
                var chachierDto = new ChachierDto()
                {
                    Name= Chachier.Name
                };
                chachierDtos.Add(chachierDto);
            }
            return Ok(chachier);
        }

        [HttpGet("{Id}")]
        public IActionResult GetChachierById(int Id)
        {
            var chachier = _dbContext.Chashiers.Find(Id);
            
            var chachierDto = new ChachierDto()
            {
              Name= chachier.Name  
            };
            return Ok(chachierDto);
        }

        [HttpPost]
        public IActionResult CreateChachier(ChachierDto chachierDto)
        {
            var chachier = new Chachier()
            {
              Name= chachierDto.Name  
            };
            _dbContext.SaveChanges();
            return Ok(chachier);
        }

        [HttpPut("{Id}")]
        public IActionResult UpdateChachier(int Id, ChachierDto chachierDto)
        {
            var chachier = _dbContext.Chashiers.Find(Id);
            if (chachier is null)
            {
                return NotFound();
            }
            chachier.Name= chachierDto.Name;
            _dbContext.SaveChanges();
            return Ok(chachier);
        }

        [HttpDelete("{Id}")]
        public IActionResult DeleteChachier(int Id)
        {
            var chachier = _dbContext.Chashiers.Find(Id);
            if (chachier is null)
            {
                return NotFound();
            }
            _dbContext.Chashiers.Remove(chachier);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}