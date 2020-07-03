﻿using MvvmWpf.Domain.Entity;
using MvvmWpf.Domain.Repositories;
using MvvmWpf.Models;
using MvvmWpf.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MvvmWpf.Views
{
    /// <summary>
    /// page1.xaml 的交互逻辑
    /// </summary>
    public partial class page1 : Page
    {
       
        public page1()
        {
            InitializeComponent();
            this.DataContext = new Page1ViewModel();
        }
    }
}
