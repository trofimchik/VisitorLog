   M S B A M L   `   `   `  ����E  AVisitorLog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:VisitorLog.ViewModelsVisitorLog.ViewModels  5      'clr-namespace:VisitorLog
VisitorLog  5	      9    3VisitorLog.Views.SecurityOfficerWorkingPanelControl   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2vm#clr-namespace:VisitorLog.ViewModels     5      a ]Syncfusion.SfGrid.WPF, Version=19.1500.0.66, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=19.1500.0.66, Culture=neutral, PublicKeyToken=3d67ed1f87d44c894
Syncfusion!http://schemas.syncfusion.com/wpf   5      
syncfusionsf   5      &localclr-namespace:VisitorLog   5	        � Triggers  5      :� 5   
    :� RoutedEvent$ Loaded��6   .[�5      �� .��5      �� .��5      W�  �� TargetProperty$ Opacity�5       W� From 0.05      	 W� To 1.06    g� Duration$ 0:0:1D�6#   5      5      5       � 	Resources 5      7  1VisitorLog.ViewModels.EnterExitSelectionViewModel   EnterExitSelectionVM��%   &	          5   
   6)   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��10* �6   6-   �� 5      $	��10* �6   6-   �� 5      $	��10* �6   6-    � RowDefinitions 5    
   �� 5!      $	��10* �6   6+   �� 5"      $��1* �6   6*   .+�5$   
   �� $��1��6   $��0��6!   $��3��61   6G   �� 5%   
   $��0��6   $��0��6"   $��3��62   .@�5&      �� $)��#Текущие посетители��6   .��5'      (  "Syncfusion.UI.Xaml.Grid.SfDataGrid  -   5        	  Name$	 sfGrid��5'   (   
   AllowFiltering$

 True��6_      ColumnSizer$
 Auto=�6u   (  "Syncfusion.UI.Xaml.Grid.SfGridBase   AutoGenerateColumns$ False��6�      ItemsSource 69   �� *CurrentVisits+   Columns 5)      0  *Syncfusion.UI.Xaml.Grid.GridTemplateColumn  ,  &Syncfusion.UI.Xaml.Grid.GridColumnBase   Width$ 52Q�68      MappingName$ 
Выход��6C   (  "Syncfusion.UI.Xaml.Grid.GridColumn   AllowFiltering$ False��6W      CellTemplate 5*      �� 5+   "   .R�5,   &   �� $
��exit��6.   0  *Syncfusion.UI.Xaml.Grid.FocusManagerHelper   FocusedElement$
 True��6=   ��5-      ��  �� Path$ DataContext.ExitCommand� �� ElementName$ sfGrid����6E   �� 5.   #   50      ,  &Syncfusion.UI.Xaml.Grid.GridTextColumn  51         
HeaderText$ Фамилия��64   $ Surname��6I     52      $ Имя��64   $
 Name��6E     53      $ Отчество��64   $ 
Patronymic��6J     54      $# Номер документа��64   $ DocumentNumber��6Q     56      $ Организация��64   $ OrgName��6M     57      $ Цель визита��64   $ Purpose��6M     58      $ Время входа��64   $ DateTimeOfEntry��6M     59      $ Примечание��64   $
 Note��6L      AllowEditing$
 True��6_   5<      5>      �� 5?      $.��(Журнал всех посещений��6   .��5@      �  5A      �� 5B      $��55 �6(   66   �� 5C      6*   .+�5E      �� $��0��6!    �� Orientation$ 
Horizontal=�6.   .+�5F      (	  "System.Windows.Controls.DatePicker	   	  Text$! Начало периода��6%    	  DisplayDateStart 
01/01/20206;    	  DisplayDateEnd 6Y   �� *EndingOfPeriodRemaining+ 	  SelectedDate 6�   �� *BeginningOfPeriodRemaining+6�   	  5G      $ Конец периода��6%    6:   �� *BeginningOfPeriodRemaining+ 6r   �� *	EndDate+ 6�   �� *EndingOfPeriodRemaining+6�   5H        5I      -   5        $	 sfGrid2��5I   ,   $��1��6=   $

 True��6r   $
 Auto=�6�   $ False��6�    6J   �� *RemainingVisits+ 5K        $ 52Q�6<   $ 
Выход��6G   $ False��6[    5L   "   �� 5M   &   .R�5N   *   �� $
��exit��62   $
 True��6A   ��5O      �� $ DataContext.ExitCommand�$ sf2Grid����6F   �� 5P   '   5R        5S      $ Фамилия��68   $ Surname��6M     5T      $ Имя��68   $
 Name��6I     5U      $ Отчество��68   $ 
Patronymic��6N     5V      $# Номер документа��68   $ DocumentNumber��6U     5W      $ Организация��68   $ OrgName��6Q     5X      $ Цель визита��68   $ Purpose��6Q     5Y      $ Время входа��68   $ DateTimeOfEntry��6Q     5Z      $ Примечание��68   $
 Note��6P   5\      5]      5^      5_      �� 5`   
   $��2��6   $��0��6   $��
Назад��5a   g   ��5`   .   �� *ChangeVMCommand+��5a      ��  �� Source# [  6g   �� 5b   
   $��2��6   $��2��6   $5��/Создание резервной копии.��6.   6T   5c      5d      