   M S B A M L   `   `   `  ����X  T01_MVVMTestability.ViewModels, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullvSclr-namespace:_01_MVVMTestability.ViewModels;assembly=01_MVVMTestability.ViewModels_01_MVVMTestability.ViewModels  5   	    01_MVVMTestability$   _01_MVVMTestability.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   elocalSclr-namespace:_01_MVVMTestability.ViewModels;assembly=01_MVVMTestability.ViewModels     5   	   $��22(�5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      � -   5        $��GridLayoutRoot��5       � 	Resources 5   
   -   '_01_MVVMTestability.ViewModels.Employee   DataBindingObject   	FirstName   LastName��%E   &	          5	      $ Magesh��67   $ Kuppan��6J   5      5       � DataContext 5   
   �� 5       �� ResourceKey$ DataBindingObject��6   6?    � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,    � ColumnDefinitions 5   
   �� 5      $��2* �6   6,   �� 5      $��3* �6   6,   .+�5   
   �� $��First Name :��6   $��0��6'   $��Right=�64   $��10q�6P   6^   �� 5   
   $��Last Name :��6   $��1��6&   $��Right=�63   $��10q�6O   6]   �� 5   
   $��Full Name :��6   $��2��6&   $��Right=�63   $��10q�6O   6]   �� 5   
   -   5        $��TxtFirstName��5       $��0��6!   $��1��6.   $��10q�6>   ��5      ��  �� Path$ 	FirstName�5    L   �� 5!   
   -   5        $��TxtLastName��5#      $��1��6!   $��1��6.   $��10q�6>   ��5"      �� $ LastName�5#   L   �� 5$   
   -   5        $��
TbFullName��5&      $��2��6   $��1��6,   $��10q�6<   ��5%      �� $ FullName�5&   J   �� 5'   
   -   5        $��BtnPrintEmployee��5'   \   $��Print Employee��6   $��3��6t   {�6*   �� $ CanFullNameBeGenerated�6�   �� 5(   
   -   5        $��BtnChangeEmployee��5(   +   $��Change Employee��6   $��3��6D   $��1��6Q   6e   5)      5+      