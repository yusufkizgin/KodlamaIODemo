﻿using Entities.Conceretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseManager
    {
        void Add(Course course);
        void Delete(Course course);
        void Update(Course course);

    }
}
