   M S B A M L   `   `   `  ���� >  :New, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:New.BaseNew.Base      New.Views.Main.TaskList   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     \ XTorpedo.Windows.Controls.Charting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullY UTorpedo.Windows.Controls.Input, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullS OTorpedo.Windows.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null^ ZTorpedo.Windows.Controls.Navigation, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\	 XTorpedo.Windows.Controls.GridView, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullO
 KTorpedo.Windows.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullT PTorpedo.Windows.Documents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aTorpedo.Windows.Controls.DataVisualization, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullX TTorpedo.Windows.Controls.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullOtorpedo1http://schemas.torpedo.com/2008/xaml/presentation	     	 
    U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  !baseclr-namespace:New.Base     New.Base.ChildControlBase    Initialized$.  (TaskList_OnInitializedList_OnInitialized��.��� .+�?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -     Name$ TransitioningContentSlide��C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromRight+   Duration$ 0:0:0.2X�.���  � RowDefinitions �� $��30 ��� $��* �.+�� $��0��$��0,0,0,1q�.+�� $	��Top=�$
��Auto�����#9fa8da � ColumnDefinitions �� $	��425 ��� $��95 ��� $��* �.+�� $��0��$��0��$��Center=� �� $��70 ��� $	��150 ��� $��55 ��� $	��150 �.+��� $��	Campaign ��$��0��$��0��   Text-Block-Title#���   1  +Torpedo.Windows.Controls.RadAutoCompleteBox  -   $��Campaign��$��0��$��1�� �� IsInputMethodEnabled .  $
��auto��  Rad-Auto-Complete-Box#���     DisplayMemberPath$
 name��   SelectionMode$ Single=�	   TextSearchMode$	 Contains=�
   TextSearchPath$

 name��   AutoCompleteMode$ SuggestAppend=� � ToolTip$C =Quick search like : company name ,customer name, phone, email��   ItemsSource �� *CommonSearchDTOList+ �� Mode$ TwoWay=�   SelectedItems �� *CommonSearchDTO+   
SearchText �� *name+$ OneWay=��� $��Status ��$��0��$��2��#���   *  $Torpedo.Windows.Controls.RadComboBox  -     Name$ CallListStatusBox��$��0��$��3��  Rad-ComboBox#���   �� DisplayMemberPath$
 Name�� �� SelectedValuePath$
 Code������ *Dictionary[TaskType]+$ OneWay=��� $��0��$��1�� �� Orientation$ 
Horizontal=�$��Center=�$
��auto��.+�� $��90�� �� $��30 � �� $��1* ��� $��1* ��� $��1* �.+��� $��Center=� 
 Search#���  $ 查询callList...��$��0��$��0���� $��Center=�  Refresh#���  $ 刷新callList...��$��0��$��1���� -   $��Center=�  Plus#���  $ 创建case...��$��0��$��2��� $��0��$��2��.+�  -   $��Search�� .  $
��auto��#���  $
 name��$ Single=�$	 Contains=�$

 name��$ SuggestAppend=�$C =Quick search like : company name ,customer name, phone, email�� �� *CommonSearchDTOList+$ TwoWay=� �� *CommonSearchDTO+ �� *name+$ OneWay=�� $��1��$��0,0,0,1q�.+�* 	 $Torpedo.Windows.Controls.RadGridView  -     Name$ GridDrug��  GridViewNormal#���    GridViewHeaderRow; 	 5Torpedo.Windows.Controls.GridView.GridViewDataControl   HeaderRowStyle# �    GridViewRowNormal   RowStyle# �   	 GridViewAlternateRowNormal   AlternateRowStyle# � 	    
IsReadOnly .    SelectionMode$ Single=�*	 
 $Torpedo.Windows.Controls.DataControl 	  ItemsSource �� *
UserList+$ TwoWay=�   Columns 1
 	 +Torpedo.Windows.Controls.GridViewDataColumn
  6 	 0Torpedo.Windows.Controls.GridViewBoundColumnBase   Header$ UserName��- 	 'Torpedo.Windows.Controls.GridViewColumn   Width? 	 9Torpedo.Windows.Controls.GridView.GridViewLengthConverter$
 1.5*  
 GridViewHeaderCell   HeaderCellStyle# � 
     CellTemplate  �� .R�(  "Torpedo.Windows.Controls.RadButton  -     ButtonInCell#���  ���� *name+
! � Tag! �� *id+
  $ 
Department��$
 1.5* # � 
   �� .R�  #���  ���� *
department+! �� *id+
  $ UserType��$
 1.5* # � 
   �� .R�  #���  ���� *
userType+! �� *id+