using SPAParser.Server.DataFolder.ContextFolder;
using SPAParser.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPAParser.Server.DataFolder
{
    public class Data
    {

        DataContextSQL context = new DataContextSQL();

        public Product AddProduct(Product product)
        {
            if (!context.Products.Contains(product))
            {
                context.Products.Add(product);
                context.SaveChanges();
            }

            return product;
        }

        public IEnumerable<Product> GetProducts()
        {
            return context.Products.ToList();
        }
    }
}
