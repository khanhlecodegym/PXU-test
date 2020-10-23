using PXUProduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PXUProduct.ViewModels
{
    public class HomeIndexVM
    {
        public List<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
