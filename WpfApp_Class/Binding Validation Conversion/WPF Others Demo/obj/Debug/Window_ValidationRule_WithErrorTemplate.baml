   M S B A M L   `   `   `  ����J  FWPF Others Demo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WpfApplication1.CommonWpfApplication1.Common  5   	   .    (WpfApplication1.Common.Window_Validation   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   5common$clr-namespace:WpfApplication1.Common    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Window_Validation��5   	   $	��414��6#   $��922.693��60    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5	      �� 5
      $, &Dictionary_ValidationErrorTemlate.xaml?�6%   6W   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $
��159* �6   �� 5      $
��224* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5*   
   �� $��1��6   
����ح� �� Orientation$ Vertical=�6>   $��2��6U   $��	0,0,0,215q�6f   .+�5+      �� 
����  �
�������$1��+Binding UpdateSourceTrigger=PropertyChanged��6A   $��3q�6t   6�   �� 5,      -   5         ��Name$ StartDateEntryForm��5,   !   $��3q�6      validationErrorTemplate1 =� ErrorTemplate# [  5-      .��6M   .��5.      �� 	 �� Path$	 	StartDate�6   
 �� UpdateSourceTrigger$
 PropertyChanged=�6+    �� ValidationRules 50      +  %WpfApplication1.Common.FutureDateRule  51      53      54      �� 57      $��3q�6     validationErrorTemplate2# [ 6!     textStyleTextBox#��[ 6g   $
��Auto��6�   .��6�   .��58      �� $	 Range�6   $
 PropertyChanged=�6)    59      +  %WpfApplication1.Common.RangeValidator  5:      5<      5=      �� 5?      $
��Auto��6   # [  6&   #��[ 6l   $��3q�6�   .��6�   .��5@      �� $	 Range�6   $
 PropertyChanged=�6)    5A        5B      5D      5F      �� 5J      -   5        $ textBox1��5J       J� RenderTransformOrigin$ 0.521,-0.13&�6(   $��3q�6L   .��6Y   .��5K      �� $	 Range�6   $
 Explicit=�6)    5L        5M      5O      5Q      5S      �� 5U   
   
��� ���$ Vertical=�6*   $��10,0,10,161q�6B   $��0��6W   $��2��6g   .+�5V      �� 
����  �
�������$+��%Binding UpdateSourceTrigger=LostFocus��6A   $��3q�6n   6{   � 5W      $
��auto��6   $
��10,0q�6!    5X      �� 5Y      $
��auto �6'   �� 5Z      $
��186* �6'    5\      �� 5]      $��* �6$   �� 5^      $��* �6$   �� 5_      $��* �6$   �� 5`      $��* �6$   .+�5d      �� -   5        $ textBox4_Copy��5d   ~   $��5q�6   $��1��6&    �� TextWrapping$
 Wrap=�6�   ��66   �� *Age+
 � Tag 6L   �� *
(Grid.Row)+ �� ElementName$ textBox4��6�   �� 5f      -   5        $ textBox3��5f   C   $��5q�6   $��1��6&   $��1��63   $
 Wrap=�6U   .��6j   ��5g      �� 5h      $		 Age�6"    5i        5j   "   5  /System.Windows.Controls.ExceptionValidationRule  5k   "   5m      .��5n   $   5p      �� 5q      -   5        $��textBox2��5q   C   $��5q�6   $��2��6&   $��1��63    6T   �� $	 (Validation.Errors)�$ textBox2��.��5r      ��5t      �� 5u      $		 Age�6"    �� ValidatesOnExceptions .  �� ValidatesOnDataErrors .  5v        5w   "   5y      .��5z   $   .��5|   Y    5~      �� 5      .R�5�      �� .+�5�   "   �� 
���  ��$��2q�6;    �� CornerRadius$ 10��6O   ._�5�   &   ��  ��Name$ ErrorAdorner��6@   5�   #   �� 5�   "   
���  ����6,   �� *[0].ErrorContent+6N   5�      5�      .��5�   0   5�      �� 5�      $��Age: (default)��6   �� 5�      $��1��6   $��Age: (8~32)��6%   �� 5�      $��2��6   $��ErrorTemplate��6%   5�      5�      5�      5�      