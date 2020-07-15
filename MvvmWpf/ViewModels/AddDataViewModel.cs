using MvvmWpf.Commands;
using MvvmWpf.Domain.Entity;
using MvvmWpf.Models;
using NHibernate.Linq.Visitors.ResultOperatorProcessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmWpf.ViewModels;

namespace MvvmWpf.ViewModels
{
    class AddDataViewModel : NotificationObject
    {
        MaterialDB materialDB = new MaterialDB();


        private string _srcPositionId;

        public string SrcPositionId
        {
            get { return _srcPositionId; }
            set
            {
                _srcPositionId = value;
                this.RaisePropertyChanged("SrcPositionId");
            }
        }

        private string _destPositionId;

        public string DestPositionId
        {
            get { return _destPositionId; }
            set
            {
                _destPositionId = value;
                this.RaisePropertyChanged("DestPositionId");
            }
        }

        private string _transferJobType;

        public string TransferJobType
        {
            get { return _transferJobType; }
            set
            {
                _transferJobType = value;
                this.RaisePropertyChanged("TransferJobType");
            }
        }

        private string _transferJobActor;

        public string TransferJobActor
        {
            get { return _transferJobActor; }
            set
            {
                _transferJobActor = value;
                this.RaisePropertyChanged("TransferJobActor");
            }
        }

        private string _containerId;

        public string ContainerId
        {
            get { return _containerId; }
            set
            {
                _containerId = value;
                this.RaisePropertyChanged("ContainerId");
            }
        }

        public DelegateCommand AddDataCommand { get; set; }

        public AddDataViewModel()
        {
            this.AddDataCommand = new DelegateCommand();
            this.AddDataCommand.ExecuteAction = new Action<object>(this.AddData);
        }

        private void AddData(object obj)
        {
            //Transfer_Job transfer_Job = new Transfer_Job();
            //transfer_Job.id = ID;
            //transfer_Job.src_position_id = SrcPositionId;
            //transfer_Job.dest_position_id = DestPositionId;
            //transfer_Job.transfer_job_type = TransferJobType;
            //transfer_Job.transfer_job_actor = TransferJobActor;
            //transfer_Job.containerId = ContainerId;
            //materialDB.Add<Transfer_Job>(transfer_Job);
            //Page1ViewModel.windows.Close();
            
            string[] st = ContainerId.Split(',');
            int num = st.Length;
            for (int i = 0; i < num; i++)
            {
                Transfer_Job transfer_Job = new Transfer_Job();
                transfer_Job.id = "Job"+ DateTime.Now.Minute.ToString()+ DateTime.Now.Second.ToString()+i;
                transfer_Job.src_position_id = SrcPositionId;
                transfer_Job.dest_position_id = DestPositionId;
                transfer_Job.transfer_job_type = TransferJobType;
                transfer_Job.transfer_job_actor = TransferJobActor;
                transfer_Job.containerId = st[i];
                materialDB.Add<Transfer_Job>(transfer_Job);
                Page1ViewModel.windows.Close();
            }

        }
    }
}
