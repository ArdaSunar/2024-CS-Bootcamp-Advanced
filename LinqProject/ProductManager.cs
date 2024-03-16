using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject;

public class ProductManager
{
     public static List<Product> GetProductsLinq(List<Product> products)
    {
        return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();
    }
}

