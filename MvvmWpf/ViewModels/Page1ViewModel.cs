using MvvmWpf.Domain.Entity;
using MvvmWpf.Models;
using MvvmWpf.Views;
using NHibernate.Event;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MvvmWpf.ViewModels
{
    class Page1ViewModel: NotificationObject
    {

        DataUserDB dataUser = new DataUserDB();

        ICollection<UserInfo> _users = new ObservableCollection<UserInfo>();     
        public ICollection<UserInfo> Users
        {
            get { return _users; }
            set
            {
                if (_users == value)
                    return;

                _users = value;
                RaisePropertyChanged("Users");
            }
        }

        public Page1ViewModel()
        {

            UserInfo userInfo1 = new UserInfo()
            {
                Address = "北京",
                Age = 20,
                Gender = true,
                UserName = "张7"
            };

            UserInfo userInfo2 = new UserInfo()
            {
                Address = "南京",
                Age = 20,
                Gender = true,
                UserName = "张7"
            };
            UserInfo userInfo3 = new UserInfo()
            {
                Address = "南京",
                Age = 20,
                Gender = true,
                UserName = "张7"
            };
            UserInfo userInfo4 = new UserInfo()
            {
                Address = "南京",
                Age = 20,
                Gender = true,
                UserName = "张7"
            };
            UserInfo userInfo5 = new UserInfo()
            {
                Address = "南京",
                Age = 20,
                Gender = true,
                UserName = "张7"
            };
            UserInfo userInfo6 = new UserInfo()
            {
                Address = "南京",
                Age = 20,
                Gender = true,
                UserName = "张7"
            };
            UserInfo userInfo7 = new UserInfo()
            {
                Address = "南京",
                Age = 20,
                Gender = true,
                UserName = "张7"
            };
            UserInfo userInfo8 = new UserInfo()
            {
                Address = "南京",
                Age = 20,
                Gender = true,
                UserName = "张7"
            };
            UserInfo userInfo9 = new UserInfo()
            {
                Address = "南京",
                Age = 20,
                Gender = true,
                UserName = "张7"
            };
            UserInfo userInfo10 = new UserInfo()
            {
                Address = "南京",
                Age = 20,
                Gender = true,
                UserName = "张7"
            };
            Users.Add(userInfo1);
            Users.Add(userInfo2);
            Users.Add(userInfo3);
            Users.Add(userInfo4);
            Users.Add(userInfo5);
            Users.Add(userInfo6);
            Users.Add(userInfo7);
            Users.Add(userInfo8);
            Users.Add(userInfo9);
            Users.Add(userInfo10);

        //    Users = dataUser.GetAll();



        }
    }
}
