   M S B A M L   `   `   `  ����D  @AdatPanel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:AdatPanel	AdatPanel  5   	       AdatPanel.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:AdatPanel     5   	     � Title$  Data Base Manager��5   	   $	��222��6#   $	��676��60   ���#393E46.��5	      � $��0,0,0,3q�6    � ColumnDefinitions 5
   
   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dg_adatok��5      ���#393E46   RowBackground �#525252���#00FFAB$��2q�6�      SelectionMode$ Single=�6�      AlternatingRowBackground �#363333$
��Bold"�6     RowHeaderWidth$ 0Q�6"  $��2q�65  $��10,10,10,37q�6A     GridLinesVisibility$ Vertical=�6V     
IsReadOnly$
 True��6u  	 � 	Resources	 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader
 �� BasedOn �� 
TargetType �� Property �� Value:  4System.Windows.Controls.Primitives.DataGridRowHeader��%  '        7 '  �     7 �� 5      8
   "  6Q   .�5      ��  � �� �#27212163   �� 5       � �� �#14C38E63   �� 5       � ��$ 5q�60   5      �� 5      8
   "  6N   .�5      ��  � �� �#0EA29363   5      5      ��5      �� 5       �� Color$ 	#FF0EA293��6"    �� Opacity$ 0Q�64      VerticalGridLinesBrush 5      �� 5      $ White��6"   $ 1Q�60   5       �� 5!   
   -   5        $��Update��5!      $
��Left=�6"   $��	10,0,0,10q�6=   $��Bottom=�6P   $��73��6k   $��22��6v   ���#272121���#00FFAB$��2q�6�   $
��Bold"�6�   	 5"      ��%c   '��       �� 5#      " ��6   .�5$      ��  �@��CornerRadius$ 3��65   6A   5%      5&      ��5'      �� 5(      $ 	#FF0EA293��6"   $ 0Q�64   5*      �� 5+   
   -   5         ��Name$ 
INSERT_btn��5+      $��Insert��6%   $
��Left=�66   $��	88,0,0,10q�6Q   $��Bottom=�6d   $��73��6   $��22��6�   ���#272121���#00FFAB$��2q�6�   $
��Bold"�6�   	 5,      ��%c   '��       �� 5-      " ��6   .�5.      ��  �@��CornerRadius$ 3��65   6A   5/      50      ��51      �� 52      $ 	#FF0EA293��6"   $ 0Q�64   54      �� 55   
   -   5        $��Delete��55      $
��Left=�6"   $��
166,0,0,10q�6=   $��Bottom=�6Q   $��73��6l   $��22��6w   ���#272121���#00FFAB$��2q�6�   $
��Bold"�6�   	 56      ��%c   '��       �� 57      " ��6   .�58      ��  �@��CornerRadius$ 3��65   6A   59      5:      ��5;      �� 5<      $ 	#FF0EA293��6"   $ 0Q�64   5>      �� 5@   
   -   5        $��Refresh��5@      $��	0,0,10,10q�6#   $��73��66   $��22��6A   ���#272121���#00FFAB$��2q�6w   $
��Bold"�6�   $��Right=�6�   $��Bottom=�6�   	 5A      ��%c   '��       �� 5B      " ��6   .�5C      ��  �@��CornerRadius$ 3��65   6A   5D      5E      ��5F      �� 5G      $ 	#FF0EA293��6"   $ 0Q�64   5I      5K      5L      