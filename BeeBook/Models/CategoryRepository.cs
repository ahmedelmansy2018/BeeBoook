using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeeBook.Data;
using BeeBook.Models;

namespace BeeBook.Models
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly ApplicationDbContext _ApplicationDbContext;

        public CategoryRepository(ApplicationDbContext ApplicationDbContext)
        {
            _ApplicationDbContext = ApplicationDbContext;
        }

        public IEnumerable<Category> AllCategories => _ApplicationDbContext.Categories;

    }
}
