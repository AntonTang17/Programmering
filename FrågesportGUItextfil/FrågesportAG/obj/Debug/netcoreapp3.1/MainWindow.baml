   M S B A M L   `   `   `  ����H  DFrågesportAG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:FrågesportAGFrågesportAG  5   	       FrågesportAG.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:FrågesportAG     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      ��  �� Orientation$ Vertical=�6   ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63    �� RelativeTransform 5      V� 5      .~�5      ��  �� CenterY$	 0.5Q�6)    �� CenterX$	 0.5Q�67   �� 5       �� CenterY$	 0.5Q�6(    �� CenterX$	 0.5Q�66   �� 5      	 �� Angle$	 90Q�6*   
 �� CenterY$	
 0.5Q�65    �� CenterX$	 0.5Q�6C   T� 5      5      .��5      �  � Color$ 	#FF1A1919��6    � Offset$ 1Q�61   � 5      $ 	#FFFF0101��6   $ 0Q�61   5      .+�5   
   �� -   5        $��	textTitle��5      $��30(�6%   $��Frågesport��63    �� TextAlignment$ Center=�6E   $��35q�6\   ���	#FFF9F6F6$��SimSun)�6   �� 5   
   -   5        $��buttonStart��5      ���	#FFF9F6F6$��20(�6;   $��Starta quiz��6I   $��Center=�6_   $��45q�6|   $��SimSun)�6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67    5      V� 5      .~�5      �� $	 0.5Q�6-   $	 0.5Q�6;   �� 5      $	 0.5Q�6,   $	 0.5Q�6:   �� 5       $		 270Q�6.   $	
 0.5Q�6:   $	 0.5Q�6H   T� 5!      5"      .��5$      � $ 	#FFF10909��6#   � 5%      $ 	#FF060606��6#   $ 1Q�65   5&      5(      �� 5)   
   -   5        $
��qOne��5)      $��30(�6    $��Fråga��6.   $��SimSun)�6;   ���	#FFF9F6F6$ Center=�6f   $y�Hidden=�6}   $��45q�6�   $��WrapWithOverflow=�6�   �� 5*   
   -   5        $��qMulti��5*      $��30(�6"   ���	#FFF9F6F6$��SimSun)�6G   $��
Alternativ��6[   $ Center=�6m   $y�Hidden=�6�   $��10q�6�   �� 5+   
   -   5        $
��svar��5+      $��20(�6   $��SimSun)�6-    �� TextAlignment$ Center=�6A   ���	#FFF9F6F6$y�Hidden=�6o   $��40q�6�   ���	#FFDE1313
���   �6�   �� 5,   
   -   5        $	��fel��5,      $��30(�6   $��Fel svar, försök igen!��6-   $ Center=�6K   $y�Hidden=�6b   $��20q�6v   ���	#FFF9F6F6$��SimSun)�6�   �� 5-   
   -   5        $��
buttonSkip��5-      $��Hoppa över��6#   $��20(�68   $��SimSun)�6F   ���	#FFF9F6F6$��Right=�6q   $��Bottom=�6�   $��20q�6�   ��5.      �� 5/      $ 0.5,1&�6&   $ 0.5,0&�67    50      V� 51      .~�52      �� $	 0.5Q�6-   $	 0.5Q�6;   �� 53      $	 0.5Q�6,   $	 0.5Q�6:   �� 54      $		 270Q�6.   $	
 0.5Q�6:   $	 0.5Q�6H   T� 55      56      .��58      � $ 	#FFF10909��6#   � 59      $ 	#FF060606��6#   $ 1Q�65   5:      5<      �� 5=   
   -   5        $
��klar��5=      $��Grattis!��6    $��30(�60   $��SimSun)�6>   $ Center=�6R   ���	#FFF9F6F6$y�	Collapsed=�6�   $��40q�6�   �� 5>   
   -	   5        $��antal��5>      $ ��Du fick X av Y antal rätt��6!   $��30(�6B   $��SimSun)�6P   $ Center=�6d   ���	#FFF9F6F6$y�	Collapsed=�6�   $��40q�6�   5?      5@      