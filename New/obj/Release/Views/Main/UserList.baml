   M S B A M L   `   `   `  ���� >  :New, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:New.BaseNew.Base      New.Views.Main.UserList   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     \ XTorpedo.Windows.Controls.Charting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullY UTorpedo.Windows.Controls.Input, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullS OTorpedo.Windows.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null^ ZTorpedo.Windows.Controls.Navigation, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\	 XTorpedo.Windows.Controls.GridView, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullO
 KTorpedo.Windows.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullT PTorpedo.Windows.Documents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aTorpedo.Windows.Controls.DataVisualization, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullX TTorpedo.Windows.Controls.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullPcontrols1http://schemas.torpedo.com/2008/xaml/presentation	     	 
    1baseclr-namespace:New.Base	     	 
       New.Base.ChildControlBase    Initialized$  UserList_OnInitialized��.���  � RowDefinitions �� $��30 ��� $��* �.+�� $��0��$��0,0,0,1q�.+�� $	��Top=�$
��Auto�����#9fa8da � ColumnDefinitions �� $��* ��� $��30 �.+�� $��0��$��0��.+�1  +Torpedo.Windows.Controls.RadAutoCompleteBox  -   $��Search�� �� IsInputMethodEnabled .  $
��auto��   Rad-Auto-Complete-Box#���      DisplayMemberPath$
 name��   SelectionMode$ Single=�   TextSearchMode$ Contains=�   TextSearchPath$
 name��   AutoCompleteMode$ SuggestAppend=�	 � ToolTip$C	 =Quick search like : company name ,customer name, phone, email��
   ItemsSource
 �� *CommonSearchDTOList+ �� Mode$ TwoWay=�   SelectedItems �� *CommonSearchDTO+   
SearchText �� *name+$ OneWay=��� $��0��$��1�� �� Orientation$ 
Horizontal=�$��Center=�$
��auto��.+��  �� $��1* �.+��� $��Center=�$��0��$��0��  Refresh#���  $	 刷新callList...��� $��1��$��0,0,0,1q�.+�* 	 $Torpedo.Windows.Controls.RadGridView  -     Name$ GridDrug��  GridViewNormal#���    GridViewHeaderRow; 	 5Torpedo.Windows.Controls.GridView.GridViewDataControl   HeaderRowStyle# �    GridViewRowNormal   RowStyle# �    GridViewAlternateRowNormal   AlternateRowStyle# �     
IsReadOnly .    SelectionMode$ Single=�* 
 $Torpedo.Windows.Controls.DataControl   ItemsSource �� *
UserList+$ TwoWay=�   Columns 1 	 +Torpedo.Windows.Controls.GridViewDataColumn  6 	 0Torpedo.Windows.Controls.GridViewBoundColumnBase   Header$ UserName��- 	 'Torpedo.Windows.Controls.GridViewColumn   Width?	 	 9Torpedo.Windows.Controls.GridView.GridViewLengthConverter$
 1.5*	   GridViewHeaderCell   HeaderCellStyle# �     CellTemplate �� .R�(
  "Torpedo.Windows.Controls.RadButton
  -     ButtonInCell#���  ���� *name+
 � Tag �� *id+  $ 
Department��$
 1.5*	 # �   �� .R�
  #���  ���� *
department+ �� *id+  $ UserType��$
 1.5*	 # �   �� .R�
  #���  ���� *
userType+ �� *id+