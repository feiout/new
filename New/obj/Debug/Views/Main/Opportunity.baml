   M S B A M L   `   `   `  ����>  :New, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:New.BaseNew.Base  5           New.Views.Main.Opportunity   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'baseclr-namespace:New.Base     5      \ XTorpedo.Windows.Controls.Charting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullY UTorpedo.Windows.Controls.Input, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullS OTorpedo.Windows.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null^ ZTorpedo.Windows.Controls.Navigation, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\	 XTorpedo.Windows.Controls.GridView, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullO
 KTorpedo.Windows.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullT PTorpedo.Windows.Documents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aTorpedo.Windows.Controls.DataVisualization, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullX TTorpedo.Windows.Controls.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullOtorpedo1http://schemas.torpedo.com/2008/xaml/presentation	     	 
    5         New.Base.ChildControlBase    Initialized$-  'Opportunity_OnInitialized_OnInitialized��5      .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   6*   �� 5      $��* �6   6)   .+�5   
   � $��0��6   $��0,0,0,1q�6   .+�5      � $	��Top=�6   $
��Auto��6(   ���#9fa8da � ColumnDefinitions 5      �� 5      $��70 �6'   64   �� 5      $	��150 �6'   65   �� 5      $��55 �6'   64   �� 5      $	��150 �6'   65   �� 5      $��18 �6'   64   �� 5      $��80 �6'   64   �� 5      $��5 �6'   63   �� 5      $	��110 �6'   65   �� 5      $��18 �6'   64   �� 5      $	��110 �6'   65   �� 5      $��45 �6'   64   �� 5      $��90 �6'   64   �� 5       $��60 �6'   64   �� 5!      $��* �6'   63   .+�5#      �� $��	 Campaign��6   $��0��6-   $��0��6:    �� TextAlignment$ Right=�6J   $��Center=�6`   $��12(�6}   $
��Bold"�6�   $��0,8,0,0q�6�   1  +Torpedo.Windows.Controls.RadAutoCompleteBox  5$      -   5        $��Campaign��5$   -   $��0��6=   $��1��6J    �� IsInputMethodEnabled .  $
��auto��6�      Rad-Auto-Complete-Box#���   6�      DisplayMemberPath$
 name��5%   e      SelectionMode$ Single=�5&   -      TextSearchMode$ Contains=�6D      TextSearchPath$
 name��6^   	   AutoCompleteMode$	 SuggestAppend=�6t   
 � ToolTip$C
 =Quick search like : company name ,customer name, phone, email��5'   -      ItemsSource 5%   -   �� *CommonSearchDTOList+ �� Mode$ TwoWay=�   SelectedItems 6~   �� *CommonSearchDTO+   
SearchText 5&   �   �� *name+$ OneWay=�5'   -   �� 5(      $�� Status��6   $��0��6+   $��2��68   $ Right=�6H   $��Center=�6^   $��12(�6{   $
��Bold"�6�   $��0,8,0,0q�6�   *  $Torpedo.Windows.Controls.RadComboBox  5)      -   5          Name$ 
CaseStatus��5)   &   $��0��6:   $��3��6G     Rad-ComboBox#���  6W    �� DisplayMemberPath$
 Name��5+   .    �� SelectedValuePath$
 Code��6G   ��5*   .   �� *Dictionary[CaseStatus]+$ OneWay=�5+   G     5,      -   5        $ DateType��5,   &   ���#9fa8da#���  5-   -   $
��Bold"�6T   $
 Name��5.   -   $
 Code��6F   $��0��6_   $��5��6l   ��5,   8   �� *Dictionary[DateType]+$ OneWay=�50      ,  &Torpedo.Windows.Controls.RadDatePicker  51      -   5        $��Cstart��52   I     Rad-DatePicker#���  51   (   0  *Torpedo.Windows.Controls.RadDateTimePicker   DateTimeWatermarkContent$ start��52   (   $��0��6W   $��7��6d   $��0,1,0,1q�6t   �� 53      $��~��6     Text-Block-Title#���  6%   $��0��6P   $��8��6]   $ Center=�6m     54      -   5        $
��Cend��56   D   #���  54   (   $
��Left=�55   (   $	 end��56   %   $��0��6P   $��9��6]   $��0,1,0,1q�6m   �� 59      $�� Sales��6   $��0��6*   $��10��67   $ Right=�6H   $��Center=�6^   $��12(�6{   $
��Bold"�6�   $��0,8,0,0q�6�     5:      -   5        $ SalesCombox��5:   &   $��0��6;   $��11��6H   #���  6Y   $
 Name��5<   .   $
 Code��6G   ��5;   .   �� *Dictionary[CaseType]+$ OneWay=�5<   G   �� 5?      $��0��6   $��12��6*    �� Orientation$ 
Horizontal=�6;   $��Center=�6T   $
��auto��6q   .+�5@      �  5A      �� 5B      $��1* �6/   6<   �� 5C      $��1* �6/   6<   .+�5E      �� $��Center=�6"   $��0��6?   $��0��6L    
 Search#���  6\   $
 查询callList...��6}   �� 5F      $��Center=�6"   $��0��6?   $��1��6L     Refresh#���  6\   $
 刷新callList...��6~   5G      5H      � 5I      $��0��6   $��13��6$   .+�5J        -   5        $��Search��5J   1    .  $
��auto��6h   #���   6u   $
 name��5K   e   $ Single=�5L   -   $ Contains=�6D   $
 name��6^   $	 SuggestAppend=�6t   $C
 =Quick search like : company name ,customer name, phone, email��5M   -    5K   -   �� *CommonSearchDTOList+$ TwoWay=� 6~   �� *CommonSearchDTO+ 5L   �   �� *name+$ OneWay=�5M   -   5N      5P      5Q      � 5S   
   $��1��6   $��0,0,0,1q�6   .+�5T      * 	 $Torpedo.Windows.Controls.RadGridView  -   5          Name$ GridDrug��5T   "     GridViewNormal#���  5U        GridViewHeaderRow; 	 5Torpedo.Windows.Controls.GridView.GridViewDataControl   HeaderRowStyle# �  6G     GridViewRowNormal   RowStyle# �  5V       	 GridViewAlternateRowNormal   AlternateRowStyle# � 	 6M      
IsReadOnly .    SelectionMode$ Single=�5W   _   * 
 $Torpedo.Windows.Controls.DataControl   ItemsSource 6   �� *
UserList+$ TwoWay=�   Columns 5X      1	 	 +Torpedo.Windows.Controls.GridViewDataColumn	  5Y      6
 	 0Torpedo.Windows.Controls.GridViewBoundColumnBase 
  Header$ LeadID��61   - 	 'Torpedo.Windows.Controls.GridViewColumn   Width? 	 9Torpedo.Windows.Controls.GridView.GridViewLengthConverter$
 1.5* 6A    
 GridViewHeaderCell   HeaderCellStyle# � 
 6O      CellTemplate 5Z      �� 5[      .R�5\   "   (  "Torpedo.Windows.Controls.RadButton    ButtonInCell#���  64   ��6[   �� *name+
  � Tag  6t   �� *id+5]      5_      	  5a      $ Company��61   $
 1.5* 6B   # � 
 6P    5b      �� 5c      .R�5d   "     #���  64   ��6[   �� *
department+  6z   �� *id+5e      5g      	  5i      $
 Name��61   $
 1.5* 6?   # � 
 6L    5j      �� 5k      .R�5l   "     #���  64   ��6[   �� *
userType+  6x   �� *id+5m      5o      	  5q      $ 	Workphone��61   $
 1.5* 6D   # � 
 6R    5r      �� 5s      .R�5t   "     #���  64   ��6[   �� *
department+  6z   �� *id+5u      5w      	  5y      $ 	Cellphone��61   $
 1.5* 6D   # � 
 6Q    5z      �� 5{      .R�5|   "     #���  64   ��6[   �� *
userType+  6x   �� *id+5}      5      	  5�      $ Status��61   $
 1.5* 6A   # � 
 6N    5�      �� 5�      .R�5�   "     #���  64   ��6[   �� *
userType+  6x   �� *id+5�      5�      	  5�      $ PendingDate��61   $
 1.5* 6F   # � 
 6T    5�      �� 5�      .R�5�   "     #���  64   ��6[   �� *name+  6t   �� *id+5�      5�      	  5�      $ Sales��61   $
 1.5* 6@   # � 
 6N    5�      �� 5�      .R�5�   "     #���  64   ��6[   �� *name+  6t   �� *id+5�      5�      5�      5�      5�      5�      