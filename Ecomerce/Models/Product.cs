using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecomerce.Models
{
    public class Product
    {
      public int Product_Id { get; set; }
      public string  Product_Title { get; set; }
      public string Product_Description { get; set; }
      public string Product_Logo { get; set; }

    }
}