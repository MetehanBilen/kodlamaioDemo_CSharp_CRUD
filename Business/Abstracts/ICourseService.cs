using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface ICourseService
{
    void Add(Course course);

    Course GetCourseById(Guid id);
    List<Course> GetAll();

    void Update(Course course);
    void Delete(Course course);
}
