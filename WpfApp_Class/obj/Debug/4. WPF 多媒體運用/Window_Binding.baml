   M S B A M L   `   `   `  ����G  CWpfApp_Class, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:WpfApp_Class._4._WPF_多媒體運用$WpfApp_Class._4._WPF_多媒體運用  5   	   9    3WpfApp_Class._4._WPF_多媒體運用.Window_Binding   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:WpfApp_Class._4._WPF_多媒體運用     5   	     � Title$  Window_Binding��5   	   $��654.979��6    $��1174.539��61    � 	Resources 5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $W Q/WpfApp_Class;component/MyThemesStyle/Dictionary_GelButtonResourceDictionary.xaml?�6%   �� 5      $G A/WpfApp_Class;component/MyThemesStyle/Dictionary_ButtonStyle.xaml?�6%   �� 5      $H B/WpfApp_Class;component/MyThemesStyle(2)/Dictionary_ShinyBlue.xaml?�6%   %    5      .��5      � 
�������.+�5   
   �� $
��Left=�6F   $��83��6a   $��	65,64,0,0q�6m    �� TextWrapping$
 Wrap=�6�   $��TextBox��6�   $	��Top=�6�   $	��160��6�   ��6   ��  �� ElementName$ slide1�� �� Path$ Value�6�   �� 5   
   -   5        $��slide1��5       � Maximum$ 32Q�6    � Minimum$ 12Q�6,   	 � Value$	 20Q�69   $
��Left=�6D   $��28��6_   $��
456,98,0,0q�6k   $	��Top=�6   $	��272��6�   �� 5   
   -   5        $��	checkBox1��5   7   $��CheckBox��6   
 d� 	IsChecked$

 TrueY�6&   $
��Left=�6H   $��35��6c   $��
65,193,0,0q�6o   $	��Top=�6�   $	��173��6�   �� 5   
   $��Button��6   $
��Left=�6^   $��49��6y   $��151,176,0,0q�6�   $	��Top=�6�   $	��118��6�    J� RenderTransformOrigin$ 0.054,0.224&�6�   {�6"   �� $ 	checkBox1��$ 	IsChecked�6�   �� 5   
   $
��Left=�6   $	��107��6+   $��
45,233,0,0q�68   $	��Top=�6L   $6��0/WpfApp_Class;component/FifaWorldCup/pic_012.jpg��6�   $
��Fill=�6�   ��6d   �� $ slider2��$ Value�6�   �� 5   
   -   5        $��slider2��5      $	 300Q�6    $	 100Q�6.   $
	  150Q�6<   $
��Left=�6I   $��17��6d   $��234,248,0,0q�6p   $	��Top=�6�   $	��278��6�   �� 5   
   -   5        $
��img2��5      $
��Left=�6   $	��107��67   $��
45,364,0,0q�6D   $	��Top=�6X   $	��180��6p   $6��0/WpfApp_Class;component/FifaWorldCup/pic_019.jpg��6|   $
��Fill=�6�   �� 5   
   -   5        $��Coding
��5      $
��Left=�6c   $��69��6~   $��234,281,0,0q�6�   $	��Top=�6�   $	��165��6�   $ 0.054,0.224&�6�   {�6,   �� *	IsChecked+$ 	checkBox1��6�   �� 5   
   -   5        $��stackpanel1��5      $
��Left=�6(   $	��165��6C   $��532,297,0,0q�6P   $	��Top=�6e   $	��177��6}   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF6C6C29��6#    � Offset$ 0Q�65   � 5      $ 	#FFFBFB03��6#   $ 1Q�65   5       .+�5"      �� $
��Wrap=�6   ��6,   �� *	EmpName+(  "System.Windows.Controls.DatePicker  5#         Text 6   �� *
HireDate+�� 5$      $	��100��6   ��6!   �� *
EmpImage+5%      �� 5&   
   -   5        $��Button��5&      $
��Left=�6"   $��555,180,0,0q�6=   $	��Top=�6R   $	��107��6j   $��48��6v   6�   �� 5'   
   -   5        $��listbox1��5'      $
��Left=�6"   $	��101��6=   $��
752,64,0,0q�6J   $	��Top=�6^   $	��155��6v   �� 5(   
   -	   5        $��listbox2��5(   .    �� DisplayMemberPath$ EmpName��6   $
��Left=�6>   $	��126��6Y   $��752,204,0,0q�6f   $	��Top=�6{   $	��155��6�   �� 5)   
   -
   5        $��listbox3��5)      $
��Left=�6"   $	��249��6=   $��752,335,0,0q�6J   $	��Top=�6_   $	��283��6w   ��5*      �� 5+      .R�5,      �� $
��Left=�6"   $	��150��6=   $	��Top=�6K   $	��150��6c   ��5-      �� 5.      $ 0.5,1&�62   $ 0.5,0&�6C   .��5/   "   � $ 	#FF6C6C29��6/   $ 0Q�6A   � 50   "   $ 	#FFFBFB03��6/   $ 1Q�6A   51      .+�53      �� $
��Wrap=�6$   ��68   �� *	EmpName+  54       6%   �� *
HireDate+�� 55      $	��100��6    ��6-   �� *
EmpImage+56      57      5;      �� 5<   
   -   5        $��Button��5<      $
��Left=�6"   $��31��6=   $��
977,51,0,0q�6I   $	��Top=�6]   $��96��6u   6�   �� 5=   
   $��Button��6   $
��Left=�6#   $��35��6>   $��977,203,0,0q�6J   $	��Top=�6_   $��96��6w   5?      5@      