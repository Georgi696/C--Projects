   M S B A M L   `   `   `  ����G  CMedia Player, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Media_PlayerMedia_Player  5   	       Media_Player.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Media_Player     5   	     � Title$  Media Player��5   	   $	��350��6   $	��525��6+    � WindowStartupLocation$ CenterScreen=�67    � Icon$ Icons/play.png��6\   .��5	      � .+�5
   
   r� -   5         r�Name$ mediaElement��5
       J� RenderTransformOrigin$ 0.5,0.5&�6-    r� Volume$ 1Q�6M   $��0,56,0,0q�6X    r� LoadedBehavior$ Manual=�6j    J� IsManipulationEnabled .  J� OpacityMask 5      �� 5      5      `� 5   
   $
��Left=�6   $��56��61   $	��Top=�6=   $	��517��6U   .�5      c� -   5        	 c�Name$	 toolBar��5      $
��Left=�6'   $��56��6B   $	��Top=�6N   $	��517��6f   $��0,0,-493,-43q�6r   .@�5      �� -   5        
 ��Name$
 _new1��5      .��5      �� $��Icons/neu.png��6   5      �� 5      -   5        $
 play1��5      .��5      �� $��Icons/play.png��6   5      �� 5      -   5        $
 stop1��5      .��5      �� $��Icons/stop.png��6   5      �� 5      -   5        $
 zurueck1��5      .��5      �� $��Icons/zurueck.png��6   5      �� 5      -   5        $
 pause1��5      .��5      �� $��Icons/pause.png��6   5      �� 5       -   5        $

 vor1��5       .��5!      �� $��Icons/vor.png��6   5"      �� 5#      -	   5        $
 open1��5#      .��5$      �� $��Icons/oeffnen.png��6   5%      �� 5&      -
   5        $
 menu1��5&      .��5'      �� $��Icons/appmenu.png��6   5(      5)      5+      �� 5,   
   -   5         ��Name$ label��5,      $��No name��6   $
��Left=�61   $��	10,61,0,0q�6L   $	��Top=�6_   �� 5-   
   -   5         ��Name$ slider��5-      $��404,174,-41,0q�6!   $	��Top=�68   $��27��6P   $ 0.5,0.5&�6\   z�5.      V� 5/      .~�50      �� �� 51      �� 52       �� Angle$ 90Q�6&   T� 53      54      56      �� 57   
   -   5        $ label1��57      $��0��6    $��10,267,399,0q�6,   $	��Top=�6B   59      5:      