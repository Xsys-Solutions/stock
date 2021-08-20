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
        private readonly IProductGlobalServices _services;

        public ProductController(IProductGlobalServices services)
        {
            _services = services;
        }

        /// <summary>
        ///     [HttpGet] Listar produtos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<ProductResponse>>> GetAll()
        {
            try
            {
                var listResponse = await _services.GetAllAsync();
                return listResponse.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public async Task<ActionResult<ProductResponse>> PostAsync(ProductRequest model)
        {
            try
            {
                var response = _services.CreateAsync(model);
                return await response;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}