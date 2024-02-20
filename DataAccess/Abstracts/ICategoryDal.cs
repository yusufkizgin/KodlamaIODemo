﻿using Entities.Conceretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        void Delete(Category category);
        void Add(Category category);
        void Update(Category category);

    }
}
