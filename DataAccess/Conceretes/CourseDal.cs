using DataAccess.Abstracts;
using Entities.Conceretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Conceretes
{
    public class CourseDal : ICourseDal
    {
        public void Add(Course course)
        {
            Console.WriteLine("Kurs Eklendi");
        }

        public void Delete(Course course)
        {
            Console.WriteLine("Kurs Silindi");
        }

        public void Update(Course course)
        {
            Console.WriteLine("Kurs Güncellendi");
        }
    }
}
