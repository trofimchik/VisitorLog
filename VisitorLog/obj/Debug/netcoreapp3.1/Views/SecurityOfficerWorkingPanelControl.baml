   M S B A M L   `   `   `  ����E  AVisitorLog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:VisitorLog
VisitorLog  5      9    3VisitorLog.Views.SecurityOfficerWorkingPanelControl   5      a ]Syncfusion.SfGrid.WPF, Version=19.1310.0.66, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=19.1310.0.66, Culture=neutral, PublicKeyToken=3d67ed1f87d44c894
Syncfusion!http://schemas.syncfusion.com/wpf   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      
syncfusionsf     5      *localclr-namespace:VisitorLog     5      
�������  � 	Resources  5
      ��%    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��10* �6   6-   �� 5      $	��10* �6   6-   �� 5      $	��10* �6   6-    � RowDefinitions 5   
   �� 5      $	��10* �6   6+   �� 5      $��1* �6   6*   .+�5   
   �� $��1��6   $��0��6!   $��3��61   sqтута смена контролов, в зависимости от выбранного пункта меню6�   �� 5   
   $��2��6   $��0��6   $��3��6.   .��6B   1/Создание резервной копии.6]   �� 5   
   $��0��6   $��0��6"   $��3��62   .@�5      �� $)��#Текущие посетители��6   .��5      (  "Syncfusion.UI.Xaml.Grid.SfDataGrid  -   5          Name$ sfGrid��5   (      AllowFiltering$
 True��6_      ColumnSizer$
 Auto=�6u   (  "Syncfusion.UI.Xaml.Grid.SfGridBase   AutoGenerateColumns$ False��6�      ItemsSource 69   �� *CurrentVisits+   Columns 5      0  *Syncfusion.UI.Xaml.Grid.GridTemplateColumn  ,  &Syncfusion.UI.Xaml.Grid.GridColumnBase	   Width$	 52Q�68   
   MappingName$
 
Выход��6C   (  "Syncfusion.UI.Xaml.Grid.GridColumn   AllowFiltering$ False��6W      CellTemplate 5      �� 5   "   .R�5    &   �� $
��exit��6.   0  *Syncfusion.UI.Xaml.Grid.FocusManagerHelper   FocusedElement$
 True��6=   ��5!      ��  �� Path$ DataContext.ExitCommand� �� ElementName$ sfGrid����6E   �� 5"   #   5$      ,  &Syncfusion.UI.Xaml.Grid.GridTextColumn  5%         
HeaderText$ Фамилия��64   $
 Surname��6I     5&      $ Имя��64   $

 Name��6E     5'      $ Отчество��64   $
 
Patronymic��6J     5(      $# Номер документа��64   $
 DocumentNumber��6Q     5*      $ Организация��64   $
 OrgName��6M     5+      $ Цель визита��64   $
 Purpose��6M     5,      $ Время входа��64   $
 DateTimeOfEntry��6M     5-      $ Примечание��64   $

 Note��6L   50      52      �� 53      $.��(Журнал всех посещений��6   .��54      �  55      �� 56      $��30 �6(   66   �� 57      6+   .+�59      ��  �� Orientation$ 
Horizontal=�6!   .+�5:      (  "System.Windows.Controls.DatePicker     Text$! Начало периода��6%      DisplayDateStart 
01/01/20206;      DisplayDateEnd 6Y   �� *EndingOfPeriodRemaining+   SelectedDate 6�   �� *BeginningOfPeriodRemaining+6�     5;      $ Конец периода��6%    
01/01/20306r    6:   �� *BeginningOfPeriodRemaining+ 6�   �� *EndingOfPeriodRemaining+6�   5<        5=      -   5        $ sfGrid2��5=   ,   $��0��6=   $��1��6M   $
 True��6�   $
 Auto=�6�   $ False��6�    6Z   �� *RemainingVisits+ 5?        $	 52Q�6<   $
 
Выход��6G   $ False��6[    5@   "   �� 5A   &   .R�5B   *   �� $
��exit��62   $
 True��6A   ��5C      �� $ DataContext.ExitCommand�$ sf2Grid����6F   �� 5D   '   5F        5G      $ Фамилия��68   $
 Surname��6M     5H      $ Имя��68   $

 Name��6I     5I      $ Отчество��68   $
 
Patronymic��6N     5J      $# Номер документа��68   $
 DocumentNumber��6U     5L      $ Организация��68   $
 OrgName��6Q     5M      $ Цель визита��68   $
 Purpose��6Q     5N      $ Время входа��68   $
 DateTimeOfEntry��6Q     5O      $ Примечание��68   $

 Note��6P   5R      5S      5T      5U      5V      5W      