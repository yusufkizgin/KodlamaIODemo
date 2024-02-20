using Entities.Conceretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        void Delete(Instructor instructor);
        void Update(Instructor instructor);
        void Add(Instructor instructor);

    }
}
