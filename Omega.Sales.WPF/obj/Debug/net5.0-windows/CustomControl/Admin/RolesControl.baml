   M S B A M L   `   `   `  ����J  FOmega.Sales.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Omega.Sales.WPF.CustomControlOmega.Sales.WPF.CustomControl  5      1clr-namespace:Omega.Sales.WPFOmega.Sales.WPF  5      0    *Omega.Sales.WPF.CustomControl.RolesControl   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:Omega.Sales.WPF.CustomControl     5      +lclr-namespace:Omega.Sales.WPF     5        � 	Resources  5         ExpandCollapseToggleStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius J� SnapsToDevicePixels �� 
StartPoint �� EndPoint	 � Color
 � Offset F�Name �� Triggers P� Property P� Value �� 
TargetName,   &Omega.Sales.WPF.LevelToIndentConverter  LevelIndentConverter  CellTemplate_Name d�Name �� 	ClickMode �� 	Converter �� RelativeSource �� AncestorType&    Omega.Sales.WPF.TreeListViewItem d� 	IsChecked �� Path �� Triggers �� Value �� Binding6  0System.Windows.Controls.GridViewColumnCollection  gvcc �� CellTemplate �� Width �� DisplayMemberBinding �� Padding ��Name �� Content  �� Columns! ��Name" ]� 
Conditions# �� Property$ �� Value"   Omega.Sales.WPF.TreeListView��%1  &	        &	 �    &	 �    7   7  &	 �    7  '  �    7  '  �    7  �� 5   
   " d�5      .�5      ��  � |�$ False��5      �� 5       � ��$ 19��5      �� 5       � ��$ 13��5      �� 5       � �� 5      �� 5      " d�6&   .R�5      �� $��19��6!   $��13��5      
������ ._�5      �� $��9��6%   $��9��5      $��1q�5      ���	#FF7898B5$ 1��5      $
 true��5       ��5!   "   �� 5"   &   $	 0,0&�6:   $	 1,1&�5#   (   ��5%   .   � $	 White��6;   $
 .2Q�5&   %   � 5'   .   $	 	#FFC0B7A6��6;   $
 1Q�5(   %   5*   '   ._�5,   "   F� $ 
ExpandPath��6'   $��1,1,1,1q�5-      
���   �s����    �� �    ��- р� ��- р� @KL ���- @KL ���- ��- �@KL ��- �@KL �� ���- �� ���-     р�     р� �� 	5/      51      52       53      P� 54       �@d�	IsChecked$
 TrueY�55      . �56   "   �� $ 
ExpandPath��57       � ��+ ��    �� �    ��- �@KL ��- �@KL �� 	58      59      5;      5=      5>        5@   
   6#   �� 5B   
   .R�5C      ]� .+�5D      d� $ Expander��6   8��  $ Press=�5P      ��5F      �� *Level+8   �� "   5L      �� $ 
IsExpanded� �� "  5P      �� 5Q      ��6   �� $ RoleName�5R       5S      �� 5T      $ False��5W       5T      �� $ HasItems� �� "  .a�5X      �� $ Expander��6    � y�$ Hidden=�5Z      5[      5]        5`   
   �� 5a      $ ��Идентификатор��6   8   5b      �� 5c      $��Наименование��6   $ 60��5d   @    6   �� $ Id�6@   �� 5e      $��Тест��6    5f      �� $ RoleName�5g      �� 5j   
   "  6   .�5k      ��  � �� 5l      �� 5m      "  6&   .R�5n      �� .+�5o      �� $��Bd��6%   #��z��5p      #��z��5q      #��z��5r      # z��5s      ._�5t   "   �� $ PART_Header��67   # z��5u   '   8    5v   '   5w      �� 5x      $! 	ItemsHost��6-   5y       5z      P� 5{       �@Q�
IsExpanded$ false��5|      . �5}   "   �� $ 	ItemsHost��6)    � y�$ 	Collapsed=�5      5�      ]� 5�      " 5�   "   �� 5�   &   # � ��$$ false��5�      �� 5�   &   # � ��$
$ Auto��5�      ./�5�   "   �� $ PART_Header��6)    � ��$ 75��5�      5�      ]� 5�      " 5�   "   �� 5�   &   # � ��$$ false��5�      �� 5�   &   # � ��$
$ Auto��5�      ./�5�   "   �� $ PART_Header��6)    � ��$ 19��5�      5�      P� 5�       �@Q�
IsSelected$
 true��5�      . �5�   "   �� $ Bd��6)   # � ��5�       � ���� 5�   "   # � ��5�       � ��5�      ]� 5�      " 5�   "   �� 5�   &   # �@Q�
IsSelected$
$ true��5�      �� 5�   &   # �@Q�IsSelectionActive$$ false��5�      ./�5�   "   �� $ Bd��6)   # � ��5�       � ���� 5�   "   # � ��5�       � ��5�      P� 5�       � {�$ false��5�      . �5�   "   �� # � ��5�       � ��5�      5�      5�      5�      �� 5�   
   "  6   .�5�      ��  � �� 5�      �� 5�      "  6&   .R�5�      �� #��z��6!   #��z��5�      ._�5�      ]� .+�5�   "   �� 8    $	��Top=�5�   -   �� 5�   "   5�      5�      5�      5�      5�      5�      .��5�        -   5        %  Name$% treeList��5�      ���	#FFE9E9E9���	#FF96DFFF& �� AlternationCount$& 2��5�      ��62   �� *
RoleList+��5�   
   �� 5�      ' �� ItemsSource' 6'   �� *ChildrenRoleList+5�      5�      