using MvvmWpf.Commands;
using MvvmWpf.Domain.Entity;
using MvvmWpf.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MvvmWpf.ViewModels
{
    class Page2ViewModel : NotificationObject
    {
        MaterialDB materialDB = new MaterialDB();

        private string _inputId;

        public string InputId
        {
            get { return _inputId; }
            set
            {
                _inputId = value;
                this.RaisePropertyChanged("InputId");
            }
        }


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
        ICollection<Container> _containers = new ObservableCollection<Container>();
        public ICollection<Container> Containers
        {
            get { return _containers; }
            set
            {
                if (_containers == value)
                    return;

                _containers = value;
                RaisePropertyChanged("Containers");
            }
        }

        //查询返回值界面属性
        ICollection<Material> _materialsById = new ObservableCollection<Material>();
        public ICollection<Material> MaterialsById  
        {
            get { return _materialsById; }
            set
            {
                if (_materialsById == value)
                    return;

                _materialsById = value;
                RaisePropertyChanged("MaterialsById");
            }
        }
        ICollection<Container> _containersById = new ObservableCollection<Container>();
        public ICollection<Container> ContainersById
        {
            get { return _containersById; }
            set
            {
                if (_containersById == value)
                    return;

                _containersById = value;
                RaisePropertyChanged("ContainersById");
            }
        }

        ICollection<Container> _containersByPositionId = new ObservableCollection<Container>();
        public ICollection<Container> ContainersByPositionId
        {
            get { return _containersByPositionId; }
            set
            {
                if (_containersByPositionId == value)
                    return;

                _containersByPositionId = value;
                RaisePropertyChanged("ContainersByPositionId");
            }
        }



        //命令属性
        public DelegateCommand FindCommand { get; set; }


        public Page2ViewModel()
        {
            //获取数据
      //      Materials = materialDB.GetAll<Material>();
            
            Positions = materialDB.GetAll<Position>();
            ContainersByPositionId = materialDB.GetAllByPositionId<Container>();
       //     Racks = materialDB.GetAll<Rack>();
       //       TransferJobs = materialDB.GetAll<Transfer_Job>();
       //      Containers = materialDB.GetAll<Container>();
       //命令操作
            this.FindCommand = new DelegateCommand();
            this.FindCommand.ExecuteAction = new Action<object>(FindByid);

            //选中行事件
            

        }

        private void FindByid(object obj)
        {
            string id = InputId;
            if (id == null)
            {
                ContainersById = materialDB.GetAll<Container>();
                MaterialsById = materialDB.GetAll<Material>();
            }
            else
            {
                //    MaterialsById = materialDB.GetById<Material>(id);
                if (materialDB.GetById<Container>(id) != null)
                {
                    ContainersById = materialDB.GetById<Container>(id);
                    //获取查询数据的material_id
                    var container = ContainersById.FirstOrDefault();
                    var containerId = container.id;
                    MaterialsById = materialDB.GetByid<Material>(containerId);
                }
                else
                {
                    MaterialsById = materialDB.GetByMaterialId<Material>(id);
                    var material = MaterialsById.FirstOrDefault();
                    var containerid = material.containerId;
                    ContainersById = materialDB.GetByMaterialid<Container>(containerid);
                }
            }
            
        }
    }
}
