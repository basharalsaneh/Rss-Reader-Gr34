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
        private static List<Category> listOfCategories = new List<Category>();
        CategorySerializer serializer = new CategorySerializer();

        public CategoryRepository()
        {
            listOfCategories = GetAll();
        }

        public void Add(Category category)
        {

            listOfCategories.Add(category);
            SaveChanges();
            
        }

        public List<Category> GetAll()
        {
            //return listOfCategories;

            List<Category> listOfCategoriesDeserialized = new List<Category>();
            try
            {
                listOfCategoriesDeserialized = serializer.Deserialize();
            }
            catch (Exception)
            {


            }

            return listOfCategoriesDeserialized;
        }

        public Category GetCategory(string name)
        {
            Category category = GetAll().FirstOrDefault(category => category.Title.Equals(name));
            return category;
        }

        public void Delete(string categoryName)
        {
            //listOfCategories.Remove(listOfCategories[index]);
            //listOfCategories.Remove(cat => cat.Title.Equals(category.Title));
            Category category = listOfCategories.FirstOrDefault(cat => cat.Title.Equals(categoryName));
            listOfCategories.Remove(category);
            SaveChanges();
        }

        public void Edit(string oldTitle, string newTitle)
        {
            Category category1 = GetCategory(oldTitle);
            listOfCategories.RemoveAll(cat => cat.Title.Equals(category1.Title));
            Category category2 = new Category(newTitle);
            //category.Title = newTitle;
            listOfCategories.Add(category2);
            SaveChanges();

        }

        public void SaveChanges()
        {
            serializer.Serialize(listOfCategories);
            //serializer.SerializeFeed(listOfFeeds);
        }


    }
}
