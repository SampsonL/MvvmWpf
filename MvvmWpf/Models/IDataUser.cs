using MvvmWpf.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmWpf.Models
{
    public interface IDataUser
    {
        void Add(UserInfo userinfo);
        void Update(UserInfo userinfo);
        void Remove(UserInfo userinfo);
        UserInfo GetById(int userId);
        ICollection<UserInfo> GetAll();
    }
}
