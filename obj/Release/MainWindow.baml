   M S B A M L   `   `   `  ���� T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  D @FluCreate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FluCreate	FluCreate    FluCreate.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:FluCreate     -     � Title$*  $宇航流感数据文件生成系统��$	��450��$	��600��(   "MahApps.Metro.Controls.MetroWindow    IsMaxRestoreButtonEnabled .   � WindowStartupLocation$ CenterScreen=�.���  � RowDefinitions �� $
��auto ��� $��1* �.+�o� $��0��$��黑体)�$��14(�.@�m� -   $��运行��.@�m� -    m�Name$ 	startMenu��$��启动��m� -   $ stopMenu��$��停止��{�.  m� -   $��退出��m� $��配置��.@�m� -   $��数据库连接参数��m� -   $��定时文件生成��m� -   $��启动设置��m� $��帮助��.@�m� -	   $��查看日记��m� -
   $ logMenu��$��DeBug关闭��m� -   $��关于我们��� $��1�� �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $��1* �.+��� $��0�� �� Orientation$ 
Horizontal=�$	��0 5q�.+��� $��HQMS数据生成目录:��$	��125���� -    ��Name$ hqmsPath��$	��400��$	��5 0q�{�.  ���� *
HqmsPath+ �� Mode$ TwoWay=��� -   $	��...���� $��1��$ 
Horizontal=�$	��0 5q�.+��� $��流感数据生成目录:��$	��125���� -   $ fluPath��$	��400��$	��5 0q�{�.  ���� *	FluPath+$ TwoWay=��� -   $	��...���� $��2��$ 
Horizontal=�$	��0 5q�.+��� $��流感数据备份目录:��$	��125���� -   $ 
backUpPath��$	��400��$	��5 0q�{�.  ���� *
BackUpPath+$ TwoWay=��� -   $	��...���� ���	#33333333$��1q�$��3��$	��0 5q�._��� .+��� $ 
Horizontal=�$	��5 5q�.+��� $��起始日期��$��Center=�(  "System.Windows.Controls.DatePicker  -     Name$ 	startTime��$	��5 0q�	   SelectedDateFormat$	 Short=�
   SelectedDate
 �� *	StartTime+$ TwoWay=��� $��结束日期��$��Center=�  -   $ endTime��$	��5 0q�$	 Short=�
 �� *	EndTime+$ TwoWay=��� $��---记录生成---��$	��5 0q�� $	��5 5q�.+��� -   $��门诊和在院流感��$	��5 0q��� -   $��出院小结��$	��5 0q��� -   $��死亡记录��$	��5 0q��� -   $��出院流感病历��$	��5 0q��� -   $��检验记录��$	��5 0q��� -   $��用药记录���� -   $	 log�� �� 
IsReadOnly . $��4��$��5q� �� TextWrapping$
 Wrap=�$��Visible=�.��