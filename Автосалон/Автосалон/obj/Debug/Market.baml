   M S B A M L   `   `   `  ����M  IАвтосалон, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:АвтосалонАвтосалон  5   	       Автосалон.Market   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Автосалон     5   	     � Title$  Market��5   	   $	��550��6   $	��750��6%   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      $
��Auto �6   $��26��6*    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	AdminGrid��5   /      AutoGenerateColumns .  $��5,5,5,0q�6B   $��3��6S   $��1��6g      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Модель��6?      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6O   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Title+6O     5      $  Производитель��6A   $	 125 6X    6%   �� *	Company+6X     5      $ Цена��6?   $ 80 6M    6%   �� *Price+6M   5      �� 5   
   $
��Left=�6   $��1��60   	 �� Orientation$	 
Horizontal=�6>   $
��auto��6W   $��5,5,0,5q�6d   $��3��6u   .+�5      �� -   5        
 ��Name$
 btn_add��5      $��Добавить��6&   $��0��6O   $��1��6_   $
��Left=�6l   �� 5      -   5        $
 	btn_izmen��5      $��Изменить��6(   $��0��6S   $��1��6c   $
��Left=�6p   $��22��6�   $��Bottom=�6�   �� 5       -   5        $
 btn_del��5       $��Удалить��6&   $��0��6N   $��1��6^   $
��Left=�6k   �� 5"      -   5        $
 
btn_update��5"      $��Обновить��6)   $��2��6U   $��1��6e   $��Right=�6r   �� 5#      -   5        $
 btn_ext_Admn��5#      $��
Выход��6+   $��2��6W   $��1��6g   $��Right=�6t   5$      ��5%   
   �� 5&       j� Stretch$ UniformToFill=�6    �� ImageSource 5'      �� 5(       �� 	UriSource$� �file:///C:/Users/Александр/Desktop/МПТ/Практика/МДК 02.01/УП 02.02 (Часть 2)/Автосалон/Автосалон/Автосалон/Image/3.jpg?�6"   5*      5,      5-      