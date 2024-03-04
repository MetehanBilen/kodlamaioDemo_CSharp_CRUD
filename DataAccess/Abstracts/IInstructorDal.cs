using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts;

public interface IInstructorDal
{
    void Add(Instructor instructor);

    Instructor GetInstructorById(int id);
    List<Instructor> GetAll();

    void Update(Instructor instructor);

    void Delete(Instructor instructor);
}
