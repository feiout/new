   M S B A M L   `   `   `  ����>  :New, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:New.BaseNew.Base  5          New.Views.Main.TaskList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      \ XTorpedo.Windows.Controls.Charting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullY UTorpedo.Windows.Controls.Input, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullS OTorpedo.Windows.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null^ ZTorpedo.Windows.Controls.Navigation, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\	 XTorpedo.Windows.Controls.GridView, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullO
 KTorpedo.Windows.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullT PTorpedo.Windows.Documents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aTorpedo.Windows.Controls.DataVisualization, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullX TTorpedo.Windows.Controls.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullOtorpedo1http://schemas.torpedo.com/2008/xaml/presentation	     	 
    5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      !baseclr-namespace:New.Base  5         New.Base.ChildControlBase    Initialized$.  (TaskList_OnInitializedList_OnInitialized��5	      .��5      � .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TransitioningContentSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6Q   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromRight+   Duration$ 0:0:0.2X�.��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   6*   �� 5      $��* �6   6)   .+�5   
   � $��0��6   $��0,0,0,1q�6   .+�5      � $	��Top=�6   $
��Auto��6(   ���#9fa8da � ColumnDefinitions 5      �� 5      $	��425 �6'   65   �� 5      $��95 �6'   64   �� 5      $��* �6'   63   .+�5      � $��0��6   $��0��6$   $��Center=�64    5      �� 5      $��70 �6+   68   �� 5      $	��150 �6+   69   �� 5      $��55 �6+   68   �� 5      $	��150 �6+   69   .+�5       �� $��	Campaign ��6    $��0��61   $��0��6>      Text-Block-Title#���   6N   1  +Torpedo.Windows.Controls.RadAutoCompleteBox  5!      -   5        $��Campaign��5!   1   $��0��6A   $��1��6N    �� IsInputMethodEnabled .  $
��auto��6�     Rad-Auto-Complete-Box#���  6�      DisplayMemberPath$
 name��5"   e      SelectionMode$ Single=�5#   -   	   TextSearchMode$	 Contains=�6D   
   TextSearchPath$

 name��6^      AutoCompleteMode$ SuggestAppend=�6t    � ToolTip$C =Quick search like : company name ,customer name, phone, email��5$   -      ItemsSource 5"   -   �� *CommonSearchDTOList+ �� Mode$ TwoWay=�   SelectedItems 6~   �� *CommonSearchDTO+   
SearchText 5#   �   �� *name+$ OneWay=�5$   -   �� 5%      $��Status ��6    $��0��6/   $��2��6<   #���   6L   *  $Torpedo.Windows.Controls.RadComboBox  5&      -   5          Name$ CallListStatusBox��5&   *   $��0��6E   $��3��6R     Rad-ComboBox#���  6b    �� DisplayMemberPath$
 Name��5(   .    �� SelectedValuePath$
 Code��6G   ��5'   .   �� *Dictionary[TaskType]+$ OneWay=�5(   G   5)      �� 5*      $��0��6   $��1��6*    �� Orientation$ 
Horizontal=�6:   $��Center=�6S   $
��auto��6p   .+�5+      � $��90��6    5,      �� 5-      $��30 �6,   6:    5/      �� 50      $��1* �6/   6<   �� 51      $��1* �6/   6<   �� 52      $��1* �6/   6<   .+�54      �� $��Center=�6"    
 Search#���  6?   $ 查询callList...��6`   $��0��6y   $��0��6�   �� 55      $��Center=�6"     Refresh#���  6?   $ 刷新callList...��6a   $��0��6y   $��1��6�   �� 56      -   5        $��Center=�56   "     Plus#���  6?   $ 创建case...��6_   $��0��6s   $��2��6�   6�   58      59      � 5:      $��0��6   $��2��6$   .+�5;        -   5        $��Search��5;   1    .  $
��auto��6h   #���  6u   $
 name��5<   e   $ Single=�5=   -   $	 Contains=�6D   $

 name��6^   $ SuggestAppend=�6t   $C =Quick search like : company name ,customer name, phone, email��5>   -    5<   -   �� *CommonSearchDTOList+$ TwoWay=� 6~   �� *CommonSearchDTO+ 5=   �   �� *name+$ OneWay=�5>   -   5?      5@      5A      � 5C   
   $��1��6   $��0,0,0,1q�6   .+�5D      * 	 $Torpedo.Windows.Controls.RadGridView  -   5          Name$ GridDrug��5D   "     GridViewNormal#���  5E        GridViewHeaderRow; 	 5Torpedo.Windows.Controls.GridView.GridViewDataControl   HeaderRowStyle# �  6G     GridViewRowNormal   RowStyle# �  5F       	 GridViewAlternateRowNormal   AlternateRowStyle# � 	 6M      
IsReadOnly .    SelectionMode$ Single=�5G   _   *	 
 $Torpedo.Windows.Controls.DataControl 	  ItemsSource 6   �� *
UserList+$ TwoWay=�   Columns 5H      1
 	 +Torpedo.Windows.Controls.GridViewDataColumn
  5I      6 	 0Torpedo.Windows.Controls.GridViewBoundColumnBase   Header$ UserName��61   - 	 'Torpedo.Windows.Controls.GridViewColumn   Width? 	 9Torpedo.Windows.Controls.GridView.GridViewLengthConverter$
 1.5* 6C    
 GridViewHeaderCell   HeaderCellStyle# � 
 6Q       CellTemplate  5J      �� 5K      .R�5L   "   (  "Torpedo.Windows.Controls.RadButton  -   5          ButtonInCell#���  5L   4   ��6[   �� *name+
! � Tag! 6t   �� *id+6�   5M      5O      
  5Q      $ 
Department��61   $
 1.5* 6E   # � 
 6S     5R      �� 5S      .R�5T   "     #���  64   ��6[   �� *
department+! 6z   �� *id+5U      5W      
  5Y      $ UserType��61   $
 1.5* 6C   # � 
 6P     5Z      �� 5[      .R�5\   "     #���  64   ��6[   �� *
userType+! 6x   �� *id+5]      5_      5b      5c      5�      5�      5�      5�      