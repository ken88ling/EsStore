using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EsStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace EsStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repo)
        {
            _repository = repo;
        }

        public IActionResult Index()
        {
            return View(_repository.Products);
        }
    }
}