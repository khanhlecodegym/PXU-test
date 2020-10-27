using Microsoft.AspNetCore.Mvc.Rendering;
using PXUProduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PXUProduct.ViewModels
{
    public class ProductCreateVM
    {
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }
    }
}
