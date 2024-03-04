using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class InstructorDal : IInstructorDal
{
    List<Instructor> _instructors;
    public InstructorDal()
    {
        Instructor instructor1 = new Instructor();
        instructor1.Id = 1;
        instructor1.FirstName = "Metehan";
        instructor1.LastName = "Bilen";
        instructor1.Resume = "Endüstri Mühendisi";

        Instructor instructor2 = new Instructor();
        instructor2.Id = 2;
        instructor2.FirstName = "Mehmet";
        instructor2.LastName = "Bilen";
        instructor2.Resume = "Makine Mühendisi";


        _instructors = new List<Instructor> {instructor1,instructor2 };
    }
    public void Add(Instructor instructor)
    {
        _instructors.Add(instructor);
    }

    public void Delete(Instructor instructor)
    {
         _instructors.Remove(instructor);
    }

    public List<Instructor> GetAll()
    {
        return _instructors;   
    }

    public Instructor GetInstructorById(int id)
    {
        return _instructors.SingleOrDefault(i => i.Id == id);
    }

    public void Update(Instructor instructor)
    {
        Instructor instructorToUpdate = _instructors.SingleOrDefault(i => i.Id == instructor.Id);
        instructorToUpdate.Id = instructor.Id;
        instructorToUpdate.FirstName = instructor.FirstName;
        instructorToUpdate.LastName = instructor.LastName;
        instructorToUpdate.Resume = instructor.Resume;

    }
}
