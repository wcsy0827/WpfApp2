   M S B A M L   `   `   `  ����G  CWpfApp_Class, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:WpfApp_Class._4._WPF_多媒體運用$WpfApp_Class._4._WPF_多媒體運用  5   	   J FMyAWEntityModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullJ6clr-namespace:MyAWEntityModel;assembly=MyAWEntityModelMyAWEntityModel 5   	   :    4WpfApp_Class._4._WPF_多媒體運用.Window_DataGrid   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:WpfApp_Class._4._WPF_多媒體運用     5   	   RMyAWEntityModel6clr-namespace:MyAWEntityModel;assembly=MyAWEntityModel     5   	   -   5          � Title$  Window_DataGrid��5	   	   $	��450��6!   $	��800��6.    � 	Resources 5
         productPhotoViewSource��%   &	        �� 5   
   6   5      .��5      �  � DataContext# [  6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ productPhotoDataGrid��5      $
��Auto��61      RowDetailsVisibilityMode$ VisibleWhenSelected=�6>   $��10,10,382,209q�6m   $
��Auto��6�      EnableRowVirtualization .    AutoGenerateColumns .  ��6�   ��    Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      -   5        largePhotoColumn��,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 5   C   	   Header$	 Large Photo��6X   
   CellTemplate
 5      �� 5      .R�5      �� ��6$   �� *
LargePhoto+5      5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        largePhotoFileNameColumn��$ SizeToHeader 5   G   $	 Large Photo File Name��6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6{   �� *LargePhotoFileName+  5      -   5        modifiedDateColumn��$ SizeToHeader 5   E   $	 Modified Date��6Z   
 5      �� 5      .R�5      (  "System.Windows.Controls.DatePicker     SelectedDate 6)   �� *ModifiedDate+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 5      5        5       -   5        productPhotoIDColumn��$ SizeToHeader 5    C   $	 Product Photo ID��6X    6r   �� *ProductPhotoID+  5!      -   5         thumbnailPhotoFileNameColumn��$ SizeToHeader 5!   K   $	 Thumbnail Photo File Name��6`    6�   �� *ThumbnailPhotoFileName+5#      � 5$   
   -   5         �Name$ grid1��5$   #   
��� ���$
��Left=�62   $��
456,45,0,0q�6M   $	��Top=�6a    � ColumnDefinitions 5%      �� 5&      $
��Auto �6#   �� 5'      $
��Auto �6#    � RowDefinitions 5)      �� 5*      $
��Auto �6    �� 5+      $
��Auto �6    �� 5,      $
��Auto �6    �� 5-      $
��Auto �6    �� 5.      $
��Auto �6    .+�50      �� $��Large Photo:��6   $��0��6+   $
��Left=�6;   $��3q�6V   $��0��6a   $��Center=�6n   �� 51      -	   5         ��Name$ largePhotoImage��51      $��1��6-   $
��Left=�6=   $��3q�6X   $��0��6c   $��Center=�6�   ��6p   �� *
LargePhoto+6�   �� 52      $��Large Photo File Name:��6   $��0��65   $
��Left=�6E   $��3q�6`   $��1��6k   $��Center=�6x   �� 53      -
   5         ��Name$ largePhotoFileNameTextBox��53      $��1��69   $
��Left=�6I   $��23��6d   $��3q�6p   $��1��6{   $��Center=�6�   $	��120��6  ��6�   �� *LargePhotoFileName+$ TwoWay=� .  . 6  �� 54      $��Modified Date:��6   $��0��6-   $
��Left=�6=   $��3q�6X   $��2��6c   $��Center=�6p     55      -   5          Name$ modifiedDateDatePicker��55      $��1��69   $
��Left=�6I   $��3q�6d   $��2��6o   $��Center=�6�    6|   �� *ModifiedDate+$ TwoWay=� .  . 6�   �� 56      $��Product Photo ID:��6   $��0��60   $
��Left=�6@   $��3q�6[   $��3��6f   $��Center=�6s   �� 57      -   5        $ productPhotoIDTextBox��57      $��1��65   $
��Left=�6E   $��23��6`   $��3q�6l   $��3��6w   $��Center=�6�   $	��120��6  ��6�   �� *ProductPhotoID+$ TwoWay=� .  . 6  �� 58      $ ��Thumbnail Photo File Name:��6   $��0��69   $
��Left=�6I   $��3q�6d   $��4��6o   $��Center=�6|   �� 59      -   5        $# thumbnailPhotoFileNameTextBox��59      $��1��6=   $
��Left=�6M   $��23��6h   $��3q�6t   $��4��6   $��Center=�6�   $	��120��6  ��6�   �� *ThumbnailPhotoFileName+$ TwoWay=� .  . 6  5:      5<      5=      