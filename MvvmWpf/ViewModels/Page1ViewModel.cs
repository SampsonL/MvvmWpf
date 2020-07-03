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

       
        MaterialDB materialDB = new MaterialDB();

        ICollection<Material> _materials = new ObservableCollection<Material>();
        public ICollection<Material> Materials
        {
            get { return _materials; }
            set
            {
                if (_materials == value)
                    return;

                _materials = value;
                RaisePropertyChanged("Materials");
            }
        }

        public Page1ViewModel()
        {
           
            
            



        }
    }
}
