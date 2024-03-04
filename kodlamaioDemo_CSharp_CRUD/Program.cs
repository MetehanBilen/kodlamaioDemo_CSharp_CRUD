using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities;

Console.WriteLine("----- Category Tests ----");
Console.WriteLine("*** Category GetAll Test");

ICategoryService categoryManager = new CategoryManager(new CategoryDal());
List<Category> categories = categoryManager.GetAll();

foreach (var category in categories)
{
    Console.WriteLine(category.Name);
}

Console.WriteLine("*** Category Get By Id Test");
Category deneme = categoryManager.GetCategoryById(2);
Console.WriteLine(deneme.Name);


Console.WriteLine("*** Category Add Test");
Category categoryToAddedAndDeleted = new Category();
categoryToAddedAndDeleted.Id = 3;
categoryToAddedAndDeleted.Name = "Mobile";

categoryManager.Add(categoryToAddedAndDeleted);
foreach (var category in categories)
{
    Console.WriteLine(category.Name);
}

Console.WriteLine("*** Category Delete Test");
categoryManager.Delete(categoryToAddedAndDeleted);
foreach (var category in categories)
{
    Console.WriteLine(category.Name);
}

Console.WriteLine("*** Category Update Test");
Category categoryToUpdate = new Category();
categoryToUpdate.Id = 1;
categoryToUpdate.Name = "Mobile";
categoryManager.Update(categoryToUpdate);

foreach (var category in categories)
{
    Console.WriteLine(category.Name);
}

Console.WriteLine("----- Instructor Tests ----");
Console.WriteLine("*** Instructor GetAll Test");

IInstructorService instructorManager = new InstructorManager(new InstructorDal());
List<Instructor> ınstructors = instructorManager.GetAll(); 
foreach(var instructor in ınstructors)
{
    Console.WriteLine("Id: "+instructor.Id+" "+instructor.FirstName+" "+instructor.LastName+"  =>  "+instructor.Resume);
}

Console.WriteLine("*** Instructor Get By Id Test");
Instructor instructorGetBy1 = instructorManager.GetInstructorById(1);
Console.WriteLine(instructorGetBy1.FirstName);


Console.WriteLine("*** Instructor Add Test");
Instructor instructorToAddedAndDeleted = new Instructor();
instructorToAddedAndDeleted.Id = 3;
instructorToAddedAndDeleted.FirstName = "Mt";
instructorToAddedAndDeleted.LastName = "Bln";
instructorToAddedAndDeleted.Resume = "Jr. Dev";

instructorManager.Add(instructorToAddedAndDeleted);
foreach (var instructor in ınstructors)
{
    Console.WriteLine("Id: " + instructor.Id + " " + instructor.FirstName + " " + instructor.LastName + "  =>  " + instructor.Resume);
}

Console.WriteLine("*** Instructor Delete Test");
instructorManager.Delete(instructorToAddedAndDeleted);
foreach (var instructor in ınstructors)
{
    Console.WriteLine("Id: " + instructor.Id + " " + instructor.FirstName + " " + instructor.LastName + "  =>  " + instructor.Resume);
}
Console.WriteLine("*** Instructor Update Test");

Instructor instructorToUpdate = new Instructor();
instructorToUpdate.Id = 1;
instructorToUpdate.FirstName = "Mete";
instructorToUpdate.LastName = "Bilen";
instructorToUpdate.Resume = "Endüstri Mühendisi";
instructorManager.Update(instructorToUpdate);

foreach (var instructor in ınstructors)
{
    Console.WriteLine("Id: " + instructor.Id + " " + instructor.FirstName + " " + instructor.LastName + "  =>  " + instructor.Resume);
}



Console.WriteLine("----- Course Tests ----");
Console.WriteLine("*** Course GetAll Test");

ICourseService courseManager = new CourseManager(new CourseDal());
List<Course> courses = courseManager.GetAll();

foreach (var course in courses)
{
    Console.WriteLine(course.Name + " " + course.Description);
}

Console.WriteLine("*** Course Get By Id Test");
Course categoryGetBy2 = courseManager.GetCourseById(2);
Console.WriteLine(categoryGetBy2.Name);


Console.WriteLine("*** Course Add Test");
Course courseToAddedAndDeleted = new Course();
courseToAddedAndDeleted.Id = 4;
courseToAddedAndDeleted.InstructorId = 2;
courseToAddedAndDeleted.CategoryId = 1;
courseToAddedAndDeleted.Name = "Python";
courseToAddedAndDeleted.Description = "101";

courseManager.Add(courseToAddedAndDeleted);
foreach (var course in courses)
{
    Console.WriteLine(course.Name + " " + course.Description);
}


Console.WriteLine("*** Course Delete Test");
courseManager.Delete(courseToAddedAndDeleted);
foreach (var course in courses)
{
    Console.WriteLine(course.Name + " " + course.Description);
}


Console.WriteLine("*** Course Update Test");
Course courseToUpdate = new Course();
courseToUpdate.Id = 3;
courseToUpdate.InstructorId = 2;
courseToUpdate.CategoryId = 2;
courseToUpdate.Name = "JavaScript";
courseToUpdate.Description = "Angular";

courseManager.Update(courseToUpdate);

foreach (var course in courses)
{
    Console.WriteLine(course.Name+" "+course.Description);
}
