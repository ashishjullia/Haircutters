   M S B A M L   `   `   `  ����B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  5   	       Project.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Project     5   	   -   5          �Name$  
mainWindow��5   	    � Title$ Haircutters��5   	   $��563.326��6   $��807.333��6.   .��5
      �  � 	Resources 5   
      Project.ColourFormatter   FormatConverter��%   &	          5      6$   5      .+�5   
   o� $
��Left=�6   $��27��6*   $	��Top=�66   $	��793��6N   .@�5      m� -   5         m�Name$ miFile��5      $��16(�6'   $
��File��65   .@�5      m� -   5        $ 
miFileSave��5      $
��Save��6/   6=   m� 5      -   5        $ 
miFileLoad��5      $
��Load��6/   6=   m� 5      -   5        $ miFileClear��5      $��Clear��60   6?   5      m� 5      -   5        $ miNewAppointment��5      $��16(�61   $��New appointment��6?   6X   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgFutureAppointments��5      $
��Left=�61   $	��343��6L   $��
10,147,0,0q�6Y   $	��Top=�6m   $	��773��6�      AutoGenerateColumns .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserAddRows .  ��6�   �� 	 �� Path$	 Clients�
 � ContextMenu
 5      �� 5      .@�5      m� -   5        $ dgMenuItemDelete��5      $��Delete��69   6I   5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5         FontSize$ 14Q�6O   ,  &System.Windows.Controls.DataGridColumn   Header$
 Time��6]      MinWidth$	 100Q�6k   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Appointments/DateTime+6k     5      $ Service��6Z   $	 100Q�6k   $ 14Q�6z      
IsReadOnly .  6%   �� *" Appointments/Service.ServiceName+6�     5      $ 14Q�6N   $ Address��6\   $	 180Q�6m    6%   �� *Appointments/Address+6m     5       $ 14Q�6C   $ 
First Name��6Q   $	 100Q�6e    6%   �� *	FirstName+6e     5!      $ 14Q�6B   $ 	Last Name��6P   $	 100Q�6c    6%   �� *
LastName+6c   4  .System.Windows.Controls.DataGridComboBoxColumn  5"      -	   5        comboBoxColumnGender��$ Gender��5"   n   $ 50Q�6~      SelectedItemBinding 6G   �� *Gender+6~     5#      $ 14Q�6?   $ Notes��6M   $	 130Q�6\    6%   �� *Notes+6\      RowStyle 5%      �� 5&       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5'      ��  �� Property � �� �� Value 63   ��  �� RelativeSource �� *Self+$ 	 Item.Appointments/DateTime� �� 	Converter# [  5)      5+      �� 5,   
   -
   5         ��Name$ tbSearch��5,      $
��Left=�6$   $��23��6?   $��
138,63,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��230��6�   6�   �� 5-   
   $��Search��6   $
��Left=�6!   $��	10,27,0,0q�6<   $	��Top=�6O   $	��773��6g   $��Center=�6s   �� 5.   
   $
��Left=�6   $��8��6/   $��
10,103,0,0q�6:   $	��Top=�6N   $	��773��6f   �� 5/   
   $��Appointments��6   $
��Left=�6'   $��
10,111,0,0q�6B   $	��Top=�6V   $	��773��6n   $��Center=�6z   �� 50   
   $
��Left=�6   $��17��6/   $��
389,65,0,0q�6;   $	��Top=�6O   $��23��6g    J� RenderTransformOrigin$ 0.5,0.5&�6r   z�51      V� 52      .~�53      �� �� 54      �� 55       �� Angle$ 90.454Q�6&   T� 56      57      59      �� 5:   
   -   5         ��Name$ labelClientSearch��5:      $��Enter client's name:��6+   $
��Left=�6J   $��	20,63,0,0q�6e   $	��Top=�6x   �� 5;   
   -   5        $ labelServiceSearch��5;      $��Pick service:��6,   $
��Left=�6D   $��
424,60,0,0q�6_   $	��Top=�6s   �� 5<   
   -   5         ��Name$ cbServiceSearch��5<      $
��Left=�6,   $��
502,63,0,0q�6G   $	��Top=�6[   $	��167��6s    �� DisplayMemberPath$ ServiceName��6�   ��6   �� *	Service+6�   �� 5=   
   -   5         ��Name$ btClearSelection��5=      $��Clear Selection��6+   $
��Left=�6E   $��
687,63,0,0q�6`   $	��Top=�6t   $��96��6�   $��22��6�   6�   �� 5>   
   $
��Past��6   $
��Left=�6   $��
91,495,0,0q�6:   $	��Top=�6N   
����ح�$��42��6}   $��Center=�6�   �� 5?   
   $��Future��6   $
��Left=�6!   $��
20,495,0,0q�6<   $	��Top=�6P   
�������6h   5A      5B      