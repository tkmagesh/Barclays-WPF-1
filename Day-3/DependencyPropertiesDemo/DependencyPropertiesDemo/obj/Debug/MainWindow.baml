   M S B A M L   `   `   `  ����S  ODependencyPropertiesDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:DependencyPropertiesDemoDependencyPropertiesDemo  5   	   )    #DependencyPropertiesDemo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   8local&clr-namespace:DependencyPropertiesDemo     5   	   $��22(�5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5      ��%    5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   .+�5   
   �� -   5        $��TxtDummy��5      $��0��6   $�� ��6/   69   -   'DependencyPropertiesDemo.DataEntryField  5   
   -   5          Name$ DefName��5   b      Caption$ Name :��6Q   $��1��6s      Value 6   ��  �� ElementName$ TxtDummy�� �� Path$
 Text�6�   �� 5   
   -   5        $��BtnWhatIsTheName��5   :   $��What is the name?��6   $��2��6-   6u   5      5      