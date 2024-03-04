using Business.Abstracts;
using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void Add(Category category) //CreateCategoryRequest
    {
        _categoryDal.Add(category);
    }

    public void Delete(Category category) //DeleteCategoryRequest
    {
        _categoryDal.Delete(category);
    }

    public List<Category> GetAll() //GetAllCategoryResponse
    {

        return _categoryDal.GetAll();
    }

    public Category GetCategoryById(Guid id) //GetCategoryByIdResponse
    {
        return _categoryDal.GetCategoryById(id);
    }

    public void Update(Category category) //UpdateCategoryRequest
    {
        _categoryDal.Update(category);
    }
}
