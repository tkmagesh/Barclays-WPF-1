   M S B A M L   `   `   `  ����X  T01_MVVMTestability.ViewModels, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullvSclr-namespace:_01_MVVMTestability.ViewModels;assembly=01_MVVMTestability.ViewModels_01_MVVMTestability.ViewModels  5   	    01_MVVMTestability%   _01_MVVMTestability.GreetWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   j
viewModelsSclr-namespace:_01_MVVMTestability.ViewModels;assembly=01_MVVMTestability.ViewModels     5   	     � Title$  GreetWindow��5   	   $	��300��6   $	��300��6*    � 	Resources 5      5   /_01_MVVMTestability.ViewModels.GreeterViewModel   	VmContext��%   &	          5   
   6:   5       � DataContext 5	      �� 5
   
    �� ResourceKey$ 	VmContext��6   63   .��5      � .+�5   
   �� $
��Left=�5      $��23��6(   $��	58,59,0,0q�64    �� TextWrapping$
 Wrap=�6G   $	��Top=�6\   $	��120��6t   ��5      ��  �� Path$
 Name� �� Mode$ TwoWay=�5   t   �� 5   
   $��Greet��5      $
��Left=�6   $��
58,109,0,0q�68   $	��Top=�6L   $��75��6d   ��5      �� $ GreetCommand�5   d   �� 5   
   $
��Left=�5      $��
25,199,0,0q�6(   $
��Wrap=�6<   $	��Top=�6Q   $	��259��6i   ��5      �� $ GreetMessage���5      �� $ MessageColor�5   i   5      5      