using MvvmWpf.Domain.Entity;
using MvvmWpf.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmWpf.ViewModels
{
    class Page2ViewModel : NotificationObject
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
        ICollection<Position> _positions = new ObservableCollection<Position>();
        public ICollection<Position> Positions
        {
            get { return _positions; }
            set
            {
                if (_positions == value)
                    return;

                _positions = value;
                RaisePropertyChanged("Positions");
            }
        }
        ICollection<Rack> _racks = new ObservableCollection<Rack>();
        public ICollection<Rack> Racks
        {
            get { return _racks; }
            set
            {
                if (_racks == value)
                    return;

                _racks = value;
                RaisePropertyChanged("Racks");
            }
        }
        ICollection<Transfer_Job> _transferJobs = new ObservableCollection<Transfer_Job>();
        public ICollection<Transfer_Job> TransferJobs
        {
            get { return _transferJobs; }
            set
            {
                if (_transferJobs == value)
                    return;

                _transferJobs = value;
                RaisePropertyChanged("TransferJobs");
            }
        }



        public Page2ViewModel()
        {
            ICollection<Material> materials = materialDB.GetAll<Material>();
            Materials = materials;
            Positions = materialDB.GetAll<Position>();
            Racks = materialDB.GetAll<Rack>();
            TransferJobs = materialDB.GetAll<Transfer_Job>();
        }
    }
}
