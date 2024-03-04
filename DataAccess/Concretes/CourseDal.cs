using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class CourseDal : ICourseDal
{
    List<Course> _courses;
    public CourseDal()
    {
        Course course1 = new Course();
        course1.Id = new Guid("929b6fc5-7fc4-47d4-908f-927df1a88193");
        course1.InstructorId = new Guid("ed25d983-8a87-4921-a173-3489b141bd8a");
        course1.CategoryId = new Guid("56a509ba-0155-41b3-b467-7bd519af2aab");
        course1.Name = "C#";
        course1.Description = ".Net 8.0";

        Course course2 = new Course();
        course2.Id = new Guid("d51bee89-3cd4-4f2c-9ede-8953c94c182c");
        course2.InstructorId = new Guid("ed25d983-8a87-4921-a173-3489b141bd8a");
        course2.CategoryId = new Guid("56a509ba-0155-41b3-b467-7bd519af2aab");
        course2.Name = "Java";
        course2.Description = "101";


        Course course3 = new Course();
        course3.Id = new Guid("b6e113c8-840d-44a8-8a2c-590b99975b93");
        course3.InstructorId = new Guid("fa60a8bd-43f9-4cfc-86be-f207c9b274d0");
        course3.CategoryId = new Guid("44d3956c-5e4f-4a2a-bab6-4a66a84a6959");
        course3.Name = "JavaScript";
        course3.Description = "ReactJS";

        _courses = new List<Course> { course1,course2,course3};  
    }
    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public void Delete(Course course)
    {
        _courses.Remove(course);
    }

    public List<Course> GetAll()
    {
        return _courses;
    }

    public Course GetCourseById(Guid id)
    {
        return _courses.SingleOrDefault(c => c.Id == id);
    }

    public void Update(Course course)
    {
        Course courseToUpdate = _courses.SingleOrDefault(c => c.Id == course.Id);
        courseToUpdate.Id = course.Id;
        courseToUpdate.CategoryId = course.CategoryId;
        courseToUpdate.InstructorId = course.InstructorId;
        courseToUpdate.Name = course.Name;
        courseToUpdate.Description = course.Description;
     
        
    }
}
