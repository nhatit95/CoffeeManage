   M S B A M L   `   `   `  ����G  CCoffeeManage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:CoffeeManageCoffeeManage  5   	       CoffeeManage.Home   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:CoffeeManage     5   	     � Title$  
MainWindow��5   	   $	��650��6   $
��1300��6)    � WindowStartupLocation$ CenterOwner=�66   $
��Auto=�6Z   $
��Auto=�6�   $y�Visible=�6�    � UseLayoutRounding .   � 
ResizeMode$ CanMinimize=�6�    � WindowState$ 	Maximized=�6   � Icon$0 */CoffeeManage;component/View/Img/floor.jpg��6   J� IsHitTestVisible . ��. .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $	��14* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��8* �6#   �� 5      $��2* �6#   .+�5      o� $��0��6   $��2��6$   ���	#FF1717D6���	#FFE2E0E0.@�5      m� $��
Quản lý��6   $	��180��6,   $��50��68   $��15(�6D   $��Center=�6R   $��43,0,6,0q�6v    .  ���	#FF070708	 m� Icon	 5      �� 5      $2��,/CoffeeManage;component/View/Img/quan_ly.png��6$   5      .@�5      m� -   5        $��itNguyenLieu��5   #   $	��175��67   $��50��6C   $��Nguyên Liệu��6O   $��	0,0,0.2,0q�6d   	 5      �� 5      $6��0/CoffeeManage;component/View/Img/nguyen_lieu.png��6$   5      5       m� 5!      -   5        $��
itNhanVien��5!      $	��175��61   $��50��6=   $��Nhân Viên��6I   $��	0,0,0.2,0q�6\   	 5"      �� 5#      $6��0/CoffeeManage;component/View/Img/nguyen_lieu.png��6$   5$      5'      m� 5(      -   5        $��	itThucDon��5(      $	��175��60   $��50��6<   $��Thực đơn��6H   $��	0,0,0.2,0q�6Z   	 5)      �� 5*      $6��0/CoffeeManage;component/View/Img/nguyen_lieu.png��6$   5+      5.      5/      m� 51      $��
Quản lý��6   $	��180��6,   $��50��68   $��15(�6D   $��Center=�6R   $��43,0,6,0q�6v    .  ���	#FF070708	 52      �� 53      $2��,/CoffeeManage;component/View/Img/quan_ly.png��6    54      .@�56      m� -   5        $
��test��56   L   $	��175��6   $��50��6+   $��Nguyên Liệu��67   	 57      �� 58      $6��0/CoffeeManage;component/View/Img/nguyen_lieu.png��6$   59      5<      5=      5@      � 5A      $��1��6   $��Right=�6(   $��10q�6D   .+�5B      �� $��Chào��6   $��15(�6(   
����  �6K   �� 5C      -   5        $��tbTenChucVu��5C      $�� ��6/   $��15(�67   
����  �$��5,0,5,0q�6W   6j   �� 5D      -   5        $��tbTenTaiKhoan��5D      $�� ��61   $��15(�69   
����  �6[   5E      5F      � 5G   
   $��1��6    5H      �� 5I      $	��81* �6#   �� 5J      $
��200* �6#   �� 5K      $
��366* �6#   .+�5M      �� $��0��6   $��2��6+   $��0,0,399.846,0.4q�6?   .��5N      ]� .+�5O      �� $	��Top=�6    $��Center=�65   $��30(�6S   $
��Bold"�6a   $��UTM Avo)�6s   
���  ��$��	Khu Vực��6�   6�   �� 5P      -   5        $��panelKhuVuc��5P   :   $��Bottom=�6!   5Q      5R      5S      �� 5T      $��1��6   $��80.4,0,-0.4,0.4q�6+   $��2��6D   .��5U      ]� .+�5V      �� $	��Top=�6    $��Center=�65   $��	Các bàn��6R   $��40(�6a   $
��Bold"�6o   $��UTM Avo)�6�   
���  ��6�   � 5W      -   5        $��panelBan��5W   s   $��Bottom=�6    $��Stretch=�68   $��Stretch=�6W   5X      5Y      5Z      5[      5_      5a      