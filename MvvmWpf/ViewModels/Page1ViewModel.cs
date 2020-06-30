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
            Users = dataUser.GetAll();
            



        }
    }
}
