   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5   	        WpfApplication1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication1     5   	   -   5          �Name$  MainWindow1��5   	    � Title$ Taschenrechner��5   	   $��247.368��6    $��390.789��61    � WindowStartupLocation$ CenterScreen=�6A   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��8* �6   �� 5      $
��509* �6   .+�5   
   �� -   5         ��Name$ button��5      $��Start��6!   $
��Left=�61   $��	0,172,0,0q�6L   $	��Top=�6_   $	��113��6w   $��1��6�   $��20��6�   6�   �� 5   
   -   5        $ button1��5      $��Beenden��6"   $
��Left=�64   $	��Top=�6O   $	��113��6g   $��239,172,0,0q�6s   $��1��6�   $��20��6�   6�   �� 5   
   -   5         ��Name$ textBox2��5      $
��Left=�6$   $��23��6?   $��0,85,0,0q�6K    �� TextWrapping$
 Wrap=�6]   $��0��6q   $	��Top=�6z   $	��120��6�   $��1��6�   �� 5   
   -   5        $ textBox1��5      $
��Left=�6$   $��23��6?   $
 Wrap=�6K   $��0��6_   $	��Top=�6h   $	��120��6�   $��0,41,0,0q�6�   $��1��6�   �� 5   
   -   5         ��Name$ groupBox��5      $��Rechenoperationen��6%   $
��Left=�6@   $	��Top=�6[   $	��122��6s   $	��196��6�   $��1��6�   $��
156,28,0,0q�6�   .��5      � $
��Left=�6   $	��100��6.   $��	10,0,-2,0q�6;   $	��Top=�6N   $	��176��6f   .+�5      	� -   5         	�Name$ radioButton��5      $��Addition��63   $
��Left=�6F   $��	10,10,0,0q�6a   $	��Top=�6t   	 d� 	IsChecked$
	 TrueY�6�   	� 5      -   5        $ radioButton1��5      $��Subtraktion��64   $
��Left=�6J   $��	10,30,0,0q�6e   $	��Top=�6x   	� 5      -	   5        $ radioButton2��5      $��Multiplikation��64   $
��Left=�6M   $��	10,50,0,0q�6h   $	��Top=�6{   	� 5      -
   5        $ radioButton3��5      $��Division��64   $
��Left=�6G   $��	10,70,0,0q�6b   $	��Top=�6u   5      5      �� 5   
   -   5        
 ��Name$
 label��5      $��	Ergebnis:��6   $
��Left=�63   $��	0,132,0,0q�6N   $	��Top=�6a   $��2��6y   �� 5   
   -   5        $
 ergebnis��5      $��0��6"   $��1��6.   $
��Left=�6>   $��
52,132,0,0q�6Y   $	��Top=�6m   $��77��6�   5      5      