   M S B A M L   `   `   `  ����>  :New, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:New.BaseNew.Base  5          New.Views.Main.LeadList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'baseclr-namespace:New.Base     5      \ XTorpedo.Windows.Controls.Charting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullY UTorpedo.Windows.Controls.Input, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullS OTorpedo.Windows.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null^ ZTorpedo.Windows.Controls.Navigation, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\	 XTorpedo.Windows.Controls.GridView, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullO
 KTorpedo.Windows.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullT PTorpedo.Windows.Documents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aTorpedo.Windows.Controls.DataVisualization, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullX TTorpedo.Windows.Controls.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullOtorpedo1http://schemas.torpedo.com/2008/xaml/presentation	     	 
    5         New.Base.ChildControlBase    Initialized$  LeadList_OnInitialized��5   )   .��5
      �  � RowDefinitions 5   
   �� 5      $��30 �6   6*   �� 5      $��* �6   6)   .+�5   
   � $��0��6   $��0,0,0,1q�6   .+�5      � $	��Top=�6   $
��Auto��6(   ���#9fa8da � ColumnDefinitions 5      �� 5      $��70 �6'   64   �� 5      $	��150 �6'   65   �� 5      $��55 �6'   64   �� 5      $	��150 �6'   65   �� 5      $��18 �6'   64   �� 5      $��80 �6'   64   �� 5      $��5 �6'   63   �� 5      $	��110 �6'   65   �� 5      $��18 �6'   64   �� 5      $	��110 �6'   65   �� 5      $��45 �6'   64   �� 5      $��90 �6'   64   �� 5      $��60 �6'   64   �� 5       $��* �6'   63   .+�5"      �� $��	 Campaign��6   $��0��6-   $��0��6:    �� TextAlignment$ Right=�6J   $��Center=�6`   $��12(�6}   $
��Bold"�6�   $��0,8,0,0q�6�   1  +Torpedo.Windows.Controls.RadAutoCompleteBox  5#      -   5        $��Campaign��5#   -   $��0��6=   $��1��6J    �� IsInputMethodEnabled .  $
��auto��6�      Rad-Auto-Complete-Box#���   6�      DisplayMemberPath$
 name��5$   e      SelectionMode$ Single=�5%   -      TextSearchMode$ Contains=�6D      TextSearchPath$
 name��6^   	   AutoCompleteMode$	 SuggestAppend=�6t   
 � ToolTip$C
 =Quick search like : company name ,customer name, phone, email��5&   -      ItemsSource 5$   -   �� *CommonSearchDTOList+ �� Mode$ TwoWay=�   SelectedItems 6~   �� *CommonSearchDTO+   
SearchText 5%   �   �� *name+$ OneWay=�5&   -   �� 5'      $�� Status��6   $��0��6+   $��2��68   $ Right=�6H   $��Center=�6^   $��12(�6{   $
��Bold"�6�   $��0,8,0,0q�6�   *  $Torpedo.Windows.Controls.RadComboBox  5(      -   5          Name$ 
CaseStatus��5(   &   $��0��6:   $��3��6G     Rad-ComboBox#���  6W    �� DisplayMemberPath$
 Name��5*   .    �� SelectedValuePath$
 Code��6G   ��5)   .   �� *Dictionary[CaseStatus]+$ OneWay=�5*   G     5+      -   5        $ DateType��5+   &   ���#9fa8da#���  5,   -   $
��Bold"�6T   $
 Name��5-   -   $
 Code��6F   $��0��6_   $��5��6l   ��5+   8   �� *Dictionary[DateType]+$ OneWay=�5/      ,  &Torpedo.Windows.Controls.RadDatePicker  50      -   5        $��Cstart��51   I     Rad-DatePicker#���  50   (   0  *Torpedo.Windows.Controls.RadDateTimePicker   DateTimeWatermarkContent$ start��51   (   $��0��6W   $��7��6d   $��0,1,0,1q�6t   �� 52      $��~��6     Text-Block-Title#���  6%   $��0��6P   $��8��6]   $ Center=�6m     53      -   5        $
��Cend��55   D   #���  53   (   $
��Left=�54   (   $	 end��55   %   $��0��6P   $��9��6]   $��0,1,0,1q�6m   �� 58      $�� Sales��6   $��0��6*   $��10��67   $ Right=�6H   $��Center=�6^   $��12(�6{   $
��Bold"�6�   $��0,8,0,0q�6�     59      -   5        $ SalesCombox��59   &   $��0��6;   $��11��6H   #���  6Y   $
 Name��5;   .   $
 Code��6G   ��5:   .   �� *Dictionary[CaseType]+$ OneWay=�5;   G   �� 5>      $��0��6   $��12��6*    �� Orientation$ 
Horizontal=�6;   $��Center=�6T   $
��auto��6q   .+�5?      �  5@      �� 5A      $��1* �6/   6<   �� 5B      $��1* �6/   6<   .+�5D      �� $��Center=�6"   $��0��6?   $��0��6L    
 Search#���  6\   $
 查询callList...��6}   �� 5E      $��Center=�6"   $��0��6?   $��1��6L     Refresh#���  6\   $
 刷新callList...��6~   5F      5G      � 5H      $��0��6   $��13��6$   .+�5I        -   5        $��Search��5I   1    .  $
��auto��6h   #���   6u   $
 name��5J   e   $ Single=�5K   -   $ Contains=�6D   $
 name��6^   $	 SuggestAppend=�6t   $C
 =Quick search like : company name ,customer name, phone, email��5L   -    5J   -   �� *CommonSearchDTOList+$ TwoWay=� 6~   �� *CommonSearchDTO+ 5K   �   �� *name+$ OneWay=�5L   -   5M      5O      5P      � 5R   
   $��1��6   $��0,0,0,1q�6   .+�5S      * 	 $Torpedo.Windows.Controls.RadGridView  -   5          Name$ GridDrug��5S   "     GridViewNormal#���  5T        GridViewHeaderRow; 	 5Torpedo.Windows.Controls.GridView.GridViewDataControl   HeaderRowStyle# �  6G     GridViewRowNormal   RowStyle# �  5U       	 GridViewAlternateRowNormal   AlternateRowStyle# � 	 6M      
IsReadOnly .    SelectionMode$ Single=�5V   _   * 
 $Torpedo.Windows.Controls.DataControl   ItemsSource 6   �� *
UserList+$ TwoWay=�   Columns 5W      1	 	 +Torpedo.Windows.Controls.GridViewDataColumn	  5X      6
 	 0Torpedo.Windows.Controls.GridViewBoundColumnBase 
  Header$ LeadID��61   - 	 'Torpedo.Windows.Controls.GridViewColumn   Width? 	 9Torpedo.Windows.Controls.GridView.GridViewLengthConverter$
 1.5* 6A    
 GridViewHeaderCell   HeaderCellStyle# � 
 6O      CellTemplate 5Y      �� 5Z      .R�5[   "   (  "Torpedo.Windows.Controls.RadButton    ButtonInCell#���  64   ��6[   �� *name+
  � Tag  6t   �� *id+5\      5^      	  5`      $ Company��61   $
 1.5* 6B   # � 
 6P    5a      �� 5b      .R�5c   "     #���  64   ��6[   �� *
department+  6z   �� *id+5d      5f      	  5h      $
 Name��61   $
 1.5* 6?   # � 
 6L    5i      �� 5j      .R�5k   "     #���  64   ��6[   �� *
userType+  6x   �� *id+5l      5n      	  5p      $ 	Workphone��61   $
 1.5* 6D   # � 
 6R    5q      �� 5r      .R�5s   "     #���  64   ��6[   �� *
department+  6z   �� *id+5t      5v      	  5x      $ 	Cellphone��61   $
 1.5* 6D   # � 
 6Q    5y      �� 5z      .R�5{   "     #���  64   ��6[   �� *
userType+  6x   �� *id+5|      5~      	  5�      $ Status��61   $
 1.5* 6A   # � 
 6N    5�      �� 5�      .R�5�   "     #���  64   ��6[   �� *
userType+  6x   �� *id+5�      5�      	  5�      $ PendingDate��61   $
 1.5* 6F   # � 
 6T    5�      �� 5�      .R�5�   "     #���  64   ��6[   �� *name+  6t   �� *id+5�      5�      	  5�      $ Sales��61   $
 1.5* 6@   # � 
 6N    5�      �� 5�      .R�5�   "     #���  64   ��6[   �� *name+  6t   �� *id+5�      5�      5�      5�      5�      5�      