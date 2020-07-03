using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmWpf.Domain.Entity
{
    interface IMaterialRepository
    {
        ICollection<T> GetAll<T>();
    }
    
}
