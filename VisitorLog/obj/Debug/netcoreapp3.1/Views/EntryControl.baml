   M S B A M L   `   `   `  ����E  AVisitorLog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:VisitorLog
VisitorLog  5      =#clr-namespace:VisitorLog.ViewModelsVisitorLog.ViewModels  5      #    VisitorLog.Views.EntryControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:VisitorLog     5      2vm#clr-namespace:VisitorLog.ViewModels     5      
�������  � 	Resources  5
      7  1VisitorLog.ViewModels.EnterExitSelectionViewModel   InputOutputSelectionVM  errorTemplate��%!  &	        &	        5   
   6J   �� 5   
   .R�5      �� 
���  ��$��2q�6'   ._�5      � .+�5      �� �� 5      
��� E��$��Center=�5       $��Right=�6;   $��
4, 0, 0, 0q�6W   ��5       �� *[0].ErrorContent+5   W   5      5      5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5      $��5* �6   6,   �� 5      $��1* �6   6,   �� 5      $��5* �6   6,   �� 5      $��1* �6   6,    � RowDefinitions 5   
   �� 5       6   �� 5!      6   �� 5"      6   �� 5#      6   �� 5$      6   �� 5%      6   �� 5&      6   .+�5(   
   �� $��0��6   $��1��6!   $��3��61   $��Center=�6E   $��Center=�6`   b`фиксация входа(посетитель? или сопровождающее лицо?)6�   �� 5)   
   $��1��6   $��1��6    =� ErrorTemplate# [ 5*      ��5)   /   �� *	Surname+ �� ValidatesOnExceptions$
 True�� �� UpdateSourceTrigger$ PropertyChanged=�5*   Z   �� 5+   
   $��3��6   $��1��6   # [ 5,      ��5+   /   �� *Name+$
 True��$ PropertyChanged=�5,   Z   �� 5-   
   $��5��6   $��1��6   # [ 5.      ��5-   /   �� *
Patronymic+$
 True��$ PropertyChanged=�5.   Z   �� 5/   
   $��1��6   $��3��6   # [ 50      ��5/   /   �� *DocumentNumber+$
 True��$ PropertyChanged=�50   Z   �� 51   
   $��3��6   $��3��6    ��60   �� *PurposesOfVisit+ �� SelectedItem 6X   �� *SelectedPurpose+6�   �� 52   
   $��4��6   $��3��6    ��60   �� *Organizations+ 6V   �� *SelectedOrganization+6�   �� 53   
   $��5��6   $��3��6    ��60   �� *	Employees+ 6R   �� *SelectedEmployee+��54      �� 55      .R�56      �� ��57      `� 58       �� StringFormat$ {0} {1} {2}��6+   .1�59   "   ��  �� Path$ Surname�6*   �� 5:   "   $
 Name�6*   �� 5;   "   $ 
Patronymic�6*   5<      5>      5?      5A      �� 5B   
   $��6��6   $��3��6   ��6.   �� *SaveAndChangeVMCommand+��5C      �� 	 �� Source#	 [  .��6i   сохранить5E      5F      5G      