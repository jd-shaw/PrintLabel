   M S B A M L   `   `   `  ����  
PrintLabel    PrintLabel.MessageWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  Message��5   	   $��12(�5   	   $	��400��5   	   $	��240��5   	   $	��440��5   	    � Topmost . 
������� � ShowInTaskbar .   � 
ResizeMode$ NoResize=�5   	    � SizeToContent$ WidthAndHeight=�5   	    � WindowStartupLocation$ CenterOwner=�5   	    � 	Resources 5         
CustomBlue �� Color  CustomLightBlue  CustomDarkBlue  
CustomGray �� 
TargetType	 �� Property
 �� Value �� 
TargetType J� SnapsToDevicePixels �� Triggers �� Value �� Binding �� ElementName �� Path �� 
TargetName P� Property P� Value��%�  &	        &	 (     &	 P     &	 x     '�� �     'x� �     '�� :    �� 5   
   $ 	#FFA0C2F9��6-   6A   �� 5   
   $ 	#FFC9DCFC��62   6F   �� 5   
   $ 	#FF4285F4��61   6E   �� 5   
   $ 	#FFDEDEDE��6-   6A   �� 5   
   " ��6   .�5      �� 	 � ��$
 12(�6)   66   5      �� 5   
   " x�6   .�5      �� 	 � ��$
 12(�6)   66   5      �� 5   
   " ��6   .�5       �� 	 � ��$
 34��6'   �� 5!      	 � ��$	
 120��6&   �� 5"      	 � ��$
 1q�60   �� 5#      	 � ��#
 �   6,   �� 5$      	 � ��#
 �  6+   �� 5%      	 � ��#
 �  6+   �� 5&      	 � ��$
 Center=�69   �� 5'      	 � ��$
 Center=�6;   �� 5(      	 � ��
 5)      �� 5*      " ��6&   .R�5+      � .+�5,      �� $��
Background��6%   
������� . $y�Visible=�6e   6|   �� 5-      $��Bd��6%   #��z��6/   #��z��6c   #��z��6�    . 6�   �� 5.      ��.  #��z��6?   #��z��6e   #��z��6�   #��z��6�   #��z��6�   5/       50      �� 51      $ Transparent��6^    6*   �� $ Bd��$ 
Background�.a�52   "   �� $ 
Background��6)   	 � y�$
 	Collapsed=�6W   53      P� 54       �@J�IsMouseOver . . �55   "   �� $ Bd��6)   	 �@J�Opacity$

 0.85Q�6L   56      P� 57       � {� .  . �58   "   �� 	 � ��

 �����6@   �� 59   "   	 � ��

 �����6?   �� 5:   "   	 � ��

 �����6?   5;      5=      5?      5@      5A      .��5C      �  � ColumnDefinitions 5D   
   �� 5E      $	��140 �6   �� 5F      $��* �6    � RowDefinitions 5H   
   �� 5I      $��10 �6   �� 5J      $��* �6   �� 5K      $��10 �6   �� 5L      $��60 �6   .+�5N   
   �� -   5         ��Name$ imgIcon��5N      $��1��6%   ���	#FF4B8BF4$��Center=�6I   $��Center=�6d   F� 5O      -   5         F�Name$ imgIconPath��5O      $	��110��6^   $	��110��6j    �� Stretch$
 Fill=�6w   $��0��6�   ����� ��    � ��      � �?
  � `��  � 7�# �� ��- �� ��-���n���@ ��- �g5 7�# �g5 `�S �g5̡E��}e@ W(+ ��� �� P�1����(\�p@ P�1 �� �% �� `�S �� ��Q�a@���(\�p@ p/� �� p/�� >- p/� p89 �) p89 `�� p89 �% >- P�1 �� P�1� 8�  �� �l   �� �l  ��� 8� ��� �� |1%� �� �x� l� l�� �� |1%� l� l�	 J� RenderTransformOrigin$ 0.5,0.5&�6�  ��6(   �� $ imgIcon��$ 
Foreground�z�5P      V� 5Q      .~�5R      ��  �� Angle$	 180Q�6*   �� 5S       �� ScaleX$ -1Q�6)   5T      5V      5W      �� 5X   
   -   5        $ 
txtMessage��5X      $��Content��6(   $��1��67   $��10,20,20,10q�6G   $��1��6\   $��14(�6i   $
��Wrap=�6w   �� 5Y   
   $��3��6   $��2��6   #���  62   $��0,1,0,0q�6]    �� EdgeMode$ Aliased=�6w    . ._�5Z      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   $��Center=�6N   $
��15,0q�6i   .+�5[      �� -   5         ��Name$ Button1��5[      $��OK��6*   $��0q�67   $��34��6B   $��0q�6�   
���������6b   �� $ imgIcon��$ 
Foreground�  �� Mode$  OneWay=�6�   �� 5\      -   5        $ Button2��5\      $��Cancel��6*   $��40,0,0,0q�6;   $��34��6M   ���	#FFDADADA$��0q�6�   
���   �6�   5]      5^      5_      5`      