   M S B A M L   `   `   `  ����O  KZooManagementProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:ZooManagementProject.ViewModelZooManagementProject.ViewModel  5      I)clr-namespace:ZooManagementProject.StylesZooManagementProject.Styles  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0895    /ZooManagementProject.ViewModel.ViewModelLocator   Locator  BaseFontSize  BaseItemContainerStyle  �� 
TargetType �� Property �� Value �� 
TargetType J� SnapsToDevicePixels �� Padding �� Triggers P� Property P� Value	 �� 
TargetName  GroupsLeftStyle
 �� TextAlignment  AnimalStyleLb �� Orientation  
FoodsStyle  HungryAnimalStyle  Basebtn 
 baseTb�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      :	viewModel,clr-namespace:ZooManagementProject.ViewModel  5      3local)clr-namespace:ZooManagementProject.Styles  5      1system&clr-namespace:System;assembly=mscorlib  5      %�  &	        &	      &	 -     &	 �    7  &	 �    7  7  7  7  7  7  7  7  7  7  &	 =	    7  &	 F    7  &	     &	 @       5      6!   X�5      10Q�6-   �� 5      "  ��6,   .�5   
   ��  � �� 5      �� 5      " ��6"   .R�5      �� $��Border��6   
���   �$��0,0,0,0q�6@    . $ 5q�5   H   ._�5      �� 5       5      P� 5       �@J�IsMouseOver . . �5      �� $	 Border��6%    � ��
 �����6O   �� 5      $	 Border��6%    � ��
 �����6W   5      5      5       5!      �� 5$      "  ��5%      .�5&   
   ��  �@��IsTextSearchEnabled .  60   �� 5'   
    � ��8   6/   �� 5(   
    � ��$	 120��6%   �� 5)   
    � �� 5*      �� 5+      .R�5,      � $	��100��6   .+�5-      �� $��20(�5.      $��Center=�5/      $
��Wrap=�50      $
 Center=�51      $��Center=�52      ��53      �� *Name+54      55      57      �� 58   
    � �� 59      �� 5:      .R�5;      �� 5<      5>      �� 5?   
    � ��$	 155��6'   5@      �� 5C      "  ��5D      .�5E   
   ��  �@��IsTextSearchEnabled .  60   �� 5F   
    � ��8   6/   �� 5G   
    � ��$	 120��5H      �� 5I   
    � �� 5J      �� 5K      .R�5L      � $	��100��6   .+�5N      �� $ 
Horizontal=�6%   .+�5P      �� $ 
Horizontal=�6)   .+�5Q   "   �� 8�� $��Center=�5R   J   $��Назва: ��5S   !   �� 5U   "   8�� $��Center=�5W      ��5X      �� *Name+5Y      �� 5\      $��5 0 0 0q�6)   $ 
Horizontal=�6:   .+�5]   "   �� 8�� $��Center=�5^   J   $%��Дата народження: ��5_   !   �� 5a   "   8�� $��Center=�5c      ��5d      �� *	DayOfBith+5e      �� 5h      $��5 0 0 0q�6)   $ 
Horizontal=�6:   .+�5i   "   �� 8�� $��Center=�5j   J   $��
Вага: ��5k   !   �� 5m   "   8�� $��Center=�5o      ��5p      �� *Weight+�� 5q   "   8�� $��Center=�5s      $
��кг��5t      5u      �� 5z      $��5 0 0 0q�6)   $ 
Horizontal=�6;   .+�5{   "   �� 8�� $��Center=�5}   J   $8��2Останній час приймав їжу о: ��5~   !   �� 5�   "   8��	 $��Center=�5�      ��5�      �� *LastTimeAte+5�      5�      5�      5�      5�      �� 5�   
    � �� 5�      �� 5�      .R�5�      �� 5�      5�      �� 5�   
    � ��$	 155��6'   5�      �� 5�      "  ��5�      .�5�   
   ��  �@��IsTextSearchEnabled .  60   �� 5�   
    � ��8   6/   �� 5�   
    � ��$	 120��5�      �� 5�   
    � �� 5�      �� 5�      .R�5�      �� $ 
Horizontal=�6!   .+�5�      �� $��10(�5�      $��Center=�5�      $��Назва: ��5�      �� 5�      $��10(�5�      $��Center=�5�      ��5�      �� *Name+�� 5�      $��20 0 0 0q�5�      $��10(�5�      $��Center=�5�      $<��6 К-сть калорій в одному грамі: ��5�      �� 5�      $��10(�5�      $��Center=�5�      ��5�      �� *CaloriesPerGram+�� 5�      $��20 0 0 0q�5�      $��10(�5�      $��Center=�5�      $�� К-сть грам: ��5�      �� 5�      $��0 0 0 0q�5�      $��10(�5�      $��Center=�5�      ��5�      �� *	CountGram+5�      5�      5�      �� 5�   
    � �� 5�      �� 5�      .R�5�      �� 5�      5�      �� 5�   
    � ��$	 155��6'   5�      �� 5�      "  ��5�      .�5�   
   ��  �@��IsTextSearchEnabled .  60   �� 5�   
    � ��8   6/   �� 5�   
    � ��$	 120��5�      �� 5�   
    � �� 5�      �� 5�      .R�5�      �� $ 
Horizontal=�6!   .+�5�      �� $��10(�5�      $��Center=�5�      $��Назва: ��5�      �� 5�      $��10(�5�      $��Center=�5�      ��5�      �� *Name+5�      5�      5�      �� 5�   
    � �� 5      �� 5     .R�5     �� 5     5     �� 5  
    � ��$	 155��6'   5     �� 5     "  ��6   .�5  
   ��  � ��$ 15(�6%   �� 5  
    � ��$ Center=�60   �� 5  
    � ��$ Center=�6.   �� 5  
    � ��$ 0 0 5 0q�6#   5     �� 5     "  ��6   .�5  
   ��  � ��$ 40��6#   �� 5  
    � ��$ 40��6"   �� 5  
    � ��$ 25(�6%   �� 5  
    � ��$ Center=�60   5     5     