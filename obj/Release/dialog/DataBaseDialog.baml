   M S B A M L   `   `   `  ���� D  @FluCreate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:FluCreate.dialogFluCreate.dialog  %    FluCreate.dialog.DataBaseDialog   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f;Controls,http://metro.mahapps.com/winfx/xaml/controls  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  *localclr-namespace:FluCreate.dialog  -   (  "MahApps.Metro.Controls.MetroWindow   Name$	  win�� � Title$ DataBaseDialog��$
��auto��$
��auto�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � SizeToContent$ WidthAndHeight=�.��� $��10q� � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $��0��.����  �� Orientation$ 
Horizontal=�.+��� $��数据库地址:��$��Center=��� -    ��Name$ tbUrl��$	��200��$��	10 0 0 0 q����� *DataBaseUrl+ �� Mode$ TwoWay=��� $��1��.���� $ 
Horizontal=�.+��� $��数据库账号:��$��Center=��� -   $ tbUser��$	��200��$��	10 0 0 0 q����� *DataBaseUser+$ TwoWay=��� $��2��.���� $ 
Horizontal=�.+��� $��数据库密码:��$��Center=��� -   $ 
tbPassword��$	��200��$��	10 0 0 0 q����� *DataBasePassword+$ TwoWay=��� $��3��.���� $ 
Horizontal=�.+��� $��数据库名称:��$��Center=��� -   $ 	tbCatalog��$	��200��$��	10 0 0 0 q����� *DataBaseCatalog+$ TwoWay=��� $ 
Horizontal=�$��4��$��5q�.+��� -   $��保存修改��$	��120�����	#FFdede66
��������� -   $��取消��$	��120��$��32 0 0 0q����	#ff556655