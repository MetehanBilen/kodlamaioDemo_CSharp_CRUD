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
        course1.Id = 1;
        course1.InstructorId = 1;
        course1.CategoryId = 1;
        course1.Name = "C#";
        course1.Description = ".Net 8.0";

        Course course2 = new Course();
        course2.Id = 2;
        course2.InstructorId = 1;
        course2.CategoryId = 1;
        course2.Name = "Java";
        course2.Description = "101";


        Course course3 = new Course();
        course3.Id = 3;
        course3.InstructorId = 2;
        course3.CategoryId = 2;
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

    public Course GetCourseById(int id)
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
