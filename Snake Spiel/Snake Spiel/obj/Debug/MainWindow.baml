   M S B A M L   `   `   `  ����F  BSnake Spiel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Snake_SpielSnake_Spiel  5   	       Snake_Spiel.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Snake_Spiel     5   	   -   5          � Title$  Snake��5   	   $	��600��6   $	��800��6$    � ShowInTaskbar .   � 
ResizeMode$ NoResize=�6F    � WindowStartupLocation$ CenterScreen=�6\    � Topmost . .��5	      � 
������� � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   o� $��0��6   .@�5      m� $��_Spiel��6   .@�5      m� -   5        $��_Beenden��5      5      5      5      �� 5   
   -   5         ��Name$ 	spielfeld��5      $
��Auto��6$   $
��Auto��61   
�������$��1��6U   .+�5      �� -   5         ��Name$ punktAnzeige��5      $��0��6*   $
��Left=�66   $��1��6Q   $	��Top=�6^   $��20(�6v    �� Left$	 725��6�   
	 �� Top$	 28��6�   �� 5      -   5        $ zeitAnzeige��5      $��0��6)   $
��Left=�65   $��1��6P   $	��Top=�6]   $��20(�6u   $	 725��6�   $	 70��6�   5      5      5      