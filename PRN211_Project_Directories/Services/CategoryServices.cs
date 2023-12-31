﻿using PRN211_Project_LibraryManagement.Models;
using PRN211_Project_LibraryManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_Project_LibraryManagement.Services
{
    public class CategoryServices : ICategory
    {
        public void AddCategory(Category category)
        {
            using(var con = new LibraryManagementContext())
            {
                con.Categories.Add(category);
                con.SaveChanges();
            }
        }

        public void DeleteCategory(Category category)
        {
            using (var con = new LibraryManagementContext())
            {
                con.Categories.Remove(category);
                con.SaveChanges();
            }
        }

        public List<Category> GetAllCategories()
        {
            List<Category> categorys = new List<Category>();
            using (var con = new LibraryManagementContext())
            {
                categorys = con.Categories.ToList();
            }
            return categorys;
        }

        public Category GetCategoryById(int id)
        {
            Category category = new Category();
            using (var con = new LibraryManagementContext())
            {
                category = con.Categories.Where((x) => x.CategoryId == id).FirstOrDefault();
            }
            return category;
        }

        public Category GetCategoryByName(string name)
        {
            Category category = new Category();
            using (var con = new LibraryManagementContext())
            {
                category = con.Categories.Where((x) => x.CategoryName.ToLower().Equals(name.ToLower())).FirstOrDefault();
            }
            return category;
        }

        public int GetLastID()
        {
            using (var con = new LibraryManagementContext())
            {
                var last = con.Categories.OrderByDescending(a => a.CategoryId).FirstOrDefault();
                if (last != null)
                {
                    return last.CategoryId;
                }
                return 0; // hoặc giá trị mặc định khác tùy vào yêu cầu của bạn
            }
        }

        public void UpdateCategory(Category category)
        {
            using (var con = new LibraryManagementContext())
            {
                con.Categories.Update(category);
                con.SaveChanges();
            }
        }
    }
}
