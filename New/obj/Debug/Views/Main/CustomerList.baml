   M S B A M L   `   `   `  ����>  :New, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:New.BaseNew.Base  5      !    New.Views.Main.CustomerList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      \ XTorpedo.Windows.Controls.Charting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullY UTorpedo.Windows.Controls.Input, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullS OTorpedo.Windows.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null^	 ZTorpedo.Windows.Controls.Navigation, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\
 XTorpedo.Windows.Controls.GridView, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullO KTorpedo.Windows.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullT PTorpedo.Windows.Documents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aTorpedo.Windows.Controls.DataVisualization, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullX TTorpedo.Windows.Controls.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullOtorpedo1http://schemas.torpedo.com/2008/xaml/presentation	    	 
     5      1baseclr-namespace:New.Base	    	 
     5         New.Base.ChildControlBase    Initialized$  Customer_OnInitialized��5	      .��5      � .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TransitioningContentSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6Q   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromRight+   Duration$ 0:0:0.2X�.��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   6*   �� 5      $��* �6   6)   .+�5   
   � $��0��6   $��0,0,0,1q�6   .+�5      � $	��Top=�6   $
��Auto��6(   ���#9fa8da � ColumnDefinitions 5      �� 5      $��* �6'   63   �� 5      $��30 �6'   64   .+�5      � $��0��6   $��0��6$   .+�5      1  +Torpedo.Windows.Controls.RadAutoCompleteBox  -   5        $��Search��5   1    �� IsInputMethodEnabled .  $
��auto��6h      Rad-Auto-Complete-Box#���   6u      DisplayMemberPath$
 name��5   e      SelectionMode$ Single=�5   -   	   TextSearchMode$	 Contains=�6D   
   TextSearchPath$

 name��6^      AutoCompleteMode$ SuggestAppend=�6t    � ToolTip$C =Quick search like : company name ,customer name, phone, email��5   -      ItemsSource 5   -   �� *CommonSearchDTOList+ �� Mode$ TwoWay=�   SelectedItems 6~   �� *CommonSearchDTO+   
SearchText 5   �   �� *name+$ OneWay=�5   -   5      �� 5      $��0��6   $��1��6*    �� Orientation$ 
Horizontal=�6:   $��Center=�6S   $
��auto��6p   .+�5      �  5       �� 5!      $��1* �6/   6<   .+�5$      �� $��Center=�6"   $��0��6?   $��0��6L     Refresh#���  6\   $ 刷新callList...��6~   5&      5'      5(      5)      � 5*   
   $��1��6   $��0,0,0,1q�6   .+�5+      * 
 $Torpedo.Windows.Controls.RadGridView  -   5          Name$ GridDrug��5+   "     GridViewNormal#���  5,        GridViewHeaderRow; 
 5Torpedo.Windows.Controls.GridView.GridViewDataControl   HeaderRowStyle# �  6G     GridViewRowNormal   RowStyle# �  5-        GridViewAlternateRowNormal   AlternateRowStyle# �  6M      
IsReadOnly .    SelectionMode$ Single=�5.   _   *  $Torpedo.Windows.Controls.DataControl   ItemsSource 6   �� *
UserList+$ TwoWay=�   Columns 5/      1	 
 +Torpedo.Windows.Controls.GridViewDataColumn	  50      6
 
 0Torpedo.Windows.Controls.GridViewBoundColumnBase 
  Header$
 Name��61   - 
 'Torpedo.Windows.Controls.GridViewColumn   Width? 
 9Torpedo.Windows.Controls.GridView.GridViewLengthConverter$
 1.5* 6?     GridViewHeaderCell   HeaderCellStyle# �  6L      CellTemplate 51      �� 52      .R�53   "   (  "Torpedo.Windows.Controls.RadButton    ButtonInCell#���  64   ��6[   �� *
userType+
 � Tag 6x   �� *id+54      56      	  58      $ Company��61   $
 1.5* 6B   # �  6P    59      �� 5:      .R�5;   "     #���  64   ��6[   �� *
department+ 6z   �� *id+5<      5>      	  5@      $ 	Workphone��61   $
 1.5* 6D   # �  6R    5A      �� 5B      .R�5C   "     #���  64   ��6[   �� *
department+ 6z   �� *id+5D      5F      	  5H      $ 	Cellphone��61   $
 1.5* 6D   # �  6Q    5I      �� 5J      .R�5K   "     #���  64   ��6[   �� *
userType+ 6x   �� *id+5L      5N      	  5P      $ PendingData��61   $
 1.5* 6F   # �  6T    5Q      �� 5R      .R�5S   "     #���  64   ��6[   �� *name+ 6t   �� *id+5T      5V      5Y      5Z      5\      5]      5^      5_      