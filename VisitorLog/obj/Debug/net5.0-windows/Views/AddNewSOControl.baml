   M S B A M L   `   `   `  ����E  AVisitorLog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:VisitorLog.ViewsVisitorLog.Views  5      =#clr-namespace:VisitorLog.ViewModelsVisitorLog.ViewModels  5      &     VisitorLog.Views.AddNewSOControl   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:VisitorLog.Views     5      2vm#clr-namespace:VisitorLog.ViewModels     5        � 	Resources  5
      /  )VisitorLog.ViewModels.AdminPanelViewModel   AdminPanelVM  errorTemplate��%!  &	        &	        5   
   68   �� 5   
   .R�5      �� 
���  ��$��2q�6'   ._�5      � .+�5      �� �� 5      
��� E��$��Center=�5       $��Right=�6;   $��
4, 0, 0, 0q�6W   ��5       �� *[0].ErrorContent+5   W   5      5      5      5      .��5      �  � ColumnDefinitions 5    
   �� 5!      $��1* �6   6,   �� 5"      $��1* �6   6,   �� 5#      $��1* �6   6,   �� 5$      $��1* �6   6,   �� 5%      $��1* �6   6,    � RowDefinitions 5'   
   �� 5(      $��6* �6   6*   �� 5)      $��1* �6   6*   .+�5+   
   �� $��1��6   $��0��6%   $��3��62   $��Center=�6F   .+�5,      �� $��Center=�6   $��Center=�63   +)Добавление сотрудника6g   �� 5-      $��Center=�6   $��Center=�63   
Логин6W   �� 5.       =� ErrorTemplate# [ 5/      ��5.      �� *Login+ �� ValidatesOnExceptions$
 True�� �� UpdateSourceTrigger$ PropertyChanged=�5/   Z   �� 51      $��Center=�6   $��Center=�63   Пароль6X   �� 52      # [ 53      ��52      �� *
Password+$
 True��$ PropertyChanged=�53   Z   55      �� 57   
   $��0��6   $��1��6!   $��2��6.   $��Отмена��58   _   ��57   B   �� *ChangeVMCommand+��58      ��  �� Source# [  6_   �� 59   
   $��3��6   $��1��6!   $��2��6.   $��Сохранить��5:   _   ��59   B   �� *SaveAndChangeVMCommand+��5:      �� # [  6_   5E      5H      