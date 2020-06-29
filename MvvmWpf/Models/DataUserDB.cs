using MvvmWpf.Domain.Entity;
using MvvmWpf.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmWpf.Models
{
    public class DataUserDB : IDataUser
    {
        public IUserInfoRepository _userInfoRepository = new UserInfoRepository();

        public void Add(UserInfo userinfo)
        {
            _userInfoRepository.Add(userinfo);
        }

        public ICollection<UserInfo> GetAll()
        {
            try
            {
                return _userInfoRepository.GetAll();
            }
            catch (Exception exception)
            {
                throw;
            }
        }

        public UserInfo GetById(int userId)
        {
            return _userInfoRepository.GetById(userId);
        }

        public void Remove(UserInfo userinfo)
        {
            _userInfoRepository.Remove(userinfo);
        }

        public void Update(UserInfo userinfo)
        {
            _userInfoRepository.Update(userinfo);
        }
    }
}
