   M S B A M L   `   `   `  ����  WPF Others Demo(    "MyTestControls.Window_MyTestFlyout   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   H DMahApps.Metro, Version=1.1.3.0, Culture=neutral, PublicKeyToken=null9Custom,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$  
MainWindow��5   	   $��536.119��6   $��987.686��6-   .��5      � .+�5   
   �� $
��Left=�6   $	��151��60   $��	45,64,0,0q�6=   $	��Top=�6P   $	��360��6h      MetroTabControl#���   6t   .@�5      �� $��TabItem��6   .��5	      � ���	#FFE5E5E5.+�5
      (  "MahApps.Metro.Controls.RangeSlider  $
��Left=�6)   $��	46,61,0,0q�6D   $	��Top=�6W   $��47��6o   $	��417��6{   5      5      �� 5      $��TabItem��6   .��5      � ���	#FFE5E5E5.+�5      /  )MahApps.Metro.Controls.ToggleSwitchButton  $��ToggleSwitchButton��60   $
��Left=�6M   $��62��6h   $��	44,10,0,0q�6t   $	��Top=�6�   $	��300��6�   5      5      5      4  .MahApps.Metro.Controls.MetroAnimatedTabControl  5   
   $
��Left=�6)   $��
51,252,0,0q�6D   $	��Top=�6X   $	��200��6p   $	��573��6}   .@�5      �� $��TabItem��6   .��5      � ���	#FFE5E5E5.+�5        $
��Left=�6)   $��	46,61,0,0q�6D   $	��Top=�6W   $��47��6o   $	��166��6{   5      5      �� 5      $��TabItem��6   .��5      � ���	#FFE5E5E5.+�5        $��ToggleSwitchButton��60   $
��Left=�6M   $��62��6h   $��	73,52,0,0q�6t   $	��Top=�6�   $	��300��6�   5      5      5      �� 5    
   $0��*Note: 1: 參考 .dll ;  2: 修改 app.xmal��6   $
��Left=�6=   $��	51,34,0,0q�6X   $	��Top=�6k   �� 5!   
   -   5        $��Show Flyout��5!      $
��Left=�6'   $��
674,17,0,0q�6B   $	��Top=�6V   $��88��6n   $��42��6�   #  MahApps.Metro.Controls.Flyout  5.   
   -   5          Name$ flyout1��5.         Position$ Right=�6+      Header$ test Flyout��6<      IsOpen . .��5/      �� 
����  �.+�50      �� $��ok��6   $��3q�6&   63   �� 51      $��cancel��6   $��3q�6*   67   52      53      d� 55   
   -   5         d�Name$ editDataButton��56      $��
Test Popup��55       d� 	IsChecked$ FalseY�56      $��Right=�57      $��0,17,334,446q�6!   $��92��67   � 59   
   -   5        $��popup1��59      $��Mouse=�6   ��5:      ��  �� Path$ 	IsChecked� �� ElementName$ editDataButton��	 �� Mode$	 TwoWay=�.��5=      �� 
����  �.+�5>      �� $��ok��6   $��3q�6&   63   �� 5?      $��cancel��6   $��3q�6*   67   5@      5A      5C      5D      