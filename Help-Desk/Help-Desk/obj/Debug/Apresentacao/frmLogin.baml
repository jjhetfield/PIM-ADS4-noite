   M S B A M L   `   `   `  ����D  @Help-Desk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Help_Desk	Help_Desk  5   	       Help_Desk.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Help_Desk     5   	   -   5          �Name$  frmLogin��5   	    � Title$ Login��5   	   $��337.218��6   $��477.82��6(   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��0* �6   �� 5      $��0* �6   �� 5      .+�5   
   �� -   5         ��Name$ 
lblUsuario��5      $��Usuário��6$   $
��Left=�66   $��
259,59,0,0q�6Q   $	��Top=�6e   $��2��6}   $��26��6�   $��50��6�   �� 5   
   -   5        $ lblSenha��5      $��Senha��6"   $
��Left=�62   $��267,139,0,0q�6M   $	��Top=�6b   $��2��6z   $��26��6�   $��42��6�   �� 5   
   -   5         ��Name$ 
txbUsuario��5      $
��Left=�6&   $��23��6A   $��
314,59,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��120��6�   $��2��6�   �� 5   
   -   5         ��Name$ 	txbEntrar��5      $��Entrar��6$   $
��Left=�65   $��334,186,0,0q�6P   $	��Top=�6e   $	��100��6}   $��2��6�   $��22��6�   �� 5   
   -   5        $ lblRecuperarSenha��5      $��Recuperar a senha��6+   $
��Left=�6G   $��323,213,0,0q�6b   $	��Top=�6w   ���	#FFC31515$	��111��6�   $��2��6�   $��26��6�   6�   �� 5   
   $��3��6   $
��Left=�6$   $	��100��6?   $��
52,108,0,0q�6L   $	��Top=�6`   $	��100��6x    J� OpacityMask 5      �� 5      5      G� 5   
   -   5         G�Name$ pswSenha��5      $��3��6(   $
��Left=�6<   $��314,142,0,0q�6W   $	��Top=�6l   $	��120��6�   5      5      