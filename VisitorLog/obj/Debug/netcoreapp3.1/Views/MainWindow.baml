   M S B A M L   `   `   `  ����E  AVisitorLog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:VisitorLog
VisitorLog  5   	   =#clr-namespace:VisitorLog.ViewModelsVisitorLog.ViewModels  5   	   3clr-namespace:VisitorLog.ViewsVisitorLog.Views  5   	   !    VisitorLog.Views.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:VisitorLog     5   	   2vm#clr-namespace:VisitorLog.ViewModels     5   	   /viewclr-namespace:VisitorLog.Views     5   	     � Title$  
MainWindow��5
   	   $	��800��6   $	��400��6(    � 	Resources 5       �� MergedDictionaries�� 5   
    5      %    5      7  1VisitorLog.ViewModels.EnterExitSelectionViewModel  5   
      KeyInputOutputVM  6)   9  3VisitorLog.ViewModels.SecurityOfficerLoginViewModel  5   
   SecurityOfficerLoginVM  6+   4  .VisitorLog.ViewModels.AdminLoginPanelViewModel  5   
   AdminLoginPanelVM  6&   �� 5   
    �� DataType"  6   .R�5      0   *VisitorLog.Views.EnterExitSelectionControl  5      �� 5   
   *  $VisitorLog.ViewModels.EntryViewModel"  6   .R�5      #   VisitorLog.Views.EntryControl  5      �� 5   
   )  #VisitorLog.ViewModels.ExitViewModel"  6   .R�5      "   VisitorLog.Views.ExitControl  5      �� 5    
   "  6   .R�5!      2	   ,VisitorLog.Views.SecurityOfficerLoginControl	  5"      �� 5#   
   @
  :VisitorLog.ViewModels.SecurityOfficerWorkingPanelViewModel" 
 6   .R�5$      9   3VisitorLog.Views.SecurityOfficerWorkingPanelControl  5%      �� 5&   
   "  6   .R�5'      -   'VisitorLog.Views.AdminLoginPanelControl  5(      �� 5)   
   /  )VisitorLog.ViewModels.AdminPanelViewModel"  6   .R�5*      (   "VisitorLog.Views.AdminPanelControl  5+       � DataContext 5.      ,  &VisitorLog.ViewModels.CurrentContentVM  5/   
   .��51      �  � ColumnDefinitions 52   
   �� 53      $��1* �6   6,   �� 54      $	��10* �6   6-   �� 55      $��1* �6   6,    � RowDefinitions 57   
   �� 58      $��1* �6   6*   �� 59      $	��10* �6   6+   �� 5:      $��1* �6   6*   .+�5=   
   �� $��1��6   $��1��6(   ��68   �� *CurrentContent+�� 5?   
   $��2��6   $��2��6!   ��6.   �� *ChangeVMCommand+��5@      ��   SecurityOfficerLoginVM �� Source# [ .��6]   ИКОНКА "ДОМОЙ"5A      �� 5B   
   $��0��6   $��2��6!   ��6.   �� *ChangeVMCommand+��5C      ��   AdminLoginPanelVM# [ .��6X   
админ6_   5D      5E      