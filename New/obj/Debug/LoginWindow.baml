   M S B A M L   `   `   `  ����>  :New, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NewNew  5   	   A =WPF.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5'clr-namespace:ZdfFlatUI;assembly=WPF.UI	ZdfFlatUI 5   	       New.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:New     5   	   =	zdfFlatUi'clr-namespace:ZdfFlatUI;assembly=WPF.UI     5   	   c _MahApps.Metro.IconPacks.Core, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   @    � Title$ Login��5   	   $	��360��6   $	��360��6$    � AllowsTransparency . 
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6   $��	DokChampa)�5   	   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ��5      �� 5      .��5      �  � Color$ #7be9f6��6'    � Offset$	 0.0Q�67   6F   � 5      $ #f083da��6'   $ 1Q�67   6D   5      5      �� 5!      $��0��6   $��Center=�6&   .+�5"      �� $��Images/crm.png��6   $	��100��60   �� 5#      $��Lead To Revenue��6   $��Light"�5$      $��24(�5%      
������ 
�������$��0q�5(      $��Center=�5)      5*      �� 5,      $��1��6   .+�5-      �� 	 �� Orientation$	 
Horizontal=�6   .+�5.      �� -   5        $��UserName��5/      $��Light"�5.      $��52486846@qq.com��50      $��14(�51      $
��Left=�52      
�������
������ $��0q�55      $	��235��56      $
��Left=�57      
 J� Opacity$	
 0.5Q�58      $��30��59      $��50,0,0,0q�5:      .  (MahApps.Metro.IconPacks.PackIconMaterial  5;         Kind$ Account=�61   $��Center=�5<   1   $��Center=�5=   1   
�������5>   1   5?      �� 5@      $	��260��6   $��2��5A      
�������$	
 0.4Q�5C      �� 5E      $	 
Horizontal=�6   $��0,20,0,0q�66   .+�5F      G� -   5        $��Password��5G      $��Light"�5F   "    G� Password$ 1��5H      $��14(�5I      $
��Left=�5J      
�������
������ $��0q�5M      $	��235��5N      $
��Left=�5O      $	
 0.5Q�5P      $��30��5Q      $��50,0,0,0q�5R        5S      $ TextboxPassword=�61   $��Center=�5T   1   $��Center=�5U   1   
�������5V   1   5W      �� 5X      $	��260��6   $��2��5Y      
�������$	
 0.4Q�5[      �� 5]      $	 
Horizontal=�6   $��0,30,0,0q�66   .+�5^      �� -   5           Login-Button#���   5^      $��Login��5_      
������ $��90��5a      $��28��6(   $��	65,0,50,0q�5b      �� 5e      -   5        #���   5e      $��Cancel��5f      
������ $��90��5h      $��28��6(   5i      5k      5n      5o      5�      