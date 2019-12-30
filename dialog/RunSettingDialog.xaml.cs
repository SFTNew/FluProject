using FluCreate.utils;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace FluCreate.dialog
{
    /// <summary>
    /// RunSetting.xaml 的交互逻辑
    /// </summary>
    public partial class RunSettingDialog : MetroWindow
    {
        public bool kjqdIsCheck
        {
            get { return (bool)GetValue(kjqdIsCheckProperty); }
            set { SetValue(kjqdIsCheckProperty, value); }
        }

        public bool kjqdzxhIsCheck
        {
            get { return (bool)GetValue(kjqdzxhIsCheckProperty); }
            set { SetValue(kjqdzxhIsCheckProperty, value); }
        }
        public static readonly DependencyProperty kjqdIsCheckProperty = DependencyProperty.Register("kjqdIsCheck", typeof(bool), typeof(RunSettingDialog), new UIPropertyMetadata(false));
        public static readonly DependencyProperty kjqdzxhIsCheckProperty = DependencyProperty.Register("kjqdzxhIsCheck", typeof(bool), typeof(RunSettingDialog), new UIPropertyMetadata(false));
        public RunSettingDialog()
        {
            InitializeComponent();
        }

        private void InitWin(object sender, RoutedEventArgs e)
        {
            kjqdIsCheck = OperateIniFile.read("SETTING", "kjqd", "0").Equals("0") ? true : false;
            kjqdzxhIsCheck = OperateIniFile.read("SETTING", "kjqdzxh", "0").Equals("0") ? true : false;
        }

        private void cbKj_Checked(object sender, RoutedEventArgs e)
        {
            OperateIniFile.write("SETTING", "kjqd", kjqdIsCheck ? "0" : "1");
        }

        private void cbKjMin_Checked(object sender, RoutedEventArgs e)
        {
            OperateIniFile.write("SETTING", "kjqdzxh", kjqdzxhIsCheck ? "0" : "1");
        }
    }
}
