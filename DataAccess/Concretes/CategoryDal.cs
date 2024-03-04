using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class CategoryDal: ICategoryDal
{
    List<Category> _categories;
    public CategoryDal()
    {
        
        Category category1 = new Category();
        category1.Id = 1;
        category1.Name = "BackEnd";


        Category category2 = new Category();
        category2.Id = 2;
        category2.Name = "FrontEnd";


        _categories = new List<Category> { category1, category2 };

    }
    public void Add(Category category)
    {
        _categories.Add(category);
    }

    public void Delete(Category category)
    {
        _categories.Remove(category);
    }

    public List<Category> GetAll()
    {
        return _categories;
    }

    public Category GetCategoryById(int id)
    {
        return _categories.SingleOrDefault(c => c.Id == id);
    }

    public void Update(Category category)
    {
        
        Category categoryToUpdate = _categories.SingleOrDefault(c=> c.Id == category.Id);
        categoryToUpdate.Id = category.Id;
        categoryToUpdate.Name = category.Name;

        }


}
