   M S B A M L   `   `   `  ����E  AVisitorLog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:VisitorLog
VisitorLog  5   	   =#clr-namespace:VisitorLog.ViewModelsVisitorLog.ViewModels  5   	   3clr-namespace:VisitorLog.ViewsVisitorLog.Views  5	   	   !    VisitorLog.Views.MainWindow   5   
   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:VisitorLog     5   	   2vm#clr-namespace:VisitorLog.ViewModels     5   	   /viewclr-namespace:VisitorLog.Views     5	   	   -   5        $��
mainWindow��5   
     � Title$  
MainWindow��5   	   $	��800��6   $	��400��6(    � WindowState$ 	Maximized=�65    � WindowStyle$
 None=�6M    � 	Resources 5      7  1VisitorLog.ViewModels.EnterExitSelectionViewModel   InputOutputVM9  3VisitorLog.ViewModels.SecurityOfficerLoginViewModel  SecurityOfficerLoginVM4  .VisitorLog.ViewModels.AdminLoginPanelViewModel  AdminLoginPanelVM �� DataType0   *VisitorLog.Views.EnterExitSelectionControl*  $VisitorLog.ViewModels.EntryViewModel#   VisitorLog.Views.EntryControl2   ,VisitorLog.Views.SecurityOfficerLoginControl@  :VisitorLog.ViewModels.SecurityOfficerWorkingPanelViewModel9	   3VisitorLog.Views.SecurityOfficerWorkingPanelControl-
   'VisitorLog.Views.AdminLoginPanelControl/  )VisitorLog.ViewModels.AdminPanelViewModel(   "VisitorLog.Views.AdminPanelControl-  'VisitorLog.ViewModels.AddNewSOViewModel&    VisitorLog.Views.AddNewSOControl��%d  &	        &	      &	 &     (�� 9     5      *, +)(�� k     5      *, +)(�� �     5      *, +)(�� �     5      *, +)(��     5      *, +)(�� 3    5       *, +)(�� e    5#      *, +)  5   
   6)     5   
   6+     5   
   6&   �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5      	  5      �� 5   
   "  6   .R�5      
  5      �� 5    
   "  6   .R�5!        5"      �� 5#   
   "  6   .R�5$        5%      5&      ��5'      �� 5(   
    �� 
TargetType" �6    �� BasedOn# [B�6$   .�5)      ��  �� Property � �� �� Value$ 26(�6)   5*      	 � DataContext	 5,      ,  &VisitorLog.ViewModels.CurrentContentVM  5-   
   .��5/      � 
 � ColumnDefinitions
 50   
   �� 51      $��1* �6   6,   �� 52      $	��10* �6   6-   �� 53      $��1* �6   6,    � RowDefinitions 55   
   �� 56      $��1* �6   6*   �� 57      $	��10* �6   6+   �� 58      $��1* �6   6*   .+�5;   
   �� $��1��6   $��1��6(   ��68   �� *CurrentContent+�� 5=   
   $��0��6   $��0��6!   $��
Домой��5>   ]   ��5=   .   �� *ChangeVMCommand+��5>      ��  �� Source# [ 5?      �� 5@   
   $��2��6   $��0��6!   $��
Админ��5A   X   ��5@   .   �� *ChangeVMCommand+��5A      �� # [ 6j   5B      5C      