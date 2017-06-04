using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ecomerce.Models;

namespace Ecomerce.Controllers
{
    public class ProductController : ApiController
    {
        Product[] product = new Product[]
        {
            new Product{ Product_Id=1,Product_Title="Vegetables",Product_Description="Fresh vegetables endowed with almost all of the nutritional principles that our body requires",Product_Logo=""},
            new Product{ Product_Id=2,Product_Title="Grocery and staples",Product_Description="A staple food, or simply a staple, is a food that is eaten routinely and in such quantities that it constitutes a dominant portion of a standard diet for a given people, supplying a large fraction of energy needs and generally forming a significant proportion of the intake of other nutrients as well",Product_Logo=""},
            new Product{ Product_Id=3,Product_Title="Beverage",Product_Description="Fresh vegetables endowed with almost all of the nutritional principles that our body requires",Product_Logo=""}

        };
        // Get Product Deatils
        public IEnumerable<Product> GetAllProducts()
        {
            return product;
        }


        // Get the product Deatils passing product id 
        public IHttpActionResult GetProductByID(int id)
        {

            var productdetails = product.FirstOrDefault((p) => p.Product_Id == id);

            if (productdetails == null)
            {
                return NotFound();
            }
            return Ok(productdetails);
        }
    }

}
