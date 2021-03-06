﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppDuolingoClone.Models;

namespace AppDuolingoClone.Interfaces
{
    public interface ILessonService
    {
        Task<IList<LessonGroup>> GetLessonsGroup();
    }
}
