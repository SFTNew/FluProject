   M S B A M L   `   `   `  ����D  @FluCreate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:FluCreate.dialogFluCreate.dialog  5   	   !    FluCreate.dialog.TaskDialog   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f;Controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   *localclr-namespace:FluCreate.dialog  5   	   -   5        (  "MahApps.Metro.Controls.MetroWindow   Name$	  win��5
       � Title$ 定时执行��5   	   $
��auto��6   $
��auto��6$    � SizeToContent$ WidthAndHeight=�61    � WindowStartupLocation$ CenterScreen=�6P    � 
ResizeMode$ NoResize=�6u   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��5q�6.   .+�5      �� $��开始时间��6   $��Center=�6$   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ 	startTime��5      $��10 0 0 0q�6,      SelectedDateFormat$
 Long=�6>   	   SelectedDate	 6X   �� *	StartTime+
 �� Mode$
 TwoWay=�5      �� 5   
   $��1��6   $ 
Horizontal=�6"   $��5q�6<   .+�5      �� $��执行周期��6   $��Center=�6$   �� 5      -   5         ��Name$ tbCron��5      $��10 0 0 0q�6'   $	��140��69   ��6E   �� *Cron+$
 TwoWay=�5      �� 5   
   $��5q�6   $��2��6    .+�5      �� $��执行项目��6   �� 5      $ 
Horizontal=�6   $��0 10 0 0q�62   .+�5      �� -   5         ��Name$ cbMzhzy��5      $��门诊和在院流感��6,    d� 	IsChecked 6>   �� *Mzhzy+$
 TwoWay=��� 5      -   5        $ cbCyxj��5      $��出院小结��6+   $
��15 0q�6:    6H   �� *Cyxj+$
 TwoWay=��� 5       -   5        $ cbSwjl��5       $��死亡记录��6+   $
��15 0q�6:    6H   �� *Swjl+$
 TwoWay=��� 5!      -   5        $ cbCylgba��5!      $��出院流感病历��6-   $
��15 0q�6>    6L   �� *Cylgba+$
 TwoWay=��� 5"      -   5        $ cbJyjl��5"      $��检验记录��6+   $
��15 0q�6:    6H   �� *Jyjl+$
 TwoWay=��� 5#      -	   5        $ cbYyjl��5#      $��用药记录��6+    6;   �� *Yyjl+$
 TwoWay=�5$      5%      �� 5&   
   $��Right=�6   $��3��61   $ 
Horizontal=�6>   $
��5 10q�6W   .+�5'      �� -
   5        $��确定��5'      $��0 0 10 0q�6"   $	��120��64   6@   �� 5(      -   5        $��取消��5(      $	��120��6"   6.   5)      5*      5+      