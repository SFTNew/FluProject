   M S B A M L   `   `   `  ���� D  @FluCreate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:FluCreate.dialogFluCreate.dialog  !    FluCreate.dialog.TaskDialog   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f;Controls,http://metro.mahapps.com/winfx/xaml/controls  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  *localclr-namespace:FluCreate.dialog  -   (  "MahApps.Metro.Controls.MetroWindow   Name$	  win�� � Title$ 定时执行��$
��auto��$
��auto�� � SizeToContent$ WidthAndHeight=� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�.��� $��10q� � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+���  �� Orientation$ 
Horizontal=�$��5q�.+��� $��开始时间��$��Center=�(  "System.Windows.Controls.DatePicker  -     Name$ 	startTime��$��10 0 0 0q�   SelectedDateFormat$
 Long=�	   SelectedDate	 �� *	StartTime+
 �� Mode$
 TwoWay=��� $��1��$ 
Horizontal=�$��5q�.+��� $��执行周期��$��Center=��� -    ��Name$ tbCron��$��10 0 0 0q�$	��140������ *Cron+$
 TwoWay=��� $��5q�$��2��.+��� $��执行项目���� $ 
Horizontal=�$��0 10 0 0q�.+��� -    ��Name$ cbMzhzy��$��门诊和在院流感�� d� 	IsChecked �� *Mzhzy+$
 TwoWay=��� -   $ cbCyxj��$��出院小结��$
��15 0q� �� *Cyxj+$
 TwoWay=��� -   $ cbSwjl��$��死亡记录��$
��15 0q� �� *Swjl+$
 TwoWay=��� -   $ cbCylgba��$��出院流感病历��$
��15 0q� �� *Cylgba+$
 TwoWay=��� -   $ cbJyjl��$��检验记录��$
��15 0q� �� *Jyjl+$
 TwoWay=��� -	   $ cbYyjl��$��用药记录�� �� *Yyjl+$
 TwoWay=��� $��Right=�$��3��$ 
Horizontal=�$
��5 10q�.+��� -
   $��确定��$��0 0 10 0q�$	��120���� -   $��取消��$	��120��