using Business.Concretes;
using DataAccess.Concretes;
using Entities;

namespace UnitTests;

public class CategoryManagerCRUDTests
{
    CategoryManager categoryManager = new CategoryManager(new CategoryDal());
    [Fact]
    public void CategoryManagerGetById()
    {
        Category expectedCategory = new Category();
        expectedCategory.Id = 1;
        expectedCategory.Name = "BackEnd";
        Category result = categoryManager.GetCategoryById(1);
        Assert.Equal(expectedCategory.Name, result.Name);
    }

    [Fact]
    public void CategoryManagerAddTest()
    {
        Category expectedCategory = new Category();
        expectedCategory.Id = 3;
        expectedCategory.Name = "Mobile";
        Category result = categoryManager.GetCategoryById(3);
        Assert.Equal(expectedCategory.Name, result.Name);

    }
}