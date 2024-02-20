using DataAccess.Abstracts;
using Entities.Conceretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Conceretes
{
    public class InstructorDal : IInstructorDal
    {
        public void Add(Instructor instructor)
        {
            Console.WriteLine("Eğitmen Eklendi");
        }

        public void Delete(Instructor instructor)
        {
            Console.WriteLine("Eğitmen Silindi");
        }

        public void Update(Instructor instructor)
        {
            Console.WriteLine("Eğitmen Güncellendi");
        }
    }
}
