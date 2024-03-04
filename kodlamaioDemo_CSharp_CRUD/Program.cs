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
Category deneme = categoryManager.GetCategoryById(new Guid("56a509ba-0155-41b3-b467-7bd519af2aab"));
Console.WriteLine(deneme.Name);


Console.WriteLine("*** Category Add Test");
Category categoryToAddedAndDeleted = new Category();
categoryToAddedAndDeleted.Id = new Guid("44d3956c-5e4f-4a2a-bab6-4a66a84a6959");
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
categoryToUpdate.Id = new Guid("44d3956c-5e4f-4a2a-bab6-4a66a84a6959");
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
Instructor instructorGetBy1 = instructorManager.GetInstructorById(new Guid("fa60a8bd-43f9-4cfc-86be-f207c9b274d0"));
Console.WriteLine(instructorGetBy1.FirstName);


Console.WriteLine("*** Instructor Add Test");
Instructor instructorToAddedAndDeleted = new Instructor();
instructorToAddedAndDeleted.Id = new Guid("803a7b0e-8f81-4db1-bcba-133a65fc1042");
instructorToAddedAndDeleted.FirstName = "Mt";
instructorToAddedAndDeleted.LastName = "Bln";
instructorToAddedAndDeleted.Resume = "Jr. Dev";

instructorManager.Add(instructorToAddedAndDeleted);
foreach (var instructor in ınstructors)
{
    Console.WriteLine("Id: " + instructor.Id + " || " + instructor.FirstName + " " + instructor.LastName + "  =>  " + instructor.Resume);
}

Console.WriteLine("*** Instructor Delete Test");
instructorManager.Delete(instructorToAddedAndDeleted);
foreach (var instructor in ınstructors)
{
    Console.WriteLine("Id: " + instructor.Id + " || " + instructor.FirstName + " " + instructor.LastName + "  =>  " + instructor.Resume);
}
Console.WriteLine("*** Instructor Update Test");

Instructor instructorToUpdate = new Instructor();
instructorToUpdate.Id = new Guid("ed25d983-8a87-4921-a173-3489b141bd8a");
instructorToUpdate.FirstName = "Mete";
instructorToUpdate.LastName = "Bilen";
instructorToUpdate.Resume = "Endüstri Mühendisi";
instructorManager.Update(instructorToUpdate);

foreach (var instructor in ınstructors)
{
    Console.WriteLine("Id: " + instructor.Id + " || " + instructor.FirstName + " " + instructor.LastName + "  =>  " + instructor.Resume);
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
Course courseGetBy2 = courseManager.GetCourseById(new Guid("d51bee89-3cd4-4f2c-9ede-8953c94c182c"));
Console.WriteLine(courseGetBy2.Name);


Console.WriteLine("*** Course Add Test");
Course courseToAddedAndDeleted = new Course();
courseToAddedAndDeleted.Id = new Guid("be562764-d226-4eda-82a6-a5294696877b");
courseToAddedAndDeleted.InstructorId = new Guid("ed25d983-8a87-4921-a173-3489b141bd8a");
courseToAddedAndDeleted.CategoryId = new Guid("56a509ba-0155-41b3-b467-7bd519af2aab");
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
courseToUpdate.Id = new Guid("b6e113c8-840d-44a8-8a2c-590b99975b93");
courseToUpdate.InstructorId = new Guid("fa60a8bd-43f9-4cfc-86be-f207c9b274d0");
courseToUpdate.CategoryId = new Guid("44d3956c-5e4f-4a2a-bab6-4a66a84a6959");
courseToUpdate.Name = "JavaScript";
courseToUpdate.Description = "Angular";

courseManager.Update(courseToUpdate);

foreach (var course in courses)
{
    Console.WriteLine(course.Name+" "+course.Description);
}
