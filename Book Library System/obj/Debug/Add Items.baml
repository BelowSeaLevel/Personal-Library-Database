   M S B A M L   `   `   `  ����N  JBook Library System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Book_Library_SystemBook_Library_System  5      #    Book_Library_System.Add_Items   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Book_Library_System     5      $
��Auto��5      $
��Auto��6     N� Title$  Add_Items_Page��5	       N� 
Background
 �����.��5      � -   5         �Name$ 	Grid_Main��5      $��723.2��6   $��428.8��6,   .+�5   
   �� -   5         ��Name$ Label_Title��5      $��Title��6%   $��	18,44,0,0q�65   $��16(�6H   $��Georgia Pro Light)�6V   $	��Top=�6u   $
��Left=�6�   �� 5   
   -   5         ��Name$ TextBox_Title��5      $��23��6)   $��	18,78,0,0q�65   $	��Top=�6H   $	��189��6`    J� 	AllowDrop .  $��14(�6~   $��Georgia Pro Light)�6�   $��0,3,0,0q�6�   $
��Left=�6�   $��1��6�   6�   �� 5   
   -   5        $ Label_Author��5      $��Author��6&   $
��Left=�67   $��
18,106,0,0q�6R   $	��Top=�6f   $��16(�6~   $��Georgia Pro Light)�6�   �� 5   
   -   5        $ TextBox_Author��5      $
��Left=�6*   $��23��6E   $��
18,140,0,0q�6Q   $	��Top=�6e   $	��120��6}    .  $��Georgia Pro Light)�6�   $��14(�6�   $��0,3,0,0q�6�   $��2��6�   6�   �� 5   
   -   5        $ 
Label_ISBN��5      $��ISBN Number��6$   $��
18,168,0,0q�6:   $��16(�6N   $��Georgia Pro Light)�6\   $	��Top=�6{   $
��Left=�6�    J� RenderTransformOrigin$ 0.487,0.521&�6�   �� 5   
   -   5        $ TextBox_ISBN��5      $
��Left=�6(   $��23��6C   $��
18,202,0,0q�6O   $	��Top=�6c   $	��190��6{    .  $��Georgia Pro Light)�6�   $��14(�6�   $��0,3,0,0q�6�   $��3��6�   6�   �� 5   
   -   5        $ Label_Genre��5      $��Genre��6%   $
��Left=�65   $��
18,230,0,0q�6P   $	��Top=�6d   $��16(�6|   $��Georgia Pro Light)�6�   �� 5   
   -	   5        $ TextBox_Genre��5      $
��Left=�6)   $��23��6D   $��
18,264,0,0q�6P   $	��Top=�6d   $	��120��6|    .  $��Georgia Pro Light)�6�   $��14(�6�   $��0,3,0,0q�6�   $��4��6�   6�   �� 5   
   -
   5        $ Label_Langauge��5      $��Langauge��6(   $
��Left=�6;   $��
18,292,0,0q�6V   $	��Top=�6j   $��16(�6�   $��Georgia Pro Light)�6�   �� 5   
   -   5        $ TextBox_Langauge��5      $
��Left=�6,   $��23��6G   $��
18,326,0,0q�6S   $	��Top=�6g   $	��120��6    .  $��Georgia Pro Light)�6�   $��14(�6�   $��0,3,0,0q�6�   $��5��6�   6�   �� 5   
   -   5        $ Label_Data_Of_Release��5      $��Date Of Release��6/   $
��Left=�6I   $��
18,354,0,0q�6d   $	��Top=�6x   $��16(�6�   $��Georgia Pro Light)�6�   �� 5   
   -   5        $ TextBox_Date_Of_Release��5      $
��Left=�63   $��23��6N   $��
18,388,0,0q�6Z   $	��Top=�6n   $	��120��6�    .  $��Georgia Pro Light)�6�   $��14(�6�   $��0,3,0,0q�6�   $��6��6�   6�   �� 5   
   -   5         ��Name$ Image_Books��5      $
��Left=�6%   $	��271��6@   $��
408,50,0,0q�6M   $	��Top=�6a   $	��282��6y   �� 5   
   -   5         ��Name$  Button_Add_Item_To_Library��5      $��Add Item To Library��65   $
��Left=�6S   $��410,330,0,0q�6n   $	��Top=�6�   $	��128��6�   $��28��6�   $��7��6�   $��14(�6�   $��Georgia Pro Light)�6�   
���   ���6  Z� 6,  �� 5   
   -   5        $ Label_Add_Items_Page��5      $��	Add Items��6.   $
��Left=�6B   $��	18,10,0,0q�6]   $	��Top=�6p   $��Georgia Pro Cond Semibold)�6�   $��20(�6�   
���   ���6�   Z� 6�   �� 5   
   -   5        $ Button_Save_To_Whish_List��5      $��Save To Whish List��64   $
��Left=�6Q   $��410,383,0,0q�6l   $	��Top=�6�   $	��131��6�   $��28��6�   $��7��6�   $��14(�6�   $��Georgia Pro Light)�6�   
���   ���6  Z� 6$  �� 5   
   -   5        $ Button_Add_Image��5      $��	Add Image��6+   $
��Left=�6?   $��612,330,0,0q�6Z   $	��Top=�6o   $��78��6�   $��28��6�   $��7��6�   $��14(�6�   $��Georgia Pro Light)�6�   
���   ���6�   Z� 6  �� 5   
   -   5        $ Label_Error��5      $�� ��6%   $
��Left=�60   $��
159,16,0,0q�6K   $	��Top=�6_   
���  ��$��14(�6�   $��Georgia Pro Semibold)�6�   �� 5   
   -   5        $ Button_Delete_Image��5      $��Delete Image��6.   $
��Left=�6E   $��588,383,0,0q�6`   $	��Top=�6u   $	��102��6�   $��28��6�   $��7��6�   $��14(�6�   $��Georgia Pro Light)�6�   
���   ���6  Z� 6  5      5       