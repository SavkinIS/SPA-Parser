using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SPAParser.Shared;

namespace SPAParser.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {

        public ProductsController(ILogger<ProductsController> logger)
        {
            this.logger = logger;
        }

        private readonly ILogger<ProductsController> logger;

        [HttpGet]
        public IEnumerable<Product> Get()
        {

            var item = new List<Product> {
            new Product
            {
                ID = 0, Name = "First", Description = "First Description", ImgSource = @"https://86.img.avito.st/640x480/12032761886.jpg", ItemAderess = "Moscow", Price = 500, Url = @"http://avito.ru"
            },
            new Product
            {
                ID = 1, Name = "Second", Description = "Second Description", ImgSource = @"https://86.img.avito.st/640x480/12032761886.jpg", ItemAderess = "Moscow", Price = 100, Url = @"http://avito.ru"
            },
            new Product
            {
                ID = 2, Name = "Third", Description = "Third Description", ImgSource = @"https://86.img.avito.st/640x480/12032761886.jpg", ItemAderess = "Piter", Price = 300, Url = @"http://avito.ru"
            },
            new Product
            {
                ID = 3, Name = "Fourth", Description = "Fourth Description", ImgSource = @"https://86.img.avito.st/640x480/12032761886.jpg", ItemAderess = "Tula", Price = 800, Url = @"http://avito.ru"
            },
            new Product
            {
                ID = 4, Name = "Fifth", Description = "Fifth Description", ImgSource = @"https://86.img.avito.st/640x480/12032761886.jpg", ItemAderess = "Moscow", Price = 200, Url = @"http://avito.ru"
            }

            };

            return item;

        }
    }
}
