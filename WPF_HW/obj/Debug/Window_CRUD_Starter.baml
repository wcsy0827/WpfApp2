   M S B A M L   `   `   `  ����A  =WPF_HW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:WpfApplication1._4._WPF_多媒體應用'WpfApplication1._4._WPF_多媒體應用  5   	   J FMyAWEntityModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullJ6clr-namespace:MyAWEntityModel;assembly=MyAWEntityModelMyAWEntityModel 5   	   T    NWpfApplication1._4._WPF_多媒體應用.Window_DataSourceTool_DataGrid_Starter   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:WpfApplication1._4._WPF_多媒體應用     5   	   RMyAWEntityModel6clr-namespace:MyAWEntityModel;assembly=MyAWEntityModel     5   	   -   5          � Title$$  Window_DataSourceTool_DataGrid��5	   	   $��702.895��60   $��1073.566��6A    � 	Resources 5
         productPhotoViewSource��%   &	        �� 5   
   6   5      .��5      �  � DataContext# [  6    5   
    �� Source �� MergedDictionaries�� 5      $I C/WpfApp_Class;component/MyThemesStyle/Dictionary_DataGridStyle.xaml?�6!    5      �� 5      $H B/WpfApp_Class;component/MyThemesStyle(2)/Dictionary_ShinyBlue.xaml?�6)   6w   �� 5      $W Q/WpfApp_Class;component/MyThemesStyle/Dictionary_GelButtonResourceDictionary.xaml?�6)   6�   �� 5      $G A/WpfApp_Class;component/MyThemesStyle/Dictionary_ButtonStyle.xaml?�6)   6v   �� 5      $I C/WpfApp_Class;component/MyThemesStyle/Dictionary_DataGridStyle.xaml?�6)   6x   %    5       � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��7 �6   �� 5      $��* �6    � RowDefinitions 5!   
   �� 5"      $
��Auto �6   �� 5#      $
��Auto �6   �� 5$      $
��287* �6   .+�5'   
   &   System.Windows.Controls.DataGrid  -   5          Name$ productPhotoDataGrid��5'         RowDetailsVisibilityMode$ VisibleWhenSelected=�61   $��2��6`   	   EnableRowVirtualization	 . $��2��6�   
   AutoGenerateColumns
 .  ��6m   ��    Columns 5(      4  .System.Windows.Controls.DataGridTemplateColumn  5)      -   5        largePhotoColumn��,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 5)   C      Header$ Large Photo��6X      CellTemplate 5*      �� 5+      .R�5,      �� ��6$   �� *
LargePhoto+5-      5/      0  *System.Windows.Controls.DataGridTextColumn  50      -   5        largePhotoFileNameColumn��$ SizeToHeader 50   G   $ Large Photo File Name��6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6{   �� *LargePhotoFileName+  51      -   5        modifiedDateColumn��$ SizeToHeader 51   E   $ Modified Date��6Z    52      �� 53      .R�54      (  "System.Windows.Controls.DatePicker     SelectedDate 6)   �� *ModifiedDate+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 55      57        58      -   5        productPhotoIDColumn��$ SizeToHeader 58   C   $ Product Photo ID��6X    6r   �� *ProductPhotoID+  59      -   5        thumbNailPhotoColumn��$ SizeToHeader 59   G   $ Thumb Nail Photo��6\    5:      �� 5;      .R�5<      �� ��6$   �� *ThumbNailPhoto+5=      5?        5@      -   5         thumbnailPhotoFileNameColumn��$ SizeToHeader 5@   K   $ Thumbnail Photo File Name��6`    6�   �� *ThumbnailPhotoFileName+5B      � 5C   
   -	   5         �Name$ grid1��5C   2   
�������$��20q�6&   $��2��6A    5D      �� 5E      $
��Auto �6#   �� 5F      $
��Auto �6#    5H      �� 5I      $
��Auto �6    �� 5J      $
��Auto �6    �� 5K      $
��Auto �6    �� 5L      $
��Auto �6    �� 5M      $
��Auto �6    �� 5N      $
��Auto �6    .+�5P      �� 
���   �$��Large Photo:��6'   $��0��6>   $
��Left=�6N   $��3q�6i   $��0��6t   $��Center=�6�   �� 5Q      -
   5         ��Name$ largePhotoImage��5Q      $��1��6-   $
��Left=�6=   $��3q�6X   $��0��6c   $��Center=�6�   ��6p   �� *
LargePhoto+6�   �� 5R      
���   �$��Large Photo File Name:��6'   $��0��6H   $
��Left=�6X   $��3q�6s   $��1��6~   $��Center=�6�   �� 5S      -   5         ��Name$ largePhotoFileNameTextBox��5S      $��1��69   $
��Left=�6I   $��23��6d   $��3q�6p   $��1��6{   $��Center=�6�   $	��120��6  ��6�   �� *LargePhotoFileName+$ TwoWay=� .  . 6  �� 5T      
���   �$��Modified Date:��6'   $��0��6@   $
��Left=�6P   $��3q�6k   $��2��6v   $��Center=�6�     5U      -   5          Name$ modifiedDateDatePicker��5U      $��1��69   $
��Left=�6I   $��3q�6d   $��2��6o   $��Center=�6�    6|   �� *ModifiedDate+$ TwoWay=� .  . 6�   �� 5V      
���   �$��Product Photo ID:��6(   $��0��6D   $
��Left=�6T   $��3q�6o   $��3��6z   $��Center=�6�   �� 5W      -   5        $ productPhotoIDTextBox��5W      $��1��65   $
��Left=�6E   $��23��6`   $��3q�6l   $��3��6w   $��Center=�6�   $	��120��6  ��6�   �� *ProductPhotoID+$ TwoWay=� .  . 6  �� 5X      
���   �$��Thumb Nail Photo:��6(   $��0��6D   $
��Left=�6T   $��3,0,0,3q�6o   $��4��6�   $��Bottom=�6�   �� 5Y      -   5        $ thumbNailPhotoImage��5Y      $��1��61   $
��Left=�6A   $��3q�6\   $��4��6g   $��Center=�6�   ��6t   �� *ThumbNailPhoto+6�   �� 5Z      
���   �$ ��Thumbnail Photo File Name:��6(   $��0��6M   $
��Left=�6]   $��3q�6x   $��5��6�   $��Center=�6�   �� 5[      -   5        $# thumbnailPhotoFileNameTextBox��5[      $��1��6=   $
��Left=�6M   $��23��6h   $��3q�6t   $��5��6   $��Center=�6�   $	��120��6  ��6�   �� *ThumbnailPhotoFileName+$ TwoWay=� .  . 6  5\      �� 5]   
   $��3��6    �� Orientation$ 
Horizontal=�6)   $��76��6B   $��1��6N   .+�5^      �� -   5        $��<��5^      $��30��6$   $��4q�6/     MyCircleButton#���  6:   6c   �� 5_      -   5        
����  �$��>��5_   (   $��30��67   $��4q�6B   #���  6M   6v   �� 5`      -   5        $��txtyear1��5`       �� TextWrapping$
 Wrap=�6&   $��94��6;   $��	0,25,0,25q�6F   �� 5a      $
��Wrap=�6   $��25(�6.   $��~��6<   $��	0,25,0,25q�6E   �� 5b      -   5        $��txtyear2��5b      $
 Wrap=�6&   $��94��6;   $��	0,25,0,25q�6F   �� 5c      -   5        $��Search��5c      $��60��6&   $��4,4,4,0q�61   #���  6B   $��72��6k   $	��Top=�6w   6�   �� 5d      -   5        
����  �$	��Add��5d   (   $��85��66   $��4q�6A     MyGelButton#���  6L   6r   �� 5e      -   5        
����  �$��Remove��5e   (   $��85��69   $��4q�6D   #���  6O   6u   �� 5f      -   5        
����  �$��Modify��5f   (   $��85��69   $��4q�6D   #���  6O   6u   �� 5g      -   5        
���\\��$��Update Batch��5g   -   $��85��6D   $��4q�6O   #���  6Z   6�   5j      �� 5k   
   -   5         ��Name$ 	textBlock��5k   *   $��3��6   $��70��6=   $��ProductPhotos CRUD��6J   $��40(�6d   $
��Left=�6r   $	��Top=�6�   $��Showcard Gothic)�6�   $	��529��6�   ��5l      �� 5m       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5n      �  � Color$ 	LightBlue��6#    � Offset$ 0Q�65   � 5o      $
 Blue��6#   $ 1Q�60   5p      5r      �� 5s   
   
���  ��$��1��6)   $��2��69   $��Stretch=�6F   6f   5t      5u      