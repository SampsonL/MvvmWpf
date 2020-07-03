using MvvmWpf.Domain.Entity;
using MvvmWpf.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmWpf.Models
{
    public class MaterialDB : IMaterial
    {
        public MaterialRepository materialRepository = new MaterialRepository();
        public ICollection<T> GetAll<T>()
        {            
            try
            {
                return materialRepository.GetAll<T>();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
