   M S B A M L   `   `   `  ����M  IАвтосалон, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:АвтосалонАвтосалон  5   	   ,    &Автосалон.AuthorizationWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Автосалон     5   	   -   5          �Name$  Authorization��5   6    � Title$ Авторизация��6	   $	��300��6   $	��350��6*    � WindowStartupLocation$ CenterScreen=�5	   	    � Icon$ Icon.png��6.   .��5
      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��2* �6   �� 5      $��* �6   .+�5   
   �� $��2��6   $��Center=�6"    �� Orientation$ 
Horizontal=�6?   $
��auto��6X   $��1��6e   .+�5      �� -   5         ��Name$ label��5      $�� Логин��6$   $��30��66   $��50��6B   �� 5      -   5         ��Name$ 
textBLogin��5      	 �� TextWrapping$
	 Wrap=�6+   $�� ��6?   $��22��6G   $	��130��6S   5      �� 5   
   $��3��6   $��Center=�6"   $ 
Horizontal=�6?   $
��auto��6X   $��1��6e   .+�5      �� -   5        $ label1��5      $��Пароль��6$   $
��Left=�65   $	��Top=�6P   $��1��6h   $��50��6u   G� 5      -   5        
 G�Name$
 passwordBox��5      $
��Left=�6/   $	��Top=�6K   $��22��6c   $	��130��6o    G� PasswordChar$ *��6{   $��1��6�   $��1��6�   5      �� 5    
   $��4��6   $��Center=�6"   $ Vertical=�6?   $
��auto��6V   $��1��6c   .+�5!      �� -   5         ��Name$ btnReg��5!      $��Регистрация��6%   $
��Left=�6;   $	��Top=�6W   $	��130��6o   ���#5aa3d8$��2��6�   $��1��6�   �� 5"      -   5        $ btnOK��5"      $��Вход��6$   $
��Left=�63   $	��Top=�6O   $	��130��6g   ���#5aa3d8$��2��6�   $��1��6�   5#      �� 5$   
   $��5��6   $��Center=�6"   $ Vertical=�6?   $
��auto��6V   $��25��6c   $��2��6o   .+�5%      �� -   5        $ btnExit��5%      $��
Выход��6&   $
��Left=�66   $	��Top=�6R   $��50��6j   ���#5aa3d8$��2��6�   $��2��6�   5&      �� 5'   
   -	   5         ��Name$ AvtomabilIcon_png��5'      $��95��6+   $��95��66   $��AvtomabilIcon.png��6B   $
��Fill=�6]   $��1��6l   $��2��6}   ��5(   
   �� 5)       j� Stretch$ UniformToFill=�6    �� ImageSource 5*      �� 5+       �� 	UriSource$� �file:///C:/Users/Александр/Desktop/МПТ/Практика/МДК 02.01/УП 02.02 (Часть 2)/Автосалон/Автосалон/Автосалон/Image/1.jpg?�6"   5-      5/      50      