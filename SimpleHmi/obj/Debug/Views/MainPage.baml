   M S B A M L   `   `   `  ����D  @SimpleHmi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SimpleHmi.ConvertersSimpleHmi.Converters  5      1clr-namespace:SimpleHmi.ViewsSimpleHmi.Views  5      ;"clr-namespace:SimpleHmi.ViewModelsSimpleHmi.ViewModels  5      h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35�`clr-namespace:Microsoft.Expression.Interactivity.Core;assembly=Microsoft.Expression.Interactions'Microsoft.Expression.Interactivity.Core 5
      7 clr-namespace:SimpleHmi.DesignerSimpleHmi.Designer  5          SimpleHmi.Views.MainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      9
Converters"clr-namespace:SimpleHmi.Converters     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:SimpleHmi.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      1vm"clr-namespace:SimpleHmi.ViewModels     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	      iei`clr-namespace:Microsoft.Expression.Interactivity.Core;assembly=Microsoft.Expression.Interactions  5
      P LPrism.Wpf, Version=6.2.0.0, Culture=neutral, PublicKeyToken=91a96d2a154366d8$prismhttp://prismlibrary.com/  5      -design clr-namespace:SimpleHmi.Designer  5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  .  � 	Resources 5      2  ,SimpleHmi.Converters.BooleanToBrushConverter   BooleanToBrushConverter��%   &	          5   
   6-   5      .��5      � ���	#FFB8F5C6 � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��2* �6   �� 5      $��* �6   .+�5#   
   �� $	��116��6   $��20��5$      $��	100,2,0,0q�5%      $
��Left=�5&      $	��Top=�5'      $�� Plc Ip Address��5(      $��16(�5)      $
��Bold"�5*      $
��Wrap=�5+      �� 5,   
   $	��307��6   $��28��5-      $��	10,35,0,0q�5.      $
��Left=�5/      $	��Top=�50       �� TextWrapping$
 Wrap=�52      ��51      �� *	IpAddress+52      �� 53   
   $	��129��6   $��31��54      $��	10,80,0,0q�55      $
��Left=�56      $	��Top=�57      $��Connect��59      ��58      �� *ConnectCommand+ �� Mode$ OneWay=�59      �� 5:   
   $	��145��6   $��31��5;      $��
172,80,0,0q�5<      $
��Left=�5=      $	��Top=�5>      $��
Disconnect��5@      ��5?      �� *DisconnectCommand+$ OneWay=�5@      �� 5B   
   $	��129��6   $��31��5C      $��
10,128,0,0q�5D      $
��Left=�5E      $	��Top=�5F      $
��Auto��5H      ��5G      �� *StartCommand+$ OneWay=�5H      �� 5I   
   $	��145��6   $��31��5J      $��172,129,0,0q�5K      $
��Left=�5L      $	��Top=�5M      $��Manual��5O      ��5N      �� *StopCommand+$ OneWay=�5O      �� 5P   
   $
��Left=�6   $	��357��60   $��0,3,0,0q�6=   $��1��6N   $	��Top=�6[   $	��327��6s   .+�5Q      �� $��Rotary Axis Joging��6   $��Center=�61   $��0,0,0,0q�6N   $	��Top=�6_   $
��auto��6w   $
��auto��6�   $��16(�6�   $��Center=�6�   $��0q�6�   $
��Bold"�6�   �� 5R      $*��$Rotary Axis Jog Velocity(degree/sec)��6   $
��Left=�6C   $��5,5,0,0q�6^   $	��Top=�6p   $
��auto��6�   $
��auto��6�   $��14(�6�   $��Center=�6�   $��0q�6�   �� 5S      $	��307��6   $
��auto��5T      $��0,5,0,0q�5U      $��Center=�5V      $	��Top=�5W      $��16(�5X      $��SemiBold"�5Y   m   ��6   �� *RoterJogSpeed+ �� Delay$ 10��$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6m   �� 5Z      -   5         ��Name$ button��5\        RoundButtonTemplate#��[ 5[      
���  ��$��	Jogging +��5\   0   $��Center=�6D   $��0,5,0,0q�6a   $	��Top=�6r   $	��306��6�   $��36��6�   $��2��6�   
��� ���$��2q�6  ��6�   �� *RoterMoveingState+	 �� 	Converter#	 [  .  (System.Windows.Interactivity.Interaction
   Triggers
 5]      /  )System.Windows.Interactivity.EventTrigger  5^         	EventName$  PreviewMouseLeftButtonDown��6%   .  (System.Windows.Interactivity.TriggerBase   Actions. 5_      6  0System.Windows.Interactivity.InvokeCommandAction     Command 60   �� *RoterJogPositveStartCommand+5`        5a      $ PreviewMouseLeftButtonUp��6%   . 5b         60   �� *RoterJogPositveStopCommand+5c      5e      �� 5f      -   5        $ button_Copy��5h       #��[ 5g      
�������$��	Jogging -��5h   6   $��Center=�6J   $��0,5,0,0q�6g   $	��Top=�6x   $	��304��6�   $��36��6�   $��2��6�   
��� ���$��2q�6%  ��6�   �� *RoterMoveingState+#	 [  
 5i        5j      $  PreviewMouseLeftButtonDown��6%   . 5k         60   �� *RoterJogNegativeStartCommand+5l        5m      $ PreviewMouseLeftButtonUp��6%   . 5n         60   �� *RoterJogNegativeStopCommand+5o      5q      �� 5r      $��Rotary Axis Positioning��6   $��Center=�66   $��0,0,0,0q�6S   $	��Top=�6d   $
��auto��6|   $
��auto��6�   $��16(�6�   $��Center=�6�   $��0q�6�   $
��Bold"�6�   �� 5s      $2��,Rotary Axis Positioning Velocity(degree/sec)��6   $
��Left=�6K   $��5,5,0,0q�6f   $	��Top=�6x   $
��auto��6�   $
��auto��6�   $��14(�6�   $��Center=�6�   $��0q�6�   �� 5t      $	��307��6   $
��auto��5u      $��0,5,0,0q�5v      $��Center=�5w      $	��Top=�5x      $��16(�5y      $��SemiBold"�5z   v   ��6   �� *RoterPositioningSpeed+$ 10��$ TwoWay=�$ PropertyChanged=�6v   �� 5{      $*��$Rotary Axis Commend Position(degree)��6   $
��Left=�6C   $��5,5,0,0q�6^   $	��Top=�6p   $
��auto��6�   $
��auto��6�   $��14(�6�   $��Center=�6�   $��0q�6�   �� 5|      $	��307��6   $
��auto��5}      $��0,5,0,0q�5~      $��Center=�5      $	��Top=�5�      $��16(�5�      $��SemiBold"�5�   u   ��6   �� *RoterCommendposition+$ 10��$ TwoWay=�$ PropertyChanged=�6u   �� 5�      -   5        $ button_roter_position��5�      #��[ 5�      
���  ��$��Positioning Start ��5�   ?   $��Center=�6\   $��0,5,0,0q�6y   $	��Top=�6�   $	��306��6�   $��36��6�   $��2��6�   
��� ���$��2q�5�      ��5�   �   �� *RoterMoveingState+#	 [  ��5�      �� *RoterPostionStartCommand+$ OneWay=�5�      5�      �� 5�   
   $��1��6   $
��Left=�6%   $	��357��6@   $��0,3,0,0q�6M   $��1��6^   $	��Top=�6k   $	��327��6�   .+�5�      �� $!��Rotery Position Axis Joging��6   $��Center=�6:   $��0,0,0,0q�6W   $	��Top=�6h   $
��auto��6�   $
��auto��6�   $��16(�6�   $��Center=�6�   $��0q�6�   $
��Bold"�6�   �� 5�      $/��)Rotery Position Axis Jog Velocity(mm/sec)��6   $
��Left=�6H   $��5,5,0,0q�6c   $	��Top=�6u   $
��auto��6�   $
��auto��6�   $��14(�6�   $��Center=�6�   $��0q�6�   �� 5�      $	��307��6   $
��auto��5�      $��0,5,0,0q�5�      $��Center=�5�      $	��Top=�5�      $��16(�5�      $��SemiBold"�5�   q   ��6   �� *RoteryPosJogSpeed+$ 10��$ TwoWay=�$ PropertyChanged=�6q   �� 5�      -   5        $% button_Rotery_Position_Positive��5�      #��[ 5�      
���  ��$��	Jogging +��5�   I   $��Center=�6]   $��0,5,0,0q�6z   $	��Top=�6�   $	��306��6�   $��36��6�   $��2��6�   
��� ���$��2q�67  ��6�   �� *RoteryPosMoveing+#	 [  
 5�        5�      $  PreviewMouseLeftButtonDown��6%   . 5�         60   �� *!RoteryPosJogPositveStartCommand+5�        5�      $ PreviewMouseLeftButtonUp��6%   . 5�         60   �� * RoteryPosJogPositveStopCommand+5�      5�      �� 5�      -   5        $% button_Rotery_Position_Negative��5�       #��[ 5�      
�������$��	Jogging -��5�   J   $��Center=�6^   $��0,5,0,0q�6{   $	��Top=�6�   $	��304��6�   $��36��6�   $��2��6�   
��� ���$��2q�68  ��6�   �� *RoteryPosMoveing+#	 [  
 5�        5�      $  PreviewMouseLeftButtonDown��6%   . 5�         60   �� *" RoteryPosJogNegativeStartCommand+5�        5�      $ PreviewMouseLeftButtonUp��6%   . 5�         60   �� *!RoteryPosJogNegativeStopCommand+5�      5�      �� 5�      $&�� Rotery Position Axis Positioning��6   $��Center=�6?   $��0,0,0,0q�6\   $	��Top=�6m   $
��auto��6�   $
��auto��6�   $��16(�6�   $��Center=�6�   $��0q�6�   $
��Bold"�6�   �� 5�      $7��1Rotery Position Axis Positioning Velocity(mm/sec)��6   $
��Left=�6P   $��5,5,0,0q�6k   $	��Top=�6}   $
��auto��6�   $
��auto��6�   $��14(�6�   $��Center=�6�   $��0q�6�   �� 5�      $	��307��6   $
��auto��5�      $��0,5,0,0q�5�      $��Center=�5�      $	��Top=�5�      $��16(�5�      $��SemiBold"�5�   z   ��6   �� *RoteryPosPositioningSpeed+$ 10��$ TwoWay=�$ PropertyChanged=�6z   �� 5�      $/��)Rotery Position Axis Commend Position(mm)��6   $
��Left=�6H   $��5,5,0,0q�6c   $	��Top=�6u   $
��auto��6�   $
��auto��6�   $��14(�6�   $��Center=�6�   $��0q�6�   �� 5�      $	��307��6   $
��auto��5�      $��0,5,0,0q�5�      $��Center=�5�      $	��Top=�5�      $��16(�5�      $��SemiBold"�5�   y   ��6   �� *RoteryPosCommendposition+$ 10��$ TwoWay=�$ PropertyChanged=�6y   �� 5�      -   5        $% button_Rotery_Position_position��5�      #��[ 5�      
���  ��$��Positioning Start ��5�   I   $��Center=�6f   $��0,5,0,0q�6�   $	��Top=�6�   $	��306��6�   $��36��6�   $��2��6�   
��� ���$��2q�5�      ��5�   �   �� *RoteryPosMoveing+#	 [  ��5�      �� *RoteryPosPostionStartCommand+$ OneWay=�5�      5�      �� 5�   
   $��2��6   $
��Left=�6%   $	��357��6@   $��0,3,0,0q�6M   $��1��6^   $	��Top=�6k   $	��327��6�   .+�5�      �� $��Shorter Axis Joging��6   $��Center=�62   $��0,0,0,0q�6O   $	��Top=�6`   $
��auto��6x   $
��auto��6�   $��16(�6�   $��Center=�6�   $��0q�6�   $
��Bold"�6�   �� 5�      $'��!Shorter Axis Jog Velocity(mm/sec)��6   $
��Left=�6@   $��5,5,0,0q�6[   $	��Top=�6m   $
��auto��6�   $
��auto��6�   $��14(�6�   $��Center=�6�   $��0q�6�   �� 5�      $	��307��6   $
��auto��5�      $��0,5,0,0q�5�      $��Center=�5�      $	��Top=�5�      $��16(�5�      $��SemiBold"�5�   o   ��6   �� *ShorterJogSpeed+$ 10��$ TwoWay=�$ PropertyChanged=�6o   �� 5�      -   5        $ button_Shorter_Positive��5�      #��[ 5�      
���  ��$��	Jogging +��5�   A   $��Center=�6U   $��0,5,0,0q�6r   $	��Top=�6�   $	��306��6�   $��36��6�   $��2��6�   
��� ���$��2q�6-  ��6�   �� *ShorterMoveing+#	 [  
 5�        5�      $  PreviewMouseLeftButtonDown��6%   . 5�         60   �� *ShorterJogPositveStartCommand+5�        5�      $ PreviewMouseLeftButtonUp��6%   . 5�         60   �� *ShorterJogPositveStopCommand+5�      5�      �� 5�      -   5        $ button_Shorter_Negative��5�       #��[ 5�      
�������$��	Jogging -��5�   B   $��Center=�6V   $��0,5,0,0q�6s   $	��Top=�6�   $	��304��6�   $��36��6�   $��2��6�   
��� ���$��2q�6.  ��6�   �� *ShorterMoveing+#	 [  
 5�        5�      $  PreviewMouseLeftButtonDown��6%   . 5�         60   �� * ShorterJogNegativeStartCommand+5�        5�      $ PreviewMouseLeftButtonUp��6%   . 5�         60   �� *ShorterJogNegativeStopCommand+5�      5�      �� 5�      $��Shorter Axis Positioning��6   $��Center=�67   $��0,0,0,0q�6T   $	��Top=�6e   $
��auto��6}   $
��auto��6�   $��16(�6�   $��Center=�6�   $��0q�6�   $
��Bold"�6�   �� 5�      $/��)Shorter Axis Positioning Velocity(mm/sec)��6   $
��Left=�6H   $��5,5,0,0q�6c   $	��Top=�6u   $
��auto��6�   $
��auto��6�   $��14(�6�   $��Center=�6�   $��0q�6�   �� 5�      $	��307��6   $
��auto��5�      $��0,5,0,0q�5�      $��Center=�5�      $	��Top=�5�      $��16(�5�      $��SemiBold"�5�   x   ��6   �� *ShorterPositioningSpeed+$ 10��$ TwoWay=�$ PropertyChanged=�6x   �� 5�      $'��!Shorter Axis Commend Position(mm)��6   $
��Left=�6@   $��5,5,0,0q�6[   $	��Top=�6m   $
��auto��6�   $
��auto��6�   $��14(�6�   $��Center=�6�   $��0q�6�   �� 5�      $	��307��6   $
��auto��5�      $��0,5,0,0q�5�       �� 	MaxLength$ 3��5�      $��Center=�5�      $	��Top=�5�      $��16(�5�      $��SemiBold"�5�   w   ��6   �� *ShorterCommendposition+$ 10��$ TwoWay=�$ PropertyChanged=�6w   �� 5�      -	   5        $ button_Shorter_position��5�      #��[ 5�      
���  ��$��Positioning Start ��5�   A   $��Center=�6^   $��0,5,0,0q�6{   $	��Top=�6�   $	��306��6�   $��36��6�   $��2��6�   
��� ���$��2q�5�      ��5�   �   �� *ShorterMoveing+#	 [  ��5�      �� *ShorterPostionStartCommand+$ OneWay=�5      5     �� 5  
   $
��Left=�6   $	��180��60   $��2��6=   $	��Top=�6J   $	��327��6b   .+�5     �� $��Pneumatic Operation��6   $��Center=�62   $��0,0,0,0q�6O   $	��Top=�6`   $
��auto��6x   $
��auto��6�   $��16(�6�   $��Center=�6�   $��0q�6�   $
��Bold"�6�   d� 5     $��36��6   $	��306��6(   $��Center=�64   $��0,5,0,0q�6Q   $	��Top=�6b   
 5       5     $ Checked��6%   . 5        60   �� *MainGripperStartCommand+5       5	     $ 	Unchecked��6%   . 5
        60   �� *MainGripperStopCommand+5     ��5     �� 5      �� 
TargetType" d�6   .�5     ��  �� Property � �� �� Value$ Main Gripper Open ��64   �� 5      � �� 5     �� 5  "    �� 
TargetType" d�62   .R�5  &   ��  �� CornerRadius$ 15��6-   $��1q�5  !   ��5  ?   �� *MainGripperState+#	 [  ._�5  *   �� $��Center=�6;   $��Center=�6X   5  '   5  #   5      �� Triggers 5     P� 5      P� Property �@d�	IsChecked P� Value$
 TrueY�6;   . �5  "   ��  � ��$ Main Gripper Close��6<   �� 5  "    � ��
 �����6?   5     5      5"     d� 5#     $��Center=�6   $��0,2,0,0q�68   $	��Top=�6I   $��36��6a   $	��306��6m   
 5$       5%     $ Checked��6%   . 5&        60   �� *ShorterGripperStartCommand+5'       5(     $ 	Unchecked��6%   . 5)        60   �� *ShorterGripperStopCommand+5*     ��5,     �� 5-     " d�6   .�5.     ��  � ��$ Shorter Gripper Open ��64   �� 5/      � �� 50     �� 51  "   " d�62   .R�52  &   �� $ 15��6-   $��1q�53  !   ��52  ?   �� *ShorterGripperState+#	 [  ._�54  *   �� $��Center=�6;   $��Center=�6X   55  '   56  #   58      59     P� 5:      �@d�	IsChecked$
 TrueY�6;   . �5;  "   ��  � ��$ Shorter Gripper Close��6<   �� 5<  "    � ��
 �����6?   5=     5?     5A     d� 5B     $��Center=�6   $��0,2,0,0q�68   $	��Top=�6I   $��36��6a   $	��306��6m   
 5C       5D     $ Checked��6%   . 5E        60   �� *ShorterCylinderStartCommand+5F       5G     $ 	Unchecked��6%   . 5H        60   �� *ShorterCylinderStopCommand+5I     ��5K     �� 5L     " d�6   .�5M     ��  � ��$ Shorter Cylinde Open ��64   �� 5N      � �� 5O     �� 5P  "   " d�62   .R�5Q  &   �� $ 15��6-   $��1q�5R  !   ��5Q  ?   �� *ShorterCylinderState+#	 [  ._�5S  *   �� $��Center=�6;   $��Center=�6X   5T  '   5U  #   5W      5X     P� 5Y      �@d�	IsChecked$
 TrueY�6;   . �5Z  "   ��  � ��$ Shorter Cylinder Close��6<   �� 5[  "    � ��
 �����6?   5\     5^     5`     5a     �� 5b  
   $��1��6   $
��Left=�6%   $	��180��6@   $��2��6M   $	��Top=�6Z   $	��327��6r   .+�5c     �� $��Axis Homeing��6   $��Center=�6+   $��0,0,0,0q�6H   $	��Top=�6Y   $
��auto��6q   $
��auto��6   $��16(�6�   $��Center=�6�   $��0q�6�   $
��Bold"�6�   �� 5d     -
   5        $ button_Homing_Shorter��5f     #��[ 5e     
���  ��$!��Shorter Axis Homeing Start ��5f  ?   $��Center=�6e   $��0,5,0,0q�6�   $	��Top=�6�   $	��306��6�   $��36��6�   $��2��6�   
���/���$��2q�5g     ��5f  �   �� *ShorterMoveing+#	 [  ��5h     �� *ShorterPostionHomingCommand+$ OneWay=�5i     �� 5j     -   5        $ button_Homing��5l     #��[ 5k     
���  ��$)��#Rotery Position Axis Homeing Start ��5l  7   $��Center=�6e   $��0,5,0,0q�6�   $	��Top=�6�   $	��306��6�   $��36��6�   $��2��6�   
���/���$��2q�5m     ��5l  �   �� *RoteryPosMoveing+#	 [  ��5n     �� *RoteryPosPostionHomingCommand+$ OneWay=�5o     �� 5p     -   5        $ button_roter_Homing��5r     #��[ 5q     
���  ��$��Roter Axis Homing Start ��5r  =   $��Center=�6`   $��	10,5,11,0q�6}   $	��Top=�6�   $	��306��6�   $��36��6�   $��2��6�   
���/���$��2q�5s     ��5r  �   �� *RoterMoveingState+#	 [  ��5t     �� *RoterPostionHomingCommand+$ OneWay=�5u     5v     �� 5w  
   $��3��6   $
��Left=�6%   $	��180��6@   $��2��6N   $	��Top=�6[   $	��327��6s   $��2��6   .+�5x     �� $��Manual Vision Test��6   $��Center=�61   $��0,0,0,0q�6N   $	��Top=�6_   $
��auto��6w   $
��auto��6�   $��16(�6�   $��Center=�6�   $��0q�6�   $
��Bold"�6�   �� 5y     -   5        $ button_Alignment_Test��5{     #��[ 5z     
���  ��$��Alignment Check��5{  ?   $��Center=�6Y   $��0,5,0,0q�6v   $	��Top=�6�   $	��306��6�   $��36��6�   $��2��6�   
��� ���$��2q�5|     ��5{  �   �� *ShorterMoveing+#	 [  ��5}     �� *AlignmentTestCommand+$ OneWay=�5~     �� 5     -   5        $ button_Crack_Check��5�     #��[ 5�     
���  ��$��Crack Check��5�  <   $��Center=�6R   $��0,5,0,0q�6o   $	��Top=�6�   $	��306��6�   $��36��6�   $��2��6�   
��� ���$��2q�5�     ��5�  �   �� *RoteryPosMoveing+#	 [  ��5�     �� *CrackCheckCommand+$ OneWay=�5�     �� 5�     -   5        $ button_Dust_Check��5�     #��[ 5�     
���  ��$��Dust Check ��5�  ;   $��Center=�6Q   $��	10,5,11,0q�6n   $	��Top=�6�   $	��306��6�   $��36��6�   $��2��6�   
��� ���$��2q�5�     ��5�  �   �� *RoterMoveingState+#	 [  ��5�     �� *DustCheckCommand+$ OneWay=�5�     5�     �� 5�  
   $��2��6   $
��Left=�6%   $	��200��6@   $	��Top=�6M   $	��326��6e   .+�5�     �� $ ��Auto Vision Test Selection��6   $��Center=�69   $��0,2,0,0q�6V   $	��Top=�6g   $
��auto��6   $
��auto��6�   $��16(�6�   $��Center=�6�   $��0q�6�   $
��Bold"�6�   �� 5�     $��	10,10,0,0q�6    �� Orientation$ 
Horizontal=�6-   $��Stretch=�6G   $
��auto��6e   $	��Top=�6s   .+�5�     �� $��0,0,0,0q�6   $
��Left=�6-   $��Alignment Check��6~    d� 	IsChecked 6H   �� *AligmentCheckState+$ OneWay=� � LayoutTransform 5�     �� 5�      �� ScaleX$	 1.5Q�6)    �� ScaleY$	 1.5Q�66   
 5�       5�     $ Checked��6)   . 5�        64   �� *AligmentCheckSelectedCommand+5�       5�     $ 	Unchecked��6)   . 5�        64   �� *!AligmentCheckNotSelectedCommand+5�     5�     A� 5�     $��20��6   $��20��5�     $��49,0,0,0q�5�     $
��Left=�5�     $	��Top=�5�     
���   � J� RenderTransformOrigin$ 0.421,-0.389&�5�  "   ��5�     �� *AligmentCheckState+#	 [  5�  "   5�     �� 5�     $��	10,10,0,0q�6   $ 
Horizontal=�6-   $��Stretch=�6G   $
��auto��6e   $	��Top=�6s   .+�5�     �� $��0,0,0,0q�6   $
��Left=�6-   $��Crack Check��6{    6H   �� *CrackCheckState+$ OneWay=� 5�     �� 5�     $	 1.5Q�6)   $	 1.5Q�66   
 5�       5�     $ Checked��6)   . 5�        64   �� *CrackCheckSelectedCommand+5�       5�     $ 	Unchecked��6)   . 5�        64   �� *CrackCheckNotSelectedCommand+5�     5�     A� 5�     $��20��6   $��20��5�     $��88,0,0,0q�5�     $
��Left=�5�     $	��Top=�5�     
���   �$ 0.421,-0.389&�5�  "   ��5�     �� *CrackCheckState+#	 [  5�  "   5�     �� 5�     $��	10,10,0,0q�6   $ 
Horizontal=�6.   $��Stretch=�6H   $
��auto��6f   $	��Top=�6t   .+�5�     �� $��0,0,0,0q�6   $
��Left=�6-   $��
Dust Check��6{    6H   �� *DustCheckState+$ OneWay=� 5�     �� 5�     $	 1.5Q�6)   $	 1.5Q�66   
 5�       5�     $ Checked��6)   . 5�        64   �� *DustCheckSelectedCommand+5�       5�     $ 	Unchecked��6)   . 5�        64   �� *DustCheckNotSelectedCommand+5�     5�     A� 5�     $��20��6   $��20��5�     $��96,0,0,0q�5�     $
��Left=�5�     $	��Top=�5�     
���   �$ 0.421,-0.389&�5�  "   ��5�     �� *DustCheckState+#	 [  5�  "   5�     5�     �� 5�  
   $��1��6   $
��Left=�6%   $	��200��6@   $	��Top=�6M   $	��327��6e   .+�5�     �� $��Production Counter��6   $��Center=�61   $��0,2,0,0q�6N   $	��Top=�6_   $
��auto��6w   $
��auto��6�   $��16(�6�   $��Center=�6�   $��0q�6�   $
��Bold"�6�   $��0q�6�   �� 5�     
�������$��	10,2,10,0q�60   $ 
Horizontal=�6C   $��Stretch=�6]   $
��auto��6{   $	��Top=�6�   .+�5�     �� $�� Selected Part ��6   $
��Left=�62   $��10,0,0,0q�6M   $��Center=�6_   $
��auto��6z   $	��125��6�   $��16(�6�   $
��Left=�6�   $��0q�6�   $
��Bold"�6�   $��2q�6�   ���	#FFE8EAEF6�   �� 5�     $��Stretch=�5�     $��10,0,0,0q�5�     $��Center=�5�     $��16(�5�     $��SemiBold"�5�  3   $	��150��6I   ��6   �� *Productselected+6I   5�     �� 5�     
�������$��	10,2,10,0q�60   $ 
Horizontal=�6C   $��Stretch=�6]   $
��auto��6{   $	��Top=�6�   .+�5�     �� $�� Total Part ��6   $
��Left=�6/   $��10,0,0,0q�6J   $��Center=�6\   $
��auto��6w   $	��125��6�   $��16(�6�   $
��Left=�6�   $��0q�6�   $
��Bold"�6�   $��2q�6�   ���	#FFE8EAEF6�   �� 5�     $��Stretch=�5�     $��10,0,0,0q�5�     $��Center=�5�     $��16(�5�     $��SemiBold"�5�  -   $	��150��6C   ��6   �� *	TotalPart+6C   5�     �� 5�     
�������$��	10,2,10,0q�60   $ 
Horizontal=�6C   $��Stretch=�6]   $
��auto��6{   $	��Top=�6�   .+�5�     �� $�� Good Part ��6   $
��Left=�6.   $��10,0,0,0q�6I   $��Center=�6[   $
��auto��6v   $	��125��6�   $��16(�6�   $
��Left=�6�   $��0q�6�   $
��Bold"�6�   $��2q�6�   ���	#FFE8EAEF6�   �� 5�     $��Stretch=�5�     $��10,0,0,0q�5�     $��Center=�5�     $��16(�5�     $��SemiBold"�5�  ,   $	��150��6B   ��6   �� *
GoodPart+6B   5�     �� 5�     
�������$��	10,2,10,0q�60   $ 
Horizontal=�6C   $��Stretch=�6]   $
��auto��6{   $	��Top=�6�   .+�5�     �� $�� Not Good Part ��6   $
��Left=�62   $��10,0,0,0q�6M   $��Center=�6_   $
��auto��6z   $	��125��6�   $��16(�6�   $
��Left=�6�   $��0q�6�   $
��Bold"�6�   $��2q�6�   ���	#FFE8EAEF6�   �� 5�     $��Stretch=�5�     $��10,0,0,0q�5�     $��Center=�5�     $��16(�5�     $��SemiBold"�5�  /   $	��150��6E   ��6   �� *NotGoodPart+6E   5�     �� 5�     -   5        $ button_production_reset��5�     #��[ 5�     
���  ��$��Production Reset��5�  A   $��Center=�6\   $��0,2,0,0q�6y   $	��Top=�6�   $	��306��6�   $��25��6�   $��2��6�   
��� ���$��2q�5�     ��5�  �   �� *ShorterMoveing+#	 [  ��5�     �� *ProductionResetCommand+$ OneWay=�5�     5      5     5     