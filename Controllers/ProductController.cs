using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PXUProduct.Common;
using PXUProduct.Models;
using PXUProduct.ViewModels;

namespace PXUProduct.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(AppDbContext appDbContext, IWebHostEnvironment webHostEnvironment)
        {
            _appDbContext = appDbContext;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            ViewBag.Message = "Mì tôm Hảo Hảo";

            /*var product = new List<Product> 
            {
                new Product {Id = 1, Name = "Mỳ tôm Hảo Hảo", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", Price=15.5M, Stock=500, ImageUrl="https://acecookvietnam.cdn.vccloud.vn/wp-content/uploads/2017/07/590-HH-TCC.png"},
                new Product {Id = 2, Name = "Gạo Bồ Câu", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", Price=15.5M, Stock=500, ImageUrl="https://acecookvietnam.cdn.vccloud.vn/wp-content/uploads/2017/07/590-HH-TCC.png"},
                new Product {Id = 3, Name = "Mè Xửng Thiên Hương", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", Price=15.5M, Stock=500, ImageUrl="https://acecookvietnam.cdn.vccloud.vn/wp-content/uploads/2017/07/590-HH-TCC.png"},
                new Product {Id = 4, Name = "Bánh Lọc", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", Price=15.5M, Stock=500, ImageUrl="https://acecookvietnam.cdn.vccloud.vn/wp-content/uploads/2017/07/590-HH-TCC.png"},
                new Product {Id = 5, Name = "Bánh Tráng Trộn", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s", Price=15.5M, Stock=500, ImageUrl="https://acecookvietnam.cdn.vccloud.vn/wp-content/uploads/2017/07/590-HH-TCC.png"}
            };*/

            var products = _appDbContext.Products.Include(p => p.Category).ToList();

            return View(products);
        }

        public IActionResult Create()
        {
            ProductCreateVM productVM = new ProductCreateVM()
            {
                Product = new Product(),
                CategorySelectList = _appDbContext.Categories.Select(item => new SelectListItem
                {
                    Text = item.CategoryName,
                    Value = item.Id.ToString()
                })
            };

            return View(productVM);
        }
        
        [HttpPost]
        public IActionResult Create(ProductCreateVM productCreateVM)
        {
            var files = HttpContext.Request.Form.Files;
            string webRootPath = _webHostEnvironment.WebRootPath;

            string upload = webRootPath + CommonDefault.ImagePath;
            string fileName = Guid.NewGuid().ToString();
            string extension = Path.GetExtension(files[0].FileName);

            using (var fileStream = new FileStream(Path.Combine(upload, fileName + extension), FileMode.Create))
            {
                files[0].CopyTo(fileStream);
            }

            productCreateVM.Product.ImageUrl = fileName + extension;
            _appDbContext.Products.Add(productCreateVM.Product);
            _appDbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
