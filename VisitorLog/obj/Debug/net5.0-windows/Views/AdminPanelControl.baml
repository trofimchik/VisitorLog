   M S B A M L   `   `   `  ����E  AVisitorLog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:VisitorLog.ViewModelsVisitorLog.ViewModels  5      (    "VisitorLog.Views.AdminPanelControl   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      a ]Syncfusion.SfGrid.WPF, Version=19.1500.0.66, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=19.1500.0.66, Culture=neutral, PublicKeyToken=3d67ed1f87d44c894
Syncfusion!http://schemas.syncfusion.com/wpf   5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      2vm#clr-namespace:VisitorLog.ViewModels     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a;	behaviors+http://schemas.microsoft.com/xaml/behaviors  5        � Triggers  5      :� 5   
    :� RoutedEvent$ Loaded��6   .[�5      �� .��5      �� .��5      W�  �� TargetProperty$ Opacity�5       W� From 0.05      	 W� To 1.06    g� Duration$ 0:0:1D�6#   5      5      5       � 	Resources 5      9  3VisitorLog.ViewModels.SecurityOfficerLoginViewModel   SecurityOfficerLoginVM-  'VisitorLog.ViewModels.AddNewSOViewModel  
AddNewSOVM��%:   &	        &	        5   
   6+     5   
   6   5      .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5    
   �� 5!      $	��10* �6   6+   �� 5"      $��1* �6   6*   .+�5%   
   (  "Syncfusion.UI.Xaml.Grid.SfDataGrid  -   5        	  Name$	 sfGrid��5%   Q   $��3��6    $��0��64   $��0��6D   
   ColumnSizer$

 Auto=�5&       (  "Syncfusion.UI.Xaml.Grid.SfGridBase   AllowEditing$
 True��63      AutoGenerateColumns$ False��6G      GridValidationMode$ InEdit=�5'          ItemsSource 5%   a   �� *SecurityOfficers+*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5(      +  %Microsoft.Xaml.Behaviors.EventTrigger  5/         	EventName$ CurrentCellEndEdit��6)   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 50      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 64   ��  �� Path$ SaveChangesCommand�51         Columns 5:      0	  *Syncfusion.UI.Xaml.Grid.GridTemplateColumn	  ,
  &Syncfusion.UI.Xaml.Grid.GridColumnBase 
  Width$ 52Q�60    
  MappingName$ Удалить��6;   (  "Syncfusion.UI.Xaml.Grid.GridColumn   AllowFiltering$ False��6Q    
  CellTemplate 5;      �� 5<      .R�5=      �� $��delete��6%   0  *Syncfusion.UI.Xaml.Grid.FocusManagerHelper   FocusedElement$
 True��66   ��5>   %   �� $ DataContext.DeleteCommand� �� ElementName$ sfGrid����6k   �� 5?      5A      ,  &Syncfusion.UI.Xaml.Grid.GridTextColumn  5B       
  
HeaderText$ 
Логин��6,   $ Login��6?     5C      $ Пароль��6,   $ Password��6@   5E      �� 5H   
   $��1��6   $��0��6   $8��2Добавить нового сотрудника��5I   ]   ��5H   .   �� *ChangeVMCommand+��5I      ��  �� Source# [ 6�   �� 5L   
   $��1��6   $��2��6   $(��"Выйти из программы��6�   ��6.   �� *MainCloseButtonCommand+��6Y   �� $ 
mainWindow��6�   5M      5N      