using DataAccess.Abstracts;
using Entities.Conceretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Conceretes
{
    public class CategoryDal : ICategoryDal
    {
        public void Add(Category category)
        {
            Console.WriteLine("Kategori Eklendi");
        }

        public void Delete(Category category)
        {
            Console.WriteLine("Kategori Silindi");
        }

        public void Update(Category category)
        {
            Console.WriteLine("Kategori Güncellendi");
        }
    }
}
