   M S B A M L   `   `   `  ����H  DPomodoroClock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PomodoroClockPomodoroClock  5   	       PomodoroClock.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:PomodoroClock     5   	     � Title$  
MainWindow��5   	   $	��269��6   $	��327��6)    � WindowStyle$
 None=�65    � AllowsTransparency$
 True��6H    � WindowStartupLocation$ CenterScreen=�6b    � Topmost$
 True��6�    � Icon$ /Resources/Icon.ico��6�   ��5	      �� 5
   
    �� Opacity$ 0Q�6    �� Color$ White��6&   66   .��5      � -   5        $	��227��5      .+�5   
   �� -   5         ��Name$ plusBtn��5      $��/Resources/ButtonR.png��6!   $
��Left=�6A   $��	29,10,0,0q�6\   $	��Top=�6o   $��60��6�   $��60��6�   $|�False��6�   �� 5   
   -   5        $��+��5      $
��Left=�6   $��38��67   $��	29,24,0,0q�6C   $	��Top=�6V   $��60��6n   
�������$��Comic Sans MS)�6�   $��Center=�6�   $��20(�6�   6�   �� 5   
   -   5        $ minusBtn��5      $��/Resources/ButtonR.png��6"   $
��Left=�6B   $��5,0,0,0q�6]   $��Center=�6n   $��60��6�   $��60��6�   $|�False��6�   �� 5   
   -   5        $��-��5      $
��Left=�6   $��37��67   $	��Top=�6C   $��54��6[   
�������$��Comic Sans MS)�6y   $��Center=�6�   $��20(�6�   $��8,98,0,0q�6�   6�   �� 5   
   -   5        $ setBtn��5      $��/Resources/ButtonR.png��6    $
��Left=�6@   $��
24,158,0,0q�6[   $	��Top=�6o   $��60��6�   $��60��6�   $|�False��6�   �� 5   
   -   5        $	��Set��5      $
��Left=�6   $��34��69   $��
25,177,0,0q�6E   $	��Top=�6Y   $��58��6q   
�������$��Comic Sans MS)�6�   $��Center=�6�   $��15(�6�   6�   � 5   
   -   5        	 �Name$	 MainGrid��5      $y�Visible=�6"   $��70,0,0,0q�67   
 � RowDefinitions
 5      �� 5      $	��50* �6    �� 5      $
��177* �6    .+�5      �� -	   5         ��Name$ timerLbl��5      $��25��6&   $��Center=�63   $	��Top=�6P   $��80(�6h   $
��Bold"�6v   $��Comic Sans MS)�6�   
�������$	��102��6�   $��0,12,0,0q�6�   $��1��6�   �� 5      -
   5        $ startLbl��5      $��Click here to start...��6&   $��37��6H   $��30,114,21,0q�6T   $	��Top=�6i   
�������$��Comic Sans MS)�6�   $��Center=�6�   $��12(�6�   $��1��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   6  ��5      �� 5      -   5        	mainBgImg�� �� ImageSource$ /Resources/MainBR.png��5   0    j� Stretch$
 Fill=�6T   6e   5      5#      5$      