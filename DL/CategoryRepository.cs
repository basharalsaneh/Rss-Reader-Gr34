using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DL
{
    public class CategoryRepository : IRepository<Category>
    {
        List<Category> listOfCategories = new List<Category>();

        public void Add(Category category)
        {
            listOfCategories.Add(category);
        }

        public List<Category> GetAll()
        {
            return listOfCategories;
        }

        public Category GetCategory(string name)
        {
            Category category = listOfCategories.FirstOrDefault(category => category.Title.Equals(name));
            return category;
        }


    }
}
