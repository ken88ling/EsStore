using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsStore.Data;

namespace EsStore.Models
{
    public class EfProductRepo : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public EfProductRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable<Product> Products => _context.Products;
    }
}
