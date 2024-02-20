﻿using Entities.Conceretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICategoryManager
    {
        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);
    }
}
