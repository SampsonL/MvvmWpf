﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmWpf.Domain.Entity
{
    interface IMaterialRepository
    {
        ICollection<T> GetAll<T>();

        void Add<T>(T t);
        ICollection<T> GetById<T>(string id);
        ICollection<T> GetByid<T>(string id);
        ICollection<T> GetByMaterialId<T>(string id);
        ICollection<T> GetByMaterialid<T>(string id);
        ICollection<T> GetAllByPositionId<T>();
    }
    
}
