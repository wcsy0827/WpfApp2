   M S B A M L   `   `   `  ����G  CWpfApp_Class, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:WpfApp_Class.XMAL_LanguageWpfApp_Class.XMAL_Language  5   	   1    +WpfApp_Class.XMAL_Language.Window_MyNotepad   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:WpfApp_Class.XMAL_Language     5   	     � Title$  Window_MyNotepad��5   	   $	��450��6"   $	��800��6/   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��42* �6   �� 5      $
��377* �6   .+�5   
   �� -   5        $��textbox1��5      $��1��6"    �� TextWrapping$
 Wrap=�6/   $��TextBox��6C   o� 5   
   $��	0,0,10,10q�6   $��20(�6"   $��Mistral)�60   $
��Bold"�6E   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFE2E4D2��6#    � Offset$ 1Q�65   � 5      $ 	#FFFFCB5C��6#   5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 10Q�6#   .@�5      m� $
��File��6   .@�5      m� -   5        $��OpenFile��5      6-   m� 5      -   5        $
��Save��5      6)   5      m� 5      $
��Edit��6   .@�5      m� -   5        $	��Cut��5      6(   m� 5      -   5        $
��Copy��5      6)   m� 5       -   5        $��Paste��5       6*   5!      m� 5"      $��Colors��6   .@�5#      	� -   5        
���  ��5#   0   	� 5$      -   5        
��� � �5$   0   	� 5%      -	   5        
����  �5%   0   	� 5&      -
   5        
���   �5&   1   5'      m� 5(      -   5        $
��Exit��5(      6&   5)      5+      5,      