   M S B A M L   `   `   `  ����E  AVisitorLog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:VisitorLog
VisitorLog  5      =#clr-namespace:VisitorLog.ViewModelsVisitorLog.ViewModels  5      "    VisitorLog.Views.ExitControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:VisitorLog     5      2vm#clr-namespace:VisitorLog.ViewModels     5      
�������  � 	Resources  5
      7  1VisitorLog.ViewModels.EnterExitSelectionViewModel   InputOutputVM��%   &	          5   
   6A   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5      $��5* �6   6,   �� 5      $��1* �6   6,   �� 5      $��5* �6   6,   �� 5      $��1* �6   6,    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��0��6   $��1��6!   $��3��61   $��Center=�6E   $��Center=�6`   FDфиксация выхода(сопровождающее лицо)6�   �� 5   
   $��1��6   $��1��6   ��6/   �� *
Visitors+ �� SelectedItem 6P   �� *SelectedVisitor+��5      �� 5      .R�5       �� ��5!      `� 5"       �� StringFormat$ {0} {1} {2}��6+   .1�5#   "   ��  �� Path$ Surname�6*   �� 5$   "   $
 Name�6*   �� 5%   "   $ 
Patronymic�6*   5&      5(      5)      5+      �� 5,   
   $��1��6   $��3��6   ��6/   �� *Note+6G   �� 5-   
   $��3��6   $��3��6   #��[  6R   ��6.   �� *ChangeVMCommand+.��6�   ;9сохранитьПОДТВЕРДИТЬ ДЕЙСТВИЕ6�   5.      5/      