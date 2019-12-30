using FluCreate.dialog;
using FluCreate.log;
using FluCreate.sql;
using FluCreate.task;
using FluCreate.utils;
using FluCreate.viewModel;
using HLHTUpLoad.common;
using MahApps.Metro.Controls;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows;

namespace FluCreate
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private MainViewModel mainViewModel;
        private bool datebaseFlag = false;
        private FluDataCreate fluData;
        private SQLClient sqlClient;
        private bool isRunning;
        private TaskClient task;
        private Logger logger;
        private bool isMiniWin;
        private Loading loading;
        private System.Windows.Forms.NotifyIcon _notifyIcon = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitWin(object sender, RoutedEventArgs e)
        {
            try
            {

                sqlClient = new SQLClient();
                task = new TaskClient();
                logger = Logger.Instance;
                mainViewModel = new MainViewModel();
                loading = new Loading();
                mainViewModel.HqmsPath = OperateIniFile.read("FILESAVEPATH", "hqms", "");
                isMiniWin = Convert.ToBoolean(OperateIniFile.read("SETTING", "kjqdzxh", "false"));
                mainViewModel.FluPath = OperateIniFile.read("FILESAVEPATH", "flu", "");
                mainViewModel.BackUpPath = OperateIniFile.read("FILESAVEPATH", "backUp", "");
                sqlClient.ExecuteQuery("select 1;",CommandType.Text);
                this.log.Text += "数据库连接成功\n";
                logger.WriteLog("数据库连接成功");
                fluData = new FluDataCreate();
                mainViewModel.StartTime = DateTime.Now.ToString("yyyy-MM-dd");
                mainViewModel.EndTime = DateTime.Now.ToString("yyyy-MM-dd");
                this.fluPath.DataContext = mainViewModel;
                this.hqmsPath.DataContext = mainViewModel;
                this.backUpPath.DataContext = mainViewModel;
                this.startTime.DataContext = mainViewModel;
                this.endTime.DataContext = mainViewModel;
                if (isMiniWin)
                {
                    //隐藏窗体
                    this.WindowState = WindowState.Minimized;
                   
                }
            }
            catch (Exception ex)
            {
                this.log.Text += ex.Message;
                this.log.Text += "\n";
            }

        }

        private void StartApp(object sender, RoutedEventArgs e)
        {
            if (!isRunning)
            {
                task.Run();
                this.startMenu.IsEnabled = false;
                this.stopMenu.IsEnabled = true;
                isRunning = true;
                this.log.Text += "定时任务启动成功\n";
            }
            
        }

        private void StopApp(object sender, RoutedEventArgs e)
        {
            if (isRunning)
            {
                task.ShutDown();
                this.startMenu.IsEnabled = true;
                this.stopMenu.IsEnabled = false;
                isRunning = false;
                this.log.Text += "定时任务停止成功\n";
            }

        }

        private void ExitApp(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OpenSetSqlParam(object sender, RoutedEventArgs e)
        {
           DataBaseDialog dataBaseDialog =  new DataBaseDialog();
            dataBaseDialog.ShowDialog();
        }

        private void OpenSetFluParam(object sender, RoutedEventArgs e)
        {
            new TaskDialog().ShowDialog();
        }

        private void OpenSetStartParam(object sender, RoutedEventArgs e)
        {
            RunSettingDialog run = new RunSettingDialog();
            run.ShowDialog();
        }


        private void OpenHQMSFile(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            if (!string.IsNullOrEmpty(mainViewModel.HqmsPath))
            {
                dialog.SelectedPath = @"" + mainViewModel.HqmsPath;
            }
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.hqmsPath.Text = dialog.SelectedPath;
                mainViewModel.HqmsPath = dialog.SelectedPath;
                OperateIniFile.write("FILESAVEPATH", "hqms", mainViewModel.HqmsPath);
            }
        }

        private void OpenFluFile(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            if (!string.IsNullOrEmpty(mainViewModel.FluPath))
            {
                dialog.SelectedPath = @"" + mainViewModel.FluPath;
            }
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.fluPath.Text = dialog.SelectedPath;
                mainViewModel.FluPath = dialog.SelectedPath;
                OperateIniFile.write("FILESAVEPATH", "flu", mainViewModel.FluPath);
            }
        }


        private void OpenBackUpFile(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            if (!string.IsNullOrEmpty(mainViewModel.BackUpPath))
            {
                dialog.SelectedPath = @"" + mainViewModel.BackUpPath;
            }
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.backUpPath.Text = dialog.SelectedPath;
                mainViewModel.BackUpPath = dialog.SelectedPath;
                OperateIniFile.write("FILESAVEPATH", "backUp", mainViewModel.BackUpPath);
            }
        }

        private void CreateMZZYFlu(object sender, RoutedEventArgs e)
        {
            loading.ShowDialog();
        }

        private void CreateCYXJ(object sender, RoutedEventArgs e)
        {
            if (datebaseFlag)
            {
                MessageBox.Show("数据库连接失败");
            }
            else
            {
                string msg;
                fluData.CreateCYXJ(mainViewModel.StartTime, mainViewModel.EndTime, out msg);
                this.log.Text += msg;

            }
        }

        private void CreateSWJL(object sender, RoutedEventArgs e)
        {

        }

        private void CreateCYLGBL(object sender, RoutedEventArgs e)
        {

        }

        private void OpenLog(object sender, RoutedEventArgs e)
        {
            string path = Environment.CurrentDirectory + "\\Log\\";
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
            string nowTime = DateTime.Now.ToString("yyyy-MM-dd");
            string argument = System.IO.Path.Combine(path, nowTime+"\\log"+ nowTime+ ".log");
            if (!System.IO.File.Exists(argument))
            {
                System.IO.File.CreateText(argument);
            }
            //设置要启动的就用程序及参数
            ProcessStartInfo ps = new ProcessStartInfo("Notepad.exe", argument);
            ps.WindowStyle = ProcessWindowStyle.Normal;
            Process p = new Process();
            p.StartInfo = ps;
            p.Start();
            //等待启动完成，否则获取进程信息可能失败
            //p.WaitForInputIdle();

            //MessageBox.Show(Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(this.m_fileName)).Length.ToString());

            //创建新的Process组件的数组,并将它们与指定的进程名称（Notepad）的所有进程资源相关联.
            //Process[] myprocesses;
            //var fileName = System.IO.Path.GetFileNameWithoutExtension("Notepad.exe");
            //myprocesses = Process.GetProcessesByName(fileName);
            //foreach (Process p1 in myprocesses)
            //{
            //    //通过向进程主窗口发送关闭消息达到关闭进程的目的
            //    p1.CloseMainWindow();
            //    //等待1000毫秒
            //    //System.Threading.Thread.Sleep(1000);
            //    //释放与此组件关联的所有资源
            //    p1.Close();
            //}

            //MessageBox.Show(Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(this.m_fileName)).Length.ToString());

        }

        private void CloseLog(object sender, RoutedEventArgs e)
        {
            if (logger.createLog)
            {
                logger.createLog = false;
                this.logMenu.Header = "DeBug开启";
            }
            else
            {
                logger.createLog = true;
                this.logMenu.Header = "DeBug关闭";
            }
           
        }

        private void OpenAbout(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("联系方式：QQ726446180");
        }

        private void CreateYYJL(object sender, RoutedEventArgs e)
        {
            

            if (datebaseFlag)
            {
                MessageBox.Show("数据库连接失败");
            }
            else
            {
                string msg;
                fluData.CreateYYJL(mainViewModel.StartTime, mainViewModel.EndTime, out msg);
                this.log.Text += msg;

            }
        }

        private void CreateJYJL(object sender, RoutedEventArgs e)
        {
           
        }

        private void CreateBASY(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
