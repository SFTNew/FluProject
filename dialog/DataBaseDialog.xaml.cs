using FluCreate.utils;
using FluCreate.viewModel;
using MahApps.Metro.Controls;
using System.Windows;

namespace FluCreate.dialog
{
    /// <summary>
    /// DataBaseDialog.xaml 的交互逻辑
    /// </summary>
    public partial class DataBaseDialog : MetroWindow
    {
        private DateBaseViewModel dateBaseView;
        public DataBaseDialog()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            dateBaseView = new DateBaseViewModel();
            dateBaseView.DataBaseUrl = OperateIniFile.read("DATABASE", "local", "127.0.0.1");
            dateBaseView.DataBaseUser = OperateIniFile.read("DATABASE", "username", "sa");
            dateBaseView.DataBasePassword = OperateIniFile.read("DATABASE", "password", "6");
            dateBaseView.DataBaseCatalog = OperateIniFile.read("DATABASE", "catalog", "hisdata1");

            this.tbUrl.DataContext = dateBaseView;
            this.tbUser.DataContext = dateBaseView;
            this.tbPassword.DataContext = dateBaseView;
            this.tbCatalog.DataContext = dateBaseView;
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            OperateIniFile.write("DATABASE", "local", dateBaseView.DataBaseUrl);
            OperateIniFile.write("DATABASE", "username", dateBaseView.DataBaseUser);
            OperateIniFile.write("DATABASE", "password", dateBaseView.DataBasePassword);
            OperateIniFile.write("DATABASE", "catalog", dateBaseView.DataBaseCatalog);
            this.Close();
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
