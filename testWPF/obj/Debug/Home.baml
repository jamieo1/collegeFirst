   M S B A M L   `   `   `  ����B  >testWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:testWPFtestWPF  5   	       testWPF.Home   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:testWPF     5   	     � Title$  Fitness App XYZ - Home��5   	   $	��471��6(   $	��503��65    � WindowStartupLocation$ CenterScreen=�6A    � 
ResizeMode$ NoResize=�6f   .��5	      � 
����ح� � RowDefinitions 5
   
   �� 5      $
��260* �6   �� 5      $
��111* �6   .+�5   
   �� -   5        $��myPic��5      $��content/homeImage.png��6   $	��120��6<   $	��Top=�6I   $��
10,10,10,0q�6a   �� 5   
   -   5         ��Name$ buttonPicture��5      $��Change pciture...��6(   
��� ���$��145,135,145,0q�6X   $	��Top=�6o   $	��110��6�   6�   �� 5   
   -   5        $ inputDetails��5      $��
My Details��6'   
��� ���$��10,250,10,10q�6P   $��2��6�   �� 5   
   -   5        $ button3��5      $��Routines(disabled)��6"   {�.  
��� ���$
��Left=�6e   $��
10,135,0,0q�6�   $	��Top=�6�   $	��130��6�   $	��110��6�   �� 5   
   -   5        $ buttonMoreInfo��5      $��	More Info��6)   
��� ���$��
0,135,10,0q�6Q   $��Right=�6�   $	��130��6�   $	��110��6�   $	��Top=�6�   5      5      