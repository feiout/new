   M S B A M L   `   `   `  ���� >  :New, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:New.BaseNew.Base      New.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'baseclr-namespace:New.Base     U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -      New.Base.ChildControlBase    MyCustom$  HandleChineEvent��$��	DokChampa)� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � WindowState$ 	Maximized=� � WindowStyle$
 None=� � 	Resources    MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime	 O� Value  	MenuClose��%�   &	        &	 q     �� .��U� $ (FrameworkElement.Width)�$ GridMenu��.\�  $ 0��$	 60Q�  $ 0:0:0.2��$		 140Q��� .��U� $ (FrameworkElement.Width)�$ GridMenu��.\�  $ 0��$		 140Q�  $ 0:0:0.2��$	 60Q�.��� 
�������.+�� 
 � ColumnDefinitions
 �� $
��Auto ��� $��* �.+�� -    �Name$ GridMenu��$��0��$
��Left=�$��60��.+��� .+�� $��80�����#bdbdbd � RowDefinitions �� $��8 ��� $��72 �.+�� ���	#FF0069C0$��8��$��0���� -    ��Name$ 	SmallLogo��$��Center=�$��Bottom=�$��29��$��45��$��0 0 0 20q�$��Images/crm.png��$��1���� -    ��Name$
 View�����	#FF1368BD$��Disabled=�$��14(�.@��� $��45�� � ToolTip$ Create��.����  �� Orientation$ 
Horizontal=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Create=�$��25��$��25��$��Center=�$��	10 0 10 0q��� $��45��$
 Task��.���� $ 
Horizontal=�.+�  $ Database=�$��25��$��25��$��Center=�$��	10 0 10 0q��� $��45��$
 Case��.���� $ 
Horizontal=�.+�  $ Valve=�$��25��$��25��$��Center=�$��	10 0 10 0q��� $��45��$ Customer��.���� $ 
Horizontal=�.+�  $ Users=�$��25��$��25��$��Center=�$��	10 0 10 0q��� $��45��$ Company��.���� $ 
Horizontal=�.+�  $ Company=�$��25��$��25��$��Center=�$��	10 0 10 0q�� $��1�� �� $��60 ��� $��* ��� $��30 �.+��� ���	#ffeeeeee.+�� ���	#FF0069C0$��8��� .+��� $��Center=�$ 
Horizontal=�.+��� -    ��Name$ Title��$��Lead To Revenue��$��Center=�$��Center=�$��24(�$
��Bold"�
�������$��0 5 0 0q��� $��Right=�$ 
Horizontal=�.+��� -   $ CtrlUserInfo��  Toolbar-User#���  $ 登录用户��$��登录用户�����#464c5b�� $��30��$��30��$��0q�
���������Z� ��Z� .��  $ BellOutline=��� $��30��$��30��$��0q�
�������$��0 0 10 0q���Z� ��Z� .��  $ Settings=��� -   $��30��$��30��$��0q�
���������Z� ��Z� .��  $ WindowMinimize=��� -   $��30��$��30��$��0q�
���������Z� ��Z� .��  $ Close=�� $��1�����	#FFffffff.+�]� -	   $��
ShowDetail��.+��� -
    ��Name$ Display���� $��2�����	#ffeeeeee.+�� .+��� $��Center=�$ 
Horizontal=�.+��� $��30��$��30��$��0q�
���������Z� ��Z� .��  $ Wechat=��� $��30��$��30��$��0q�
���������Z� ��Z� .��  $ Facebook=��� $��30��$��30��$��0q�
���������Z� ��Z� .��  $ 	SinaWeibo=�