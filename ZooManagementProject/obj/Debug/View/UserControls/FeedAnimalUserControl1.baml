   M S B A M L   `   `   `  ����O  KZooManagementProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:ZooManagementProject.View.UserControls&ZooManagementProject.View.UserControls  5      C    =ZooManagementProject.View.UserControls.FeedAnimalUserControl1   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Flocal4clr-namespace:ZooManagementProject.View.UserControls     5        � DataContext  5      �� *Main.MenuViewModel+   Locator �� Source# [  .��5      � .+�5   
   �� -   5         ��Name$ lbGroup��5      $��20 20 20 100q�5        HungryAnimalStyle#��[ 5      ��5      �� *HungyAnumal+5      �� 5   
   $��Bottom=�6   $
��Left=�6,   $��50��5      $	��100��5      $��
150 0 0 20q�6   $��Змінити час��5      ��5      �� *
ChangeTime+5      �� 5   
   $��Bottom=�6   $
��Left=�6,   $��Покормить��5      $��50��5      $��	20 0 0 20q�5      $	��100��5      ��5      �� *Feed+5      � 5"   
   $	��320��5#      $��80��5$      $��Right=�5%      $��Bottom=�5&      .+�5'      ��  �� Orientation$ 
Horizontal=�6   .+�5(      �� $��Місяць: ��6   $��50��6,     Basebtn#��[ 67   �� 5)       
 baseTb#��[ 61   ��6   �� *Month+61   �� 5*      $��Тиждень: ��6   $��60��6-   #��[ 68   �� 5+      #��[ 6/   $��0 0 0 0q�6O   ��6   �� *Day+6O   �� 5,      $��Година: ��6   $��50��6,   #��[ 67   �� 5-      #��[ 60   $��0 0 0 0q�6Q   ��6   �� *Hour+6Q   5.      5/      �� 52   
   $#��Невірний формат��6   $��Right=�6M   $��Bottom=�6i   ��6+   �� *
ErrorColor+6i   �� 55   
   $?��9Не вистачає їжі для всіх звірів��6   $��0 0 0 70q�6`   $��Center=�6r   $��Bottom=�6�   ��6;   �� *NotEnoughFood+6�   56      57      