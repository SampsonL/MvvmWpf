using MvvmWpf.Commands;
using MvvmWpf.Domain.Entity;
using MvvmWpf.Models;
using MvvmWpf.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace MvvmWpf.ViewModels
{
    public class Page1ViewModel: NotificationObject
    {

       
        MaterialDB materialDB = new MaterialDB();
        public static Window windows;

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

        public DelegateCommand CreateJobCommand { get; set; }
        public DelegateCommand RefreshCommand { get; set; }

        public Page1ViewModel()
        {

            TransferJobs = materialDB.GetAll<Transfer_Job>();
            this.CreateJobCommand = new DelegateCommand();
            this.CreateJobCommand.ExecuteAction = new Action<object>(this.CreateJob);

            this.RefreshCommand = new DelegateCommand();
            this.RefreshCommand.ExecuteAction = new Action<object>(this.Refresh);




        }

        private void Refresh(object obj)
        {
            TransferJobs = materialDB.GetAll<Transfer_Job>();
        }

        private void CreateJob(object obj)
        {
            windows = new AddDataWindow();
            windows.ShowDialog();
            
        }
    }
}
