   M S B A M L   `   `   `  ���� D  @Help-Desk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Help_Desk.ApresentacaoHelp_Desk.Apresentacao  '    !Help_Desk.Apresentacao.frmChamado   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6local$clr-namespace:Help_Desk.Apresentacao       � Title$  Chamado��$	��652��$	��700��.���  � RowDefinitions �� $
��485* ��� $
��137* �.+��� -    ��Name$ cbxPrioridade��$
��Left=�$��
43,195,0,0q�$	��Top=�$	��235��$��26��$��3��.@��� $
��Alta��$
��Left=�$	��118���� $��Média��$
��Left=�$	��233���� $��Baixa��$
��Left=�$	��233���� -    ��Name$ txbDescriçao��$
��Left=�$	��179��$��
43,349,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��606��$��5��$��2���� -   $ txbSolicitante��$
��Left=�$��22��$��	46,95,0,0q�$
 Wrap=�$	��Top=�$	��235��$��1��{�.  �� -   $ cbxSetor��$
��Left=�$��
45,142,0,0q�$	��Top=�$	��333��$��26��$��2��.@��� $��Almoxarifado��$
��Left=�$	��118���� $��
Tecnologia��$
��Left=�$	��118���� $��Faturamento��$
��Left=�$	��118���� $��
Produção��$
��Left=�$	��118���� -    ��Name$ lblSolicitante��$��Solicitante��$
��Left=�$��	47,69,0,0q�$	��Top=�$��26��$��65�� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� ��  �� Angle$ -0.435Q�T� �� -   $ lblPrioridade��$��Prioridade do pedido��$
��Left=�$��
43,169,0,0q�$	��Top=�$��26��$	��122���� -   $ lblSetor��$��Setor��$
��Left=�$��
45,116,0,0q�$	��Top=�$��26��$��38���� -   $ lblDescrição��$��Descrição do pedido��$
��Left=�$��
43,323,0,0q�$	��Top=�$��26��$	��119���� -	   $ txbData��$
��Left=�$��22��$��
43,272,0,0q�$
 Wrap=�$	��Top=�$	��158��$��4��{�.  �� -
   $ lblData��$��Data do pedido��$
��Left=�$��
43,246,0,0q�$	��Top=�$��26��$��93���� -    ��Name$ btnSolicitar��$��Enviar��$
��Left=�$��
538,63,0,0q�$��1��$	��Top=�$	��111��$��6��$��31���� -   $ 	btnLimpar��$��Limpar campos��$
��Left=�$��
410,63,0,0q�$��1��$	��Top=�$	��111��$��6��$��31��