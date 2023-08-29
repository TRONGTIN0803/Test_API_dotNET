using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebtestAPI.Context;
using WebtestAPI.Data;
using WebtestAPI.Service;

namespace WebtestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly TestApiContext _context;
        private readonly IServiceProduct _iserviceProduct;
        public ProductController(IServiceProduct iserviceProduct)
        {
            _iserviceProduct = iserviceProduct;
        }
        

        // GET: api/Product
        [HttpGet]
        public async Task<IActionResult> Getproducts()
        {
            
            var result =await _iserviceProduct.GetAllProduct();
            return Ok(result);
        }

        
    }
}
