using Business.Abstracts;
using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class InstructorManager : IInstructorService
{
    private readonly IInstructorDal _ınstructorDal;

    public InstructorManager(IInstructorDal ınstructorDal)
    {
        _ınstructorDal = ınstructorDal;
    }

    public void Add(Instructor instructor)
    {
        _ınstructorDal.Add(instructor);
    }

    public void Delete(Instructor instructor)
    {
       _ınstructorDal.Delete(instructor);
    }

    public List<Instructor> GetAll()
    {
       return _ınstructorDal.GetAll();
    }

    public Instructor GetInstructorById(int id)
    {
        return _ınstructorDal.GetInstructorById(id);
    }

    public void Update(Instructor instructor)
    {
        _ınstructorDal.Update(instructor);
    }
}
