   M S B A M L   `   `   `  ���� >  :New, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:New.BaseNew.Base      New.Views.Main.CaseList   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     \ XTorpedo.Windows.Controls.Charting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullY UTorpedo.Windows.Controls.Input, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullS OTorpedo.Windows.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null^ ZTorpedo.Windows.Controls.Navigation, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\	 XTorpedo.Windows.Controls.GridView, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullO
 KTorpedo.Windows.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullT PTorpedo.Windows.Documents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aTorpedo.Windows.Controls.DataVisualization, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullX TTorpedo.Windows.Controls.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullOtorpedo1http://schemas.torpedo.com/2008/xaml/presentation	     	 
    U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  !baseclr-namespace:New.Base     New.Base.ChildControlBase    Initialized$  CaseList_OnInitialized�� � 	Resources "   New.Base.DictionaryConverter   DictionaryConverter��%   &	          .��� .+�?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -     Name$ TransitioningContentSlide��C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromRight+   Duration$ 0:0:0.2X�.���  � RowDefinitions �� $��30 ��� $��* ��� $��38 �.+�� $��0��$��0,0,0,1q�.+�� $	��Top=�$
��Auto�����#9fa8da � ColumnDefinitions �� $��70 ��� $	��150 ��� $��55 ��� $	��150 ��� $��18 ��� $��80 ��� $��5 ��� $	��110 ��� $��18 ��� $	��110 ��� $��45 ��� $��90 ��� $��60 ��� $��* �.+��� $��	 Campaign��$��0��$��0�� �� TextAlignment$ Right=�$��Center=�$��12(�$
��Bold"�$��0,8,0,0q�1  +Torpedo.Windows.Controls.RadAutoCompleteBox  -   $��Campaign��$��0��$��1�� �� IsInputMethodEnabled .  $
��auto��  Rad-Auto-Complete-Box#���  	   DisplayMemberPath$
	 name��
   SelectionMode$
 Single=�   TextSearchMode$ Contains=�   TextSearchPath$
 name��   AutoCompleteMode$ SuggestAppend=�   ItemsSource �� *SaleProjectList+ �� Mode$ TwoWay=�   
SearchText �� *name+$ OneWay=��� $�� Status��$��0��$��2��$ Right=�$��Center=�$��12(�$
��Bold"�$��0,8,0,0q�*  $Torpedo.Windows.Controls.RadComboBox  -     Name$ 
CaseStatus��$��0��$��3��  Rad-ComboBox#���   �� DisplayMemberPath$
 Name�� �� SelectedValuePath$
 Code������ *Dictionary[CaseStatus]+$ OneWay=�  -   $ DateType�����#9fa8da#���  $
��Bold"�$
 Name��$
 Code��$��0��$��5������ *Dictionary[DateType]+$ OneWay=�,  &Torpedo.Windows.Controls.RadDatePicker  -   $��Cstart��  Rad-DatePicker#���  0	  *Torpedo.Windows.Controls.RadDateTimePicker 	  DateTimeWatermarkContent$ start��$��0��$��7��$��0,1,0,1q��� $��~��  Text-Block-Title#���  $��0��$��8��$ Center=�  -   $
��Cend��#���  $
��Left=�$	 end��$��0��$��9��$��0,1,0,1q��� $�� Type��$��0��$��10��$ Right=�$��Center=�$��12(�$
��Bold"�$��0,8,0,0q�  -   $ CaseType��$��0��$��11��#���  $
 Name��$
 Code������ *Dictionary[CaseType]+$ OneWay=��� $��0��$��12�� �� Orientation$ 
Horizontal=�$��Center=�$
��auto��.+��  �� $��1* ��� $��1* �.+��� $��Center=�$��0��$��0�� 
 Search#���   � ToolTip$ 查询callList...���� -   $��Center=�$��0��$��1��  Refresh#���  $ 刷新callList...��� $��0��$��13��.+�  -	   $��Search�� .  $
��auto��#���  $
	 name��$
 Single=�$ Contains=�$
 name��$ SuggestAppend=�$C =Quick search like : company name ,customer name, phone, email�� �� *CommonSearchDTOList+$ TwoWay=�   SelectedItems �� *CommonSearchDTO+ �� *name+$ OneWay=�� $��1��$��0,0,0,1q�.+�*
 	 $Torpedo.Windows.Controls.RadGridView
  -
    
 Name$ Cases��  GridViewNormal#���    GridViewHeaderRow; 	 5Torpedo.Windows.Controls.GridView.GridViewDataControl   HeaderRowStyle# �   	 GridViewRowNormal   RowStyle# � 	  
 GridViewAlternateRowNormal   AlternateRowStyle# � 
    
IsReadOnly .    SelectionMode$ Single=�* 
 $Torpedo.Windows.Controls.DataControl   ItemsSource �� *cases+$ TwoWay=�   Columns 1 	 +Torpedo.Windows.Controls.GridViewDataColumn  6 	 0Torpedo.Windows.Controls.GridViewBoundColumnBase    Header$  CaseID��- 	 'Torpedo.Windows.Controls.GridViewColumn!   Width? 	 9Torpedo.Windows.Controls.GridView.GridViewLengthConverter$
! 1.5*   GridViewHeaderCell"   HeaderCellStyle#" �  #   CellTemplate# �� .R�(  "Torpedo.Windows.Controls.RadButton    ButtonInCell#���  ���� *caseId+
$ � Tag$ �� *caseId+  $  Company��$
! 1.5* #" �  # �� .R�  #���  ���� *companyName+$ �� *	companyId+  $
  Name��$
! 1.5* #" �  # �� .R�  #���  ���� *customerName+$ �� *
customerId+  $  	Workphone��$
! 1.5* #" �  # �� .R�  #���  ���� *	workphone+$ �� *caseId+  $  	Cellphone��$
! 1.5* #" �  # �� .R�  #���  ���� *	cellphone+$ �� *caseId+  $  Source��$
! 1.5* #" �  # �� .R�  #���  ���� *source+% �� 	Converter#% [  & �� ConverterParameter$& 
SourceCode��$ �� *caseId+  $  PendingData��$
! 1.5* #" �  # �� .R�  #���  ���� *pendingDate+$ �� *caseId+� $��2��$��0,0,0,1q�.+��� $ 
Horizontal=�$��Center=�$��Bottom=�$
��auto��.+�+  %Torpedo.Windows.Controls.RadDataPager  -   '  Name$' FileDataPager��  NumberPagerStyle#���  (   PageSize$( 2��$
��auto��$
��auto��)   	PageIndex) �� *PageList.pageNumber+*   	ItemCount* �� *totalElements+�� $��10,0,0,0q�#���  $
��Left=��� $�
    Total:��$��12(��� ��� *totalElements+