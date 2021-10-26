using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using Models;

namespace BL
{
    public class CategoryHandler
    {
        CategoryRepository categoryRepository;

        public CategoryHandler()
        {
            categoryRepository = new CategoryRepository();
        }

        public List<Category> GetAllCategories()
        {
            return categoryRepository.GetAll();
        }

        public void CreateCategory(string title)
        {
            Category category = new Category(title);
            categoryRepository.Add(category);
        }

        public Category GetCategoryByName(string name)
        {
            return categoryRepository.GetCategory(name);
        }

    }
}
