   M S B A M L   `   `   `  ����E  AVisitorLog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:VisitorLog.ViewModelsVisitorLog.ViewModels  5      3clr-namespace:VisitorLog.ViewsVisitorLog.Views  5      2    ,VisitorLog.Views.SecurityOfficerLoginControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2vm#clr-namespace:VisitorLog.ViewModels     5      0localclr-namespace:VisitorLog.Views     5      
�������  � 	Resources  5
      7  1VisitorLog.ViewModels.EnterExitSelectionViewModel   EnterExitSelectionVM��%   &	          5   
   6)   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5      $��5* �6   6,   �� 5      $��1* �6   6,    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��0��6   $��1��6!   $��Center=�61   $��Center=�6L   (&Панель сотрудника СБ6   �� 5   
   $��1��6   $��1��6!   $��Bottom=�61   $
��0 10q�6L   
Логин6a   �� 5   
   $��2��6   $��1��6   61   �� 5    
   $��3��6   $��1��6!   $��Bottom=�61   $
��0 10q�6L   Пароль6b   G� 5!   
   $��4��6   $��1��6#    G� PasswordChar$ *��63   6F   �� 5"   
   $��6��6   $��1��6   ��6.   �� *ChangeVMCommand+��5#      ��  �� Source# [  .��6g   Авторизация6t   5$      5%      