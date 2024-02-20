using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Conceretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concerets
{
    public class CourseManager : ICourseManager
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal) 
        { 
            _courseDal = courseDal;
        }
        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);

        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
