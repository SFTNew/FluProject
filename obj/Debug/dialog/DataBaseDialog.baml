   M S B A M L   `   `   `  ����D  @FluCreate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:FluCreate.dialogFluCreate.dialog  5   	   %    FluCreate.dialog.DataBaseDialog   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f;Controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   *localclr-namespace:FluCreate.dialog  5   	   -   5        (  "MahApps.Metro.Controls.MetroWindow   Name$	  win��5
       � Title$ DataBaseDialog��5   	   $
��auto��6    $
��auto��6.    � 
ResizeMode$ NoResize=�6;    � WindowStartupLocation$ CenterScreen=�6Q    � SizeToContent$ WidthAndHeight=�6w   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��数据库地址:��6   $��Center=�6*   �� 5      -   5         ��Name$ tbUrl��5      $	��200��6)   $��	10 0 0 0 q�65   ��6H   �� *DataBaseUrl+ �� Mode$ TwoWay=�6t   5      5      �� 5   
   $��1��6   .��5      �� $ 
Horizontal=�6   .+�5      �� $��数据库账号:��6   $��Center=�6*   �� 5      -   5        $ tbUser��5      $	��200��6*   $��	10 0 0 0 q�66   ��6J   �� *DataBaseUser+$ TwoWay=�6v   5      5       �� 5!   
   $��2��6   .��5"      �� $ 
Horizontal=�6   .+�5#      �� $��数据库密码:��6   $��Center=�6*   �� 5$      -   5        $ 
tbPassword��5$      $	��200��6.   $��	10 0 0 0 q�6:   ��6N   �� *DataBasePassword+$ TwoWay=�6~   5%      5&      �� 5'   
   $��3��6   .��5(      �� $ 
Horizontal=�6   .+�5)      �� $��数据库名称:��6   $��Center=�6*   �� 5*      -   5        $ 	tbCatalog��5*      $	��200��6-   $��	10 0 0 0 q�69   ��6M   �� *DataBaseCatalog+$ TwoWay=�6|   5+      5,      �� 5-   
   $ 
Horizontal=�6   $��4��6.   $��5q�6;   .+�5.      �� -   5        $��保存修改��5.      $	��120��6$   ���	#FFdede66
�������6Z   �� 5/      -   5        $��取消��5/      $	��120��6"   $��32 0 0 0q�6/   ���	#ff5566556X   50      51      52      