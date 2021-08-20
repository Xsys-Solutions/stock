using DTO.Model.Products;
using GlobalServices.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _services;

        public ProductController(IProductServices services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductResponse>>> GetAll()
        {
            try
            {
                var listResponse = await _services.GetAllAsync();
                return Ok(listResponse.ToList());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<ProductResponse>> PostAsync(ProductRequest model)
        {
            try
            {
                var response = await _services.CreateAsync(model);
                return CreatedAtAction("PostAsync", response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}