using FluCreate.utils;
using FluCreate.viewModel;
using MahApps.Metro.Controls;
using System;
using System.Windows;

namespace FluCreate.dialog
{
    /// <summary>
    /// TaskDialog.xaml 的交互逻辑
    /// </summary>
    public partial class TaskDialog : MetroWindow
    {
        private TaskViewModel viewModel;

        public TaskDialog()
        {
            InitializeComponent();
        }

        private void InitWin(object sender, RoutedEventArgs e)
        {
            viewModel = new TaskViewModel();
            viewModel.Mzhzy = Convert.ToBoolean(OperateIniFile.read("TASK", "mzhzy", "true"));
            viewModel.Cyxj = Convert.ToBoolean(OperateIniFile.read("TASK", "cyxj", "true"));
            viewModel.Swjl = Convert.ToBoolean(OperateIniFile.read("TASK", "swjl", "true"));
            viewModel.Cylgba = Convert.ToBoolean(OperateIniFile.read("TASK", "cylgbl", "true"));
            viewModel.Jyjl = Convert.ToBoolean(OperateIniFile.read("TASK", "jyjl", "true"));
            viewModel.Yyjl = Convert.ToBoolean(OperateIniFile.read("TASK", "yyjl", "true"));
            viewModel.Cron = OperateIniFile.read("TASK", "cron", "100000");
            viewModel.StartTime = OperateIniFile.read("TASK", "startTime", "");

            this.startTime.DataContext = viewModel;
            this.tbCron.DataContext = viewModel;
            this.cbMzhzy.DataContext = viewModel;
            this.cbCyxj.DataContext = viewModel;
            this.cbCylgba.DataContext = viewModel;
            this.cbSwjl.DataContext = viewModel;
            this.cbJyjl.DataContext = viewModel;
            this.cbYyjl.DataContext = viewModel;
        }

        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            OperateIniFile.write("TASK", "mzhzy", viewModel.Mzhzy.ToString());
            OperateIniFile.write("TASK", "cyxj", viewModel.Cyxj.ToString());
            OperateIniFile.write("TASK", "swjl", viewModel.Swjl.ToString());
            OperateIniFile.write("TASK", "cylgbl", viewModel.Cylgba.ToString());
            OperateIniFile.write("TASK", "jyjl", viewModel.Jyjl.ToString());
            OperateIniFile.write("TASK", "yyjl", viewModel.Yyjl.ToString());
            OperateIniFile.write("TASK", "cron", viewModel.Cron);
            OperateIniFile.write("TASK", "startTime", viewModel.StartTime);
            this.Close();
        }
    }
}
