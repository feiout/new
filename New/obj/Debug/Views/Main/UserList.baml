   M S B A M L   `   `   `  ����>  :New, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:New.BaseNew.Base  5          New.Views.Main.UserList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      \ XTorpedo.Windows.Controls.Charting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullY UTorpedo.Windows.Controls.Input, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullS OTorpedo.Windows.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null^ ZTorpedo.Windows.Controls.Navigation, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\	 XTorpedo.Windows.Controls.GridView, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullO
 KTorpedo.Windows.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullT PTorpedo.Windows.Documents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aTorpedo.Windows.Controls.DataVisualization, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullX TTorpedo.Windows.Controls.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullPcontrols1http://schemas.torpedo.com/2008/xaml/presentation	     	 
    5      1baseclr-namespace:New.Base	     	 
    5         New.Base.ChildControlBase    Initialized$  UserList_OnInitialized��5      .��5
      �  � RowDefinitions 5   
   �� 5      $��30 �6   6*   �� 5      $��* �6   6)   .+�5   
   � $��0��6   $��0,0,0,1q�6   .+�5      � $	��Top=�6   $
��Auto��6(   ���#9fa8da � ColumnDefinitions 5      �� 5      $��* �6'   63   �� 5      $��30 �6'   64   .+�5      � $��0��6   $��0��6$   .+�5      1  +Torpedo.Windows.Controls.RadAutoCompleteBox  -   5        $��Search��5   2    �� IsInputMethodEnabled .  $
��auto��6i      Rad-Auto-Complete-Box#���   6v      DisplayMemberPath$
 name��5   e      SelectionMode$ Single=�5   -      TextSearchMode$ Contains=�6D      TextSearchPath$
 name��6^      AutoCompleteMode$ SuggestAppend=�6t   	 � ToolTip$C	 =Quick search like : company name ,customer name, phone, email��5   -   
   ItemsSource
 5   -   �� *CommonSearchDTOList+ �� Mode$ TwoWay=�   SelectedItems 6~   �� *CommonSearchDTO+   
SearchText 5   �   �� *name+$ OneWay=�5   -   5      �� 5      $��0��6   $��1��6*    �� Orientation$ 
Horizontal=�6:   $��Center=�6S   $
��auto��6p   .+�5      �  5      �� 5      $��1* �6/   6<   .+�5!      �� $��Center=�6"   $��0��6?   $��0��6L     Refresh#���  6\   $	 刷新callList...��6~   5#      5$      5%      5&      � 5'   
   $��1��6   $��0,0,0,1q�6   .+�5(      * 	 $Torpedo.Windows.Controls.RadGridView  -   5          Name$ GridDrug��5(   #     GridViewNormal#���  5)        GridViewHeaderRow; 	 5Torpedo.Windows.Controls.GridView.GridViewDataControl   HeaderRowStyle# �  6G     GridViewRowNormal   RowStyle# �  5*        GridViewAlternateRowNormal   AlternateRowStyle# �  6M      
IsReadOnly .    SelectionMode$ Single=�5+   _   * 
 $Torpedo.Windows.Controls.DataControl   ItemsSource 6   �� *
UserList+$ TwoWay=�   Columns 5,      1 	 +Torpedo.Windows.Controls.GridViewDataColumn  5-      6 	 0Torpedo.Windows.Controls.GridViewBoundColumnBase   Header$ UserName��6.   - 	 'Torpedo.Windows.Controls.GridViewColumn   Width?	 	 9Torpedo.Windows.Controls.GridView.GridViewLengthConverter$
 1.5*	 6@     GridViewHeaderCell   HeaderCellStyle# �  6N      CellTemplate 5.      �� 5/      .R�50      (
  "Torpedo.Windows.Controls.RadButton
  -   5          ButtonInCell#���  50   1   ��6X   �� *name+
 � Tag 6q   �� *id+6�   51      53        55      $ 
Department��6.   $
 1.5*	 6B   # �  6P    56      �� 57      .R�58      
  #���  61   ��6X   �� *
department+ 6w   �� *id+59      5;        5=      $ UserType��6.   $
 1.5*	 6@   # �  6M    5>      �� 5?      .R�5@      
  #���  61   ��6X   �� *
userType+ 6u   �� *id+5A      5C      5F      5G      5H      5I      