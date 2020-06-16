using MvvmWpf.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Threading;
using MvvmWpf;
using System.Windows.Controls;
using System.Windows.Input;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace MvvmWpf.ViewModels
{
    class MainWindowViewModel : NotificationObject
    {
        
        private DispatcherTimer ShowTimer;
        //数据属性
        private string page;
        public string Page
        {
            get { return page; }
            set
            {
                page = value;
                this.RaisePropertyChanged("Page");
            }
        }
        private string background;
        public string Background
        {
            get { return background; }
            set
            {
                background = value;
                this.RaisePropertyChanged("Background");
            }
        }
        private string _timeContext;
        public string TimeContext
        {
            get
            {
                return _timeContext;
            }
            set
            {
                _timeContext = value;
                this.RaisePropertyChanged("TimeContext");
            }
        }
        private string commnicationStatus;
        private Dispatcher dispatcher;
        private string onlineBackGround;
        public string OnlineBackGround
        {
            get { return onlineBackGround; }
            set
            {
                onlineBackGround = value;
                this.RaisePropertyChanged("OnlineBackGround");
            }
        }
        public string CommnicationStatus
        {
            get { return commnicationStatus; }
            set
            {
                commnicationStatus = value;
                this.RaisePropertyChanged("CommnicationStatus");
            }
        }
        private string viewTextBlock;
        public string ViewTextBlock
        {
            get { return viewTextBlock; }
            set
            {
                viewTextBlock = value;
                this.RaisePropertyChanged("ViewTextBlock");
            }
        }



        //命令属性

        public DelegateCommand JobsCommand { get; set; }
        public DelegateCommand SystemCommand { get; set; }
        public DelegateCommand ChangeCommand { get; set; }
        //方法
        
        public void Change(object parameter)
        {
            if (this.Background != "Black")
            {
                this.Background = "Black";
            }
            else
            {
                this.Background = "Blue";
            }

        }
        public void ShowCurTimer(object sender, EventArgs e)
        {
            this.TimeContext = DateTime.Now.ToString("yyyy年MM月dd日");
            this.TimeContext += "\n";
            this.TimeContext += DateTime.Now.ToString("dddd");
            this.TimeContext += "  ";
            this.TimeContext += DateTime.Now.ToString("HH:mm:ss");
        }
        public void Systen(object parameter)
        {
            this.Page = "Views/page2.xaml";
            this.ViewTextBlock = "System";
        }
        public void Job(object parameter)
        {
            this.Page = "Views/page1.xaml";
            this.ViewTextBlock = "Jobs";
        }

        

        //构造函数
        public MainWindowViewModel()
        {

            this.JobsCommand = new DelegateCommand();
            this.JobsCommand.ExecuteAction = new Action<object>(this.Job);
            this.SystemCommand = new DelegateCommand();
            this.SystemCommand.ExecuteAction = new Action<object>(this.Systen);
            this.ChangeCommand = new DelegateCommand();
            this.ChangeCommand.ExecuteAction = new Action<object>(this.Change);
            ShowTimer = new DispatcherTimer();
            ShowTimer.Tick += ShowCurTimer;
            ShowTimer.Interval = new TimeSpan(0, 0, 0, 1);
            ShowTimer.Start();
            NetworkChange.NetworkAvailabilityChanged += new NetworkAvailabilityChangedEventHandler(NetworkChange_NetworkAvailabilityChanged);

        }

        private void NetworkChange_NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            bool availability = e.IsAvailable;
            if (availability == true)
            {
                //网络可用时
                NetworkAbility();
            }
            else
            {
                //网络不可用时
                NetworkChanged();
            }
        }
        //判断网络不可用状态
        private void NetworkChanged()
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            //判断是否有网络接口
            if (adapters != null)
            {
                Dispatcher.CurrentDispatcher.Invoke(new Action(() =>
                {

                    this.CommnicationStatus = "Offline";
                    this.OnlineBackGround = "Red";
                }));
            }
            else
            {
                Dispatcher.CurrentDispatcher.Invoke(new Action(() =>
                {
                    this.CommnicationStatus = "Disabled";
                    this.OnlineBackGround = "Red";
                }));
            }
        }
        //判断网络可用时状态
        private void NetworkAbility()
        {
            //判断是否能连接远程网
            string[] args = new[] { "47.100.12.182" };
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();
            // Use the default Ttl value which is 128,
            // but change the fragmentation behavior.
            options.DontFragment = true;
            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            PingReply reply = pingSender.Send(args[0], timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {

                Dispatcher.CurrentDispatcher.Invoke(new Action(() =>
                {
                    this.CommnicationStatus = "OnlineRemote";
                    //
                }));

            }
            else
            {
                Dispatcher.CurrentDispatcher.Invoke(new Action(() =>
                {
                    this.CommnicationStatus = "OnlineLocal";
                    this.OnlineBackGround = "Green";
                }));
            }
        }
        

    }
}
