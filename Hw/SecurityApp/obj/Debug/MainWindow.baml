   M S B A M L   `   `   `  ����F  BSecurityApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SecurityAppSecurityApp  5   	       SecurityApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SecurityApp     5   	   -   5          �Name$  
mainWindow��5   	    � Title$ Вход��5   	   $	��450��6   $	��800��6#   $��Times New Roman)�6/   $y�Visible=�6L    � WindowStyle$ ThreeDBorderWindow=�6a   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FF5E47F1��6    � Offset$ 0.002Q�6-   � 5      $ 	#FFBF5656��6   $ 1Q�6-   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��200* �6   �� 5      $
��100* �6   �� 5      $
��200* �6    � RowDefinitions 5   
   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $
��100* �6   .+�5   
   �� 	 �� Orientation$	 Vertical=�6   $��1��6,   $��1��6<   .+�5      �� $��Логин:��6   
 �� TextAlignment$
 Center=�6&   $��Times New Roman)�6=   �� 5      -   5        $��loginTextBox��5      $��0 0 0 10q�6*   �� 5       $��Пароль:��6   $
 Center=�6'   $��Times New Roman)�6>   G� 5!      -   5        $��passswordBox��5!      $��0 0 0 20q�6.   �� 5"      -   5        $��signInButton��5"      $��
Войти��6)   $��0 0 0 5q�6S   �� 5#      -   5        $��registerButton��5#      $��Регистрация��6+   ���	#FFDDDDDD6[   5$      5%      5&      