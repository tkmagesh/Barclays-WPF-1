   M S B A M L   `   `   `  ����R  N01_DataBindingToObjects, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:_01_DataBindingToObjects_01_DataBindingToObjects  5   @   6    0_01_DataBindingToObjects.BindingToObjectsWindow2   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   8local&clr-namespace:_01_DataBindingToObjects     6@   $��22(�5   	     � Title$  BindingToObjectsWindow2��5   	   $��321.502��6)   $��485.324��6:   .��5      � -   5        $��GridLayoutRoot��5       � 	Resources 5   
   '   !_01_DataBindingToObjects.Employee   DataBindingObject   	FirstName   LastName��%A   &	          5      $ Magesh��67   $ Kuppan��6J   6^   5	       � DataContext 5
   
   �� 5       �� ResourceKey$ DataBindingObject��6   6?    � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,    � ColumnDefinitions 5   
   �� 5      $��2* �6   6,   �� 5      $��3* �6   6,   .+�5   
   �� $��First Name :��6   $��0��6'   $��Right=�64   $��10q�6P   6^   �� 5   
   $��Last Name :��6   $��1��6&   $��Right=�63   $��10q�6O   6]   �� 5   
   $��Full Name :��6   $��2��6&   $��Right=�63   $��10q�6O   6]   �� 5   
   -   5        $��TxtFirstName��5      $��0��6!   $��1��6.   $��10q�6>   ��5      ��  �� Path$ 	FirstName�5   L   �� 5    
   -   5        $��TxtLastName��5"      $��1��6!   $��1��6.   $��10q�6>   ��5!      �� $ LastName�5"   L   �� 5#   
   -   5        $��
TbFullName��5%      $��2��6   $��1��6,   $��10,13.4,10.2,7.4q�6<   ��5$      �� $ FullName�5%   X   �� 5&   
   $��3��5(      $��2��6   ��5'      �� $ GreetMessage�5(   2   �� 5)   
   -   5        $��BtnPrintFullName��5+   :   $��1��6   $��Print Employee��6!   $��4��6R   ��5)      �� $ GenerateFullNameCommand�5,      �� 5-   
   -   5        $��BtnGreetEmployee��5/   :   $��1��5.      $��1��5/      $��Greet Employee��6!   $��4��6R   ��5-      �� $ GreetEmployeeCommand�50      51      52      