   M S B A M L   `   `   `  ����N  JBook Library System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Book_Library_SystemBook_Library_System  5   	   $    Book_Library_System.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Book_Library_System     5   	   -   5          � Title$  Book Library System��5   	   $	��510��6%    � WindowStartupLocation$ CenterScreen=�62   ��.   � WindowStyle$
 None=�6i    � AllowsTransparency .  � 
ResizeMode$ NoResize=�6�   $	��930��6�   $	��510��6�    � Left$ 0��6�   
 � Top$ 0��6�   $	��930��6   .��5	      � -   5         �Name$ 	Grid_Main��5	      
�������$��0q�61   .+�5
   
   � -   5        $ Grid_Left_Background1��5
      $
��Left=�6.   $��0,52,0,-0.4q�6I   $	��151��6^   ���	#FF6826526j   � 5   
   -   5        $ 	Grid_Left��5      $
��Left=�6"   $��10,52,0,-0.4q�6=   $	��126��6S   .+�5      �� -   5         ��Name$ Button_Library��5      $��Library��6-   $
��Left=�6?   $��0,40,0,0q�6Z   $	��Top=�6l   $	��126��6�   
�������$��16(�6�   $��Gill Sans Nova Light)�6�   ��.  ��6�   Z� ��6�   Z� 6  �� 5      -   5        $ Button_WhishList��5      $��
Whish List��6/   $
��Left=�6D   $��0,64,0,0q�6_   $	��Top=�6q   $	��126��6�   
�������$��16(�6�   $��Gill Sans Nova Light)�6�   ��.  ��6�   Z� ��6�   Z� 6  �� 5      -   5        $ Button_AddItems��5      $��	Add Items��6.   $
��Left=�6B   $��0,91,0,0q�6]   $	��Top=�6o   $	��126��6�   
�������$��16(�6�   $��Gill Sans Nova Light)�6�   ��.  ��6�   Z� ��6�   Z� 6  5      � 5   
   -   5        $ Grid_Top��5      $��52��6!   $	��Top=�6-   $��
0,0,-3.8,0q�6E   ���	#FF4E2641.+�5      �� -	   5        $ Button_Close_Window��5      $��0,10,21.4,0q�62   $	��Top=�6G   $��32��6_   $��32��6j   
�������$��X��6�   $��Georgia Pro Semibold)�6�   $��16(�6�   ��.  $��Right=�6  ��6v   Z� ��6�   Z� 6   �� 5      -
   5        $ Button_Minimize_Window��5      $��0,10,58.4,0q�65   $	��Top=�6J   $��32��6b   $��32��6m   
�������$��_��6�   $��Georgia Pro Semibold)�6�   $��16(�6�   ��.  $��Right=�6  ��6y   Z� ��6�   Z� 6#  5      �� 5   
   $��Book Library System��6   $	��Top=�6.   $��24(�6F   
�������$��Georgia Pro Semibold)�6g   $	��250��6�   $��345,10,340,0q�6�   $��5q�6�   � 5   
   -   5        $ 
Grid_Main1��5      $��175,52,10.2,9.6q�6#   .+�5       � -   5        	  �Name$	 
Frame_Main��5      $�� ��6(   $��-12,10,33.4,9.8q�63   
  � NavigationUIVisibility$
 Hidden=�6L   ��.  ��6l   Z� 6�   5      � 5   
   -   5        $ Grid_Bottom��5      $��18��6$   $��149,0,-3.4,-0.6q�60   $��Bottom=�6I   ���	#FF6826526d   � 5   
   -   5        $ 
Grid_Right��5      $��Right=�6#   $��0,51,-3.4,-0.6q�6?   $��26��6W   ���	#FF4E2641 J� RenderTransformOrigin$ 0.5,0.5&�6y   5      5      