using PRN211_Project_LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_Project_LibraryManagement.Repository
{
    public interface ICategory
    {
        /// <summary>
        /// Get all categorys
        /// </summary>
        /// <returns></returns>
        public List<Category> GetAllCategories();

        /// <summary>
        /// Get category by username, password
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Category GetCategoryById(int id);

        public Category GetCategoryByName(string name);

        public int GetLastID();

        public void AddCategory(Category category);

        public void UpdateCategory(Category category);

        public void DeleteCategory(Category category);

    }
}
