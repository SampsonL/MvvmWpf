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

        public void Add<T>(T t)
        {
            try
            {
                materialRepository.Add<T>(t);
            }
            catch (Exception)
            {

                throw;
            }
        }

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

        public ICollection<T> GetById<T>(string id)
        {
            return materialRepository.GetById<T>(id);
        }

        public ICollection<T> GetByid<T>(string id)
        {
            return materialRepository.GetByid<T>(id);
        }

        public ICollection<T> GetByMaterialId<T>(string id)
        {
            return materialRepository.GetByMaterialId<T>(id);
        }

        public ICollection<T> GetByMaterialid<T>(string id)
        {
            return materialRepository.GetByMaterialid<T>(id);
        }
        public ICollection<T> GetAllByPositionId<T>()
        {
            return materialRepository.GetAllByPositionId<T>();
        }
    }
}
