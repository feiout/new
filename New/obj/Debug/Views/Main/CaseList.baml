   M S B A M L   `   `   `  ����>  :New, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:New.BaseNew.Base  5          New.Views.Main.CaseList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      \ XTorpedo.Windows.Controls.Charting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullY UTorpedo.Windows.Controls.Input, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullS OTorpedo.Windows.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null^ ZTorpedo.Windows.Controls.Navigation, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\	 XTorpedo.Windows.Controls.GridView, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullO
 KTorpedo.Windows.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullT PTorpedo.Windows.Documents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aTorpedo.Windows.Controls.DataVisualization, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullX TTorpedo.Windows.Controls.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullOtorpedo1http://schemas.torpedo.com/2008/xaml/presentation	     	 
    5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      !baseclr-namespace:New.Base  5         New.Base.ChildControlBase    Initialized$  CaseList_OnInitialized��5	       � 	Resources 5      "   New.Base.DictionaryConverter   DictionaryConverter��%   &	          5   
   6#   5      .��5      � .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TransitioningContentSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6Q   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromRight+   Duration$ 0:0:0.2X�.��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   6*   �� 5      $��* �6   6)   �� 5      $��38 �6   6*   .+�5   
   � $��0��6   $��0,0,0,1q�6   .+�5      � $	��Top=�6   $
��Auto��6(   ���#9fa8da � ColumnDefinitions 5      �� 5      $��70 �6'   64   �� 5      $	��150 �6'   65   �� 5      $��55 �6'   64   �� 5      $	��150 �6'   65   �� 5      $��18 �6'   64   �� 5       $��80 �6'   64   �� 5!      $��5 �6'   63   �� 5#      $	��110 �6'   65   �� 5$      $��18 �6'   64   �� 5%      $	��110 �6'   65   �� 5'      $��45 �6'   64   �� 5(      $��90 �6'   64   �� 5*      $��60 �6'   64   �� 5+      $��* �6'   63   .+�5-      �� $��	 Campaign��6   $��0��6-   $��0��6:    �� TextAlignment$ Right=�6J   $��Center=�6`   $��12(�6}   $
��Bold"�6�   $��0,8,0,0q�6�   1  +Torpedo.Windows.Controls.RadAutoCompleteBox  5.      -   5        $��Campaign��5.   -   $��0��6=   $��1��6J    �� IsInputMethodEnabled .  $
��auto��6�     Rad-Auto-Complete-Box#���  6�   	   DisplayMemberPath$
	 name��5/   a   
   SelectionMode$
 Single=�50   -      TextSearchMode$ Contains=�6D      TextSearchPath$
 name��6^      AutoCompleteMode$ SuggestAppend=�6t      ItemsSource 5/   -   �� *SaleProjectList+ �� Mode$ TwoWay=�   
SearchText 50   �   �� *name+$ OneWay=��� 51      $�� Status��6   $��0��6+   $��2��68   $ Right=�6H   $��Center=�6^   $��12(�6{   $
��Bold"�6�   $��0,8,0,0q�6�   *  $Torpedo.Windows.Controls.RadComboBox  52      -   5          Name$ 
CaseStatus��52   &   $��0��6:   $��3��6G     Rad-ComboBox#���  6W    �� DisplayMemberPath$
 Name��54   .    �� SelectedValuePath$
 Code��6G   ��53   .   �� *Dictionary[CaseStatus]+$ OneWay=�55   -     56      -   5        $ DateType��56   &   ���#9fa8da#���  57   -   $
��Bold"�6T   $
 Name��58   -   $
 Code��6F   $��0��6_   $��5��6l   ��56   8   �� *Dictionary[DateType]+$ OneWay=�5:      ,  &Torpedo.Windows.Controls.RadDatePicker  5<      -   5        $��Cstart��5=   I     Rad-DatePicker#���  5<   (   0	  *Torpedo.Windows.Controls.RadDateTimePicker 	  DateTimeWatermarkContent$ start��5=   (   $��0��6W   $��7��6d   $��0,1,0,1q�6t   �� 5>      $��~��6     Text-Block-Title#���  6%   $��0��6P   $��8��6]   $ Center=�6m     5?      -   5        $
��Cend��5A   D   #���  5?   (   $
��Left=�5@   (   $	 end��5A   %   $��0��6P   $��9��6]   $��0,1,0,1q�6m   �� 5C      $�� Type��6   $��0��6)   $��10��66   $ Right=�6G   $��Center=�6]   $��12(�6z   $
��Bold"�6�   $��0,8,0,0q�6�     5D      -   5        $ CaseType��5D   &   $��0��68   $��11��6E   #���  6V   $
 Name��5F   .   $
 Code��6G   ��5E   .   �� *Dictionary[CaseType]+$ OneWay=�5G   -   �� 5I      $��0��6   $��12��6*    �� Orientation$ 
Horizontal=�6;   $��Center=�6T   $
��auto��6q   .+�5J      �  5K      �� 5L      $��1* �6/   6<   �� 5M      $��1* �6/   6<   .+�5O      �� $��Center=�6"   $��0��6?   $��0��6L    
 Search#���  6\    � ToolTip$ 查询callList...��6}   �� 5P      -   5        $��Center=�5P   "   $��0��6?   $��1��6L     Refresh#���  6\   $ 刷新callList...��6~   6�   5Q      5R      � 5S      $��0��6   $��13��6$   .+�5T        -	   5        $��Search��5T   1    .  $
��auto��6h   #���  6u   $
	 name��5U   e   $
 Single=�5V   -   $ Contains=�6D   $
 name��6^   $ SuggestAppend=�6t   $C =Quick search like : company name ,customer name, phone, email��5W   -    5U   -   �� *CommonSearchDTOList+$ TwoWay=�   SelectedItems 6~   �� *CommonSearchDTO+ 5V   �   �� *name+$ OneWay=�5W   -   5X      5Z      5[      � 5\   
   $��1��6   $��0,0,0,1q�6   .+�5]      *
 	 $Torpedo.Windows.Controls.RadGridView
  -
   5         
 Name$ Cases��5]   "     GridViewNormal#���  5^        GridViewHeaderRow; 	 5Torpedo.Windows.Controls.GridView.GridViewDataControl   HeaderRowStyle# �  6G    	 GridViewRowNormal   RowStyle# � 	 5_       
 GridViewAlternateRowNormal   AlternateRowStyle# � 
 6M      
IsReadOnly .    SelectionMode$ Single=�5`   \   * 
 $Torpedo.Windows.Controls.DataControl   ItemsSource 6   �� *cases+$ TwoWay=�   Columns 5a      1 	 +Torpedo.Windows.Controls.GridViewDataColumn  5b      6 	 0Torpedo.Windows.Controls.GridViewBoundColumnBase    Header$  CaseID��61   - 	 'Torpedo.Windows.Controls.GridViewColumn!   Width? 	 9Torpedo.Windows.Controls.GridView.GridViewLengthConverter$
! 1.5* 6A     GridViewHeaderCell"   HeaderCellStyle#" �  6O   #   CellTemplate# 5c      �� 5d      .R�5e   "   (  "Torpedo.Windows.Controls.RadButton    ButtonInCell#���  64   ��6[   �� *caseId+
$ � Tag$ 6v   �� *caseId+5f      5h        5j      $  Company��61   $
! 1.5* 6B   #" �  6P   # 5k      �� 5l      .R�5m   "     #���  64   ��6[   �� *companyName+$ 6{   �� *	companyId+5n      5p        5r      $
  Name��61   $
! 1.5* 6?   #" �  6L   # 5s      �� 5t      .R�5u   "     #���  64   ��6[   �� *customerName+$ 6|   �� *
customerId+5v      5x        5z      $  	Workphone��61   $
! 1.5* 6D   #" �  6R   # 5{      �� 5|      .R�5}   "     #���  64   ��6[   �� *	workphone+$ 6y   �� *caseId+5~      5�        5�      $  	Cellphone��61   $
! 1.5* 6D   #" �  6Q   # 5�      �� 5�      .R�5�   "     #���  64   ��6[   �� *	cellphone+$ 6y   �� *caseId+5�      5�        5�      $  Source��61   $
! 1.5* 6A   #" �  6N   # 5�      �� 5�      .R�5�   "     #���  64   ��6[   �� *source+% �� 	Converter#% [  & �� ConverterParameter$& 
SourceCode��$ 6�   �� *caseId+5�      5�        5�      $  PendingData��61   $
! 1.5* 6F   #" �  6T   # 5�      �� 5�      .R�5�   "     #���  64   ��6[   �� *pendingDate+$ 6{   �� *caseId+5�      5�      5�      5�      � 5�   
   $��2��6   $��0,0,0,1q�6   .+�5�      �� $ 
Horizontal=�6   $��Center=�62   $��Bottom=�6O   $
��auto��6g   .+�5�      +  %Torpedo.Windows.Controls.RadDataPager  -   5        '  Name$' FileDataPager��5�   �     NumberPagerStyle#���  6'   (   PageSize$( 2��6|   $
��auto��6�   $
��auto��6  )   	PageIndex) 6R   �� *PageList.pageNumber+*   	ItemCount* 6�   �� *totalElements+6  �� 5�      $��10,0,0,0q�6   #���  6.   $
��Left=�6Y   �� 6v   $�
    Total:��6z   $��12(�6�   �� 6�   �6�   �� *totalElements+6�   5�      5�      5�      5�      5�      5�      