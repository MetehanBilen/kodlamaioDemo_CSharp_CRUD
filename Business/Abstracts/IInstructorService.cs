using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IInstructorService
{
    void Add(Instructor instructor);

    Instructor GetInstructorById(Guid id);
    List<Instructor> GetAll();

    void Update(Instructor instructor);
    void Delete(Instructor instructor);
}
