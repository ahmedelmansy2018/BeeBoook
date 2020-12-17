using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeeBook.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Fruit Books", Description="All-fruity Books"},
                new Category{CategoryId=2, CategoryName="Cheese cakes", Description="Cheesy all the way"},
                new Category{CategoryId=3, CategoryName="Seasonal Books", Description="Get in the mood for a seasonal Book"}
            };
    }
}
