   M S B A M L   `   `   `  ���� >  :New, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:New.BaseNew.Base      New.Views.Case.CreateCase   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     \ XTorpedo.Windows.Controls.Charting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullY UTorpedo.Windows.Controls.Input, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullS OTorpedo.Windows.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null^ ZTorpedo.Windows.Controls.Navigation, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\	 XTorpedo.Windows.Controls.GridView, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullO
 KTorpedo.Windows.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullT PTorpedo.Windows.Documents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aTorpedo.Windows.Controls.DataVisualization, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullX TTorpedo.Windows.Controls.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullOtorpedo1http://schemas.torpedo.com/2008/xaml/presentation	     	 
    U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  !baseclr-namespace:New.Base     New.Base.ChildControlBase    Initialized$  CreateCase_OnInitialized�� � 	Resources    SelectorTemplate �� 
TargetType1  +Torpedo.Windows.Controls.RadAutoCompleteBox'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard g� Duration	 W� To �� TargetProperty	 �� 
TargetName
 ��Name  	HighBrush J� Opacity  AccentBrush J� IsHitTestVisible ��Name J� SnapsToDevicePixels<  6Torpedo.Windows.Controls.AutoCompleteBoxesItemsControl  Name   DisplayMemberPath �� DisplayMemberPath   BoxesItemTemplate   BoxesItemTemplate9  3Torpedo.Windows.Controls.AutoCompleteBoxesWrapPanel �� ElementName �Name �Name   MinDropDownWidth   MaxDropDownHeight ��Name   FilteredItems   DropDownItemTemplate  
FontFamily �� SelectionMode �� View �� AllowsColumnReorder �� Width  �� DisplayMemberBinding��%�  &	        �� "  .R��    CommonStates��.   
Normal��  	MouseOver��. �� .��W� $ 0D�$ 1X�$ Opacity�$	 MouseOverVisual��  Disabled��. �� .��W� $ 0D�$	 DisabledVisualElement��$ Opacity�$	 0.5X�W� $ 0D�$ 0X�$ Opacity�$	 Border��  FocusStates��.   	Unfocused��  Focused��. �� .��W� $ 0D�$ 1X�$ Opacity�$	 FocusVisual��.+��� $
 Border��#��z��#��z��#��z���� $
 MouseOverVisual��#���  #��z��#��z��$ 0Q��� $
 FocusVisual��#���  #��z��#��z��$ 0Q��� $
 DisabledVisualElement��#��z��#��z��#��z�� .  $ 0Q��� $ PART_ScrollViewer��#��z��#��z��$��Center=�$��0q�
������ $��1q���.  #��z��#��z��#��z��# z .��  $ 
PART_Boxes��# z # z ��.  #��z��#��z������ .R�  ���� *ActualWidth+$ WatermarkTextBox��� $ 
PART_Popup��.��� $ 	PopupRoot��#��z #��z .+��� $ PART_ListBox��#��z #��z #��z #���  $ Single=�# z  ��  .  .P��� $
��Name��$	 150��  �� *name+�� $��Price��$	 100��  �� *price+�� $��Category��$	 300��  �� *
category+.��� .+��� $
��Auto=�.��� $��0,1,0,1q����	#FFEEEEEE! � RowDefinitions! �� $��* �" � ColumnDefinitions" �� $��* �.+�]� ��. $��0��$��0��  DockPanel-Background#���  .+�� ! �� $	��200 ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+���   Option-Border#���  $��0��$��0��$	��Top=�._��� $��Account��$��12(�  Option-Group#���  .��� ! �� $��33 ��� $��33 ��� $��33 ��� $��33 ��� $��33 �" �� $��60 ��� $��* ��� $��27 ��� $��60 ��� $��* ��� $��27 ��� $��60 ��� $��* ��� $��27 ��� $��60 ��� $��* ��� $��27 �.+��� -   $��A1��$��*Company��  Text-Block-Page#���  $��0��$��0��  -   $��ComboBoxCompany��$��0��$��1��$��4��  Rad-Auto-Complete-Box-Page#���  $
 name��# � ToolTip$# 请输入公司名��$   SelectionMode$$ Single=�%   TextSearchMode$% Contains=�&   TextSearchPath$
& name��'   AutoCompleteMode$' SuggestAppend=�(   ItemsSource( �� *CompanyList+) �� Mode$) TwoWay=�*   
SearchText* �� *name+$) TwoWay=��� -   $��Right=�$$# 通过百度查询公司名...�� 
	 Search#��� 	 $
��Auto��$��0��$��5���� -   $��A5��$��Industry��#���  $��0��$��6��  -   $��ComboBoxIndustry��$��0��$��7��#���  $
 name��$# 请选择行业��$$ Single=�$% Contains=�$
& name��$' SuggestAppend=�( �� *IndustryList+$) TwoWay=�* �� *name+$) TwoWay=��� -   $��A7��$��Province��#���  $��0��$��9��  -   $��ComboBoxProvince��$��0��$��10��#���  $
 name��$$ Single=�$% Contains=�$
& name��$' SuggestAppend=�$# 请选择省份��( �� *ProvinceList+$) TwoWay=�* �� *name+$) TwoWay=��� -   $��A8��$
��City��#���  $��1��$��0��  -	   $��ComboBoxCity��$��1��$��1��#���  $
 name��$# 请选择公司��{�.  $$ Single=�$% Contains=�$
& name��$' SuggestAppend=�( �� *
CityList+$) TwoWay=�* �� *name+$) TwoWay=��� $��Priority��#���  $��1��$��3��*  $Torpedo.Windows.Controls.RadComboBox  -
   +  Name$+ 	StarLevel�� 
 Rad-ComboBox-Page#��� 
 $# 请选择公司星级��, �� SelectedValuePath$
, Code��$
 Name��$��1��$��4������ *Dictionary[Priority]+$) OneTime=�- �� SelectedValue- �� *SelectedCase.priority+�� -   $��ParentTitle��$��Parents��#���  $��1��$��6��  -   $��ParentsCompany��$��1��$��7��$��4��#���  $
 name��$# 请选择公司��$$ Single=�$% Contains=�$
& name��$' SuggestAppend=�( �� *ParentCompanyList+$) TwoWay=�* �� *name+$) TwoWay=��� $��Address��#���  $��2��$��0���� -   $��Address��  TextBox-Normal-Page#���  $��2��$��1��$��10������ *SelectedCase.address+$) TwoWay=��� $
��Note��#���  $��3��$��0��$��2���� -   $��AccountNote��#���  $��3��$��1��$��10��$��2��$
��Auto��. �� TextWrapping$
. Wrap=�/ �� AcceptsReturn/ . ���� *SelectedCase.companyNote+$) TwoWay=��� -   $��UpdateCompany��$��Right=�$# 更新contact...��  List-Plus-Update#���  $y�Visible=�$��4��$��11���� -   $��ContactList��#���  $��1��$��0��$	��Top=�$	��200��$y�	Collapsed=�._��� $��Contact List��$��12(�#���  .��*	 	 $Torpedo.Windows.Controls.RadGridView	  -   0 	 Name$0 Contacts��  GridViewNormal#���    GridViewHeaderRow;
 	 5Torpedo.Windows.Controls.GridView.GridViewDataControl1 
  HeaderRowStyle#1 �    GridViewRowNormal2 
  RowStyle#2 �    GridViewAlternateRowNormal3 
  AlternateRowStyle#3 �  4 
  
IsReadOnly4 . 5 
  SelectionMode$5 Single=�* 
 $Torpedo.Windows.Controls.DataControl6   ItemsSource6 �� *
UserList+$) TwoWay=�7 
  Columns7 1 	 +Torpedo.Windows.Controls.GridViewDataColumn  6 	 0Torpedo.Windows.Controls.GridViewBoundColumnBase8   Header$
8 Name��- 	 'Torpedo.Windows.Controls.GridViewColumn9   Width? 	 9Torpedo.Windows.Controls.GridView.GridViewLengthConverter$9 1*   GridViewHeaderCell:   HeaderCellStyle#: �  ;   DataMemberBinding; �� *name+<   CellTemplate< �� .R�(  "Torpedo.Windows.Controls.RadButton    ButtonInCell#���  ���� *name+
= � Tag= �� *id+  $8 
Department��$9 1* #: �  ; �� *
department+< �� .R�  #���  ���� *
department+= �� *id+  $8 Title��$9 1* #: �  ; �� *title+< �� .R�  #���  ���� *title+= �� *id+  $8 
Work Phone��$9 1* #: �  ; �� *	workPhone+< �� .R�  #���  ���� *	workPhone+= �� *id+  $8 
Cell Phone��$9 1* #: �  ; �� *	cellPhone+< �� .R�  #���  ���� *	cellPhone+= �� *id+�� -   $��Contact��#���  $��2��$��0��$	��Top=�$	��200��$y�Visible=�._��� $��Contact��$��12(�#���  .��� ! �� $��33 ��� $��33 ��� $��33 ��� $��33 ��� $��33 �" �� $��60 ��� $��* ��� $��27 ��� $��60 ��� $��* ��� $��27 ��� $��60 ��� $��* ��� $��27 ��� $��60 ��� $��* ��� $��27 �.+��� -   $��A3��$��*Name��#���  $��0��$��0���� -   $��LastName��#���  $��0��$��1������ *SelectedCase.customerName+$) TwoWay=��� -     List-Clear-Icon#���  $��0��$��2���� $��Gender��#���  $��0��$��3��  -   $+ ComboBoxGender��$
 Name��$
, Code��$��0��$��4��#��� 
 ���� *Dictionary[Gender]+$) OneWay=�> �� SelectedItem> �� *SelectedCategory+$) TwoWay=�- �� *SelectedCase.gender+$) TwoWay=��� $��
Department��#���  $��0��$��6���� -   $��Departments��#���  $��0��$��7������ *SelectedCase.department+$) TwoWay=��� $��Title��#���  $��0��$��9���� -   $��Title��#���  $��0��$��10������ *SelectedCase.title+$) TwoWay=��� -   $��A6��$��*Email��#���  $��1��$��0���� -   $��Mails��#���  $��1��$��1������ *SelectedCase.email+$) TwoWay=��� -   $��	WorkPhone��$��Phone��#���  $��1��$��3���� -   $��	Workphone��#���  $��1��$��4������ *SelectedCase.workphone+$) TwoWay=��� -   $��	CellPhone��$��Mobile��#���  $��1��$��6���� -   $��Mobile��#���  $��1��$��7������ *SelectedCase.cellphone+$) TwoWay=��� $
��Note��#���  $��2��$��0��$��3���� -   $��ContactNote��#���  $��2��$��3��$��1��$��10��$
��Auto��$
. Wrap=�/ . ���� *SelectedCase.customerNote+$) TwoWay=��� -    $��UpdateContact��$��Right=�$# 更新contact...��#���  $y�Visible=�$��4��$��11���� -!   $
��Case��#���  $��3��$��0��$	��Top=�$	��133��$y�Visible=�._��� $
��Case��$��12(�#���  .��� ! �� $��33 ��� $��33 ��� $��33 �" �� $��60 ��� $��* ��� $��27 ��� $��60 ��� $��* ��� $��27 ��� $��60 ��� $��* ��� $��27 ��� $��60 ��� $��* ��� $��27 �.+��� $
��Type��#���  $��0��$��0��  -"   $+ Types��$��0��$��1��#��� 
 $
 Name��$
, Code��- �� *SelectedCase.type+$) TwoWay=����� *Dictionary[CaseType]+$) OneWay=��� $��Source��#���  $��0��$��3��  -#   $+ 
SourceCode��$
 Name��$
, Code��$��0��$��4��$# 	请选择��#��� 
 ���� *Dictionary[SourceCode]+$) OneWay=�- �� *SelectedCase.source+$) TwoWay=��� -$   $��A2��$��*Owner��#���  $��0��$��6��  -%   $��ComboInsalesSales��$��0��$��7��#���  $# 	请选择��$
 name��$$ Single=�$% Contains=�$
& name��$' SuggestAppend=�( �� *
UserList+$) TwoWay=�* �� *name+$) OneWay=��� $��
*Campaigns��#���  $��0��$��9��  -&   $��	Campaigns��$��0��$��10��#���  $# 	请选择��$
 name��$$ Single=�$% Contains=�$
& name��$' SuggestAppend=�( �� *SaleProjectList+$) TwoWay=�* �� *name+$) OneWay=��� -'   $��A4��$��*Note��#���  $��1��$��0��$��2���� -(   ? ��Name$? CaseNote��#���  $��1��$��1��$��10��$��2��$
��Auto��$
. Wrap=�/ . ���� *SelectedCase.caseNote+$) TwoWay=��� -)   $
��Lead��#���  $��4��$��0��$	��Top=�$	��163��$y�Visible=�._��� $��Leads��$��12(�#���  .��� ! �� $��33 ��� $��33 ��� $��33 ��� $��33 �" �� $��60 ��� $��* ��� $��27 ��� $��4* ��� $��27 �.+��� $��Category��#���  $��0��$��0��  -*   $+ Category��#��� 
 {�.  $
, Code��$
 Name��$��0��$��1������ *Dictionary[Category]+$) OneTime=��� $��Rating��#���  $��1��$��0��  -+   $+ 
Importance��#��� 
 $
, Code��$
 Name��$��1��$��1������ *Dictionary[Priority]+$) OneTime=��� $��Status��#���  $��2��$��0��  -,   $+ 
LeadStatus��$��2��$��1��#��� 
 $, id��$
 name��- �� *SelectCase.status+���� *CaseStatusList+$) TwoWay=��� $��Sales��#���  $��3��$��0��  --   $��
ComboSales��$��3��$��1��#���  $
 name��$$ Single=�$% Contains=�$
& name��$' SuggestAppend=�( �� *	SalesList+$) TwoWay=�* �� *name+$) OneWay=��� $��Product��$
��auto��$��11(�$��0��$��3��$��4��.��	  -.   $0 Products��$��27��#���  #1 �  #2 �  #3 �  $5 Multiple=�6 �� *	orderList+@   SelectedItem@ �� *SelectedOrder+-  'Torpedo.Windows.Controls.RadContextMenuA   ContextMenuA   -/   B  Name$B ContextMenu��@�*  $Torpedo.Windows.Controls.RadMenuItem  $��Delete��  $	��Add��7   C   
IsReadOnlyC . #: �  $8  ��$9 45 D   TextAlignment$
D Left=�; �� *	productId+< �� .R�  #���  $
��View��= �� *	productId+  #: �  $
8 Name��$9 3* C .  $D Center=�; �� *name+E   CellEditTemplateE �� .R��� F �� Orientation$F 
Horizontal=�$��Stretch=�.+�  $	��600��$��25��#���   $
 name��$$ Single=�$% Contains=�$
& name��( �� *DataContext.ProductList+G �� RelativeSourceG �� H �� AncestorType$H base:ChildControlBaseL�* �� *name+$) OneWay=�  #: �  $8 Price��$9 3* C .  $D Center=�; �� *
salesPrice+E �� .R��� $F 
Horizontal=�$��Center=�.+��� $��50��$��25��I �� TextAlignment$I Center=�$��Center=����� *
salesPrice+  #: �  $	8 Num��$9 3* C .  $D Center=�; �� *orderAmount+E �� .R��� $F 
Horizontal=�$��Center=�.+��� $��50��$��25��$I Center=�$��Center=����� *orderAmount+�� #���  $��5��$��0��$	��Top=�$��60��$y�Visible=�._�� ! �� $��45 ��� $��* �" �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� -0   $��CS��  List-Plus-Save#���  $# 保存case...��$y�Visible=�$��0��$��3��$��Center=�$��Center=�$
��aUTO��$
��AUTO��$��2��