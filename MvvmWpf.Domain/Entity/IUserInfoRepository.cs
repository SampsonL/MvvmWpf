using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmWpf.Domain.Entity
{
    public interface IUserInfoRepository
    {
        void Add(UserInfo userInfo );

        void AddMany(ICollection<UserInfo> userInfo);

        void Update(UserInfo userInfo);

        void Remove(UserInfo userInfo);

        UserInfo GetById(int userInfoId);

        ICollection<UserInfo> GetAll();

        long RowCount();
    }
}
