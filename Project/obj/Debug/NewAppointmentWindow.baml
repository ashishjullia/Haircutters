   M S B A M L   `   `   `  ����B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  5   	   "    Project.NewAppointmentWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Project     5   	   X TXceed.Wpf.Toolkit, Version=3.7.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44wpfx)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   -   5          �Name$  newAppointmentWindow��5   	    � Title$ Appointment Creation��5	   	   $��394.029��6&   $��731.82��67   .��5
      � .+�5   
   �� -   5         ��Name$ 
labelTitle��5      $��New Appointment��6$   $
��Left=�6>   $��	10,10,0,0q�6Y   $	��Top=�6l   $	��678��6�   $��Center=�6�   ��. 6�   �� 5   
   -   5        $ labelFirstName��5      $��First name:��6(   $
��Left=�6>   $��	48,55,0,0q�6Y   $	��Top=�6l   �� 5   
   -   5        $ labelLastName��5      $��
Last name:��6'   $
��Left=�6<   $��	48,99,0,0q�6W   $	��Top=�6j   �� 5   
   -   5        $ labelGender��5      $��Gender:��6%   $
��Left=�67   $��
48,143,0,0q�6R   $	��Top=�6f   �� 5   
   -   5        $ 
labelNotes��5      $��Notes:��6$   $
��Left=�65   $��
48,192,0,0q�6P   $	��Top=�6d   �� 5   
   -   5         ��Name$ tbFirstName��5      $
��Left=�6'   $��23��6B   $��
138,58,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��153��6�   �� 5   
   -   5        $ 
tbLastName��5      $
��Left=�6&   $��23��6A   $��138,102,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��153��6�   �� 5   
   -	   5         ��Name$ cbGender��5      $
��Left=�6%   $��138,147,0,0q�6@   $	��Top=�6U   $	��153��6m   �� 5   
   -
   5        $ tbNotes��5      $
��Left=�6#   $	��111��6>   $��138,196,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��153��6�   �� 5   
   -   5        $ 	labelDate��5      $��
Pick date:��6#   $
��Left=�68   $��
409,55,0,0q�6S   $	��Top=�6g   �� 5   
   -   5         ��Name$ buttonCreate��5      $��Create��6'   $
��Left=�68   $��299,329,0,0q�6S   $	��Top=�6h   $	��107��6�   6�   �� 5   
   -   5        $ labelService��5      $��Pick service:��6&   $
��Left=�6>   $��409,102,0,0q�6Y   $	��Top=�6n   �� 5   
   -   5        $ 	cbService��5      $
��Left=�6&   $��490,103,0,0q�6A   $	��Top=�6V   $	��209��6n    �� DisplayMemberPath$ ServiceName��6�   ��6z   �� *	Service+6�   �� 5   
   -   5         ��Name$ cbSalon��5      $��Salon��6$   $
��Left=�64   $��490,157,0,0q�6O   $	��Top=�6d   6�   �� 5   
   -   5        $ labelAddress��5      $��Address:��6&   $
��Left=�69   $��409,192,0,0q�6T   $	��Top=�6i   �� 5   
   -   5        $ 	tbAddress��5      $
��Left=�6%   $	��111��6@   $��490,196,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��209��6�   &   Xceed.Wpf.Toolkit.DateTimePicker  5   
   -   5        	  Name$	 dateTimePicker��5      $��490,55,10.333,274.667q�66   5      5      