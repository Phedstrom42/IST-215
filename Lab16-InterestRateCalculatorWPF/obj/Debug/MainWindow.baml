   M S B A M L   `   `   `  ����Z  VLab16-InterestRateCalculatorWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Lab16_InterestRateCalculatorWPFLab16_InterestRateCalculatorWPF  5   	   0    *Lab16_InterestRateCalculatorWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:Lab16_InterestRateCalculatorWPF     5   	     � Title$  Interest Rate Calculator��5   	   $��303.333��6*   $	��525��6;   .��5	      �  J� RenderTransformOrigin$ 0.597,0.362&�6   .+�5
   
   �� -   5         ��Name$ gbInput��5
      $��Input��6$   $
��Left=�63   $	��Top=�6N   $��	42,28,0,0q�6f   $	��120��6y   $	��176��6�   .��5      � $
��Left=�6   $	��100��6.   $��0,3,-2,0q�6;   $	��Top=�6M   $	��166��6e   .+�5      �� -   5         ��Name$ lblPrinciple��5      $��	Principle��6.   $
��Left=�6B   $��10,7,0,0q�6]   $	��Top=�6o   �� 5      -   5        $ lblInterest��5      $��Interest��6-   $
��Left=�6@   $��	10,35,0,0q�6[   $	��Top=�6n   �� 5      -   5        $ lblYears��5      $��Years��6*   $
��Left=�6:   $��	10,64,0,0q�6U   $	��Top=�6h   �� 5      -   5         ��Name$ txtPrinciple��5      $
��Left=�60   $��23��6K   $��	71,10,0,0q�6W    �� TextWrapping$
 Wrap=�6j   $�� ��6~   $	��Top=�6�   $��85��6�   �� 5      -   5        $ txtInterest��5      $
��Left=�6/   $��23��6J   $��	71,38,0,0q�6V   $
 Wrap=�6i   $�� ��6}   $	��Top=�6�   $��85��6�   �� 5      -   5        $ txtYears��5      $
��Left=�6,   $��23��6G   $��	71,67,0,0q�6S   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $��85��6�   5      5      �� 5   
   -   5        $ gbFrequency��5      $��Compound Frequency��6(   $
��Left=�6D   $��
238,28,0,0q�6_   $	��Top=�6s   $	��129��6�   $	��154��6�   .��5      � $
��Left=�6   $	��101��6.   $	��Top=�6;   $	��125��6S   .+�5      	� -	   5         	�Name$ 	rbMonthly��5      $��Monthly��61   $
��Left=�6C   $��	19,10,0,0q�6^   $	��Top=�6q   	� 5      -
   5        $ rbQuarterly��5      $��	Quarterly��63   $
��Left=�6G   $��	19,30,0,0q�6b   $	��Top=�6u   	� 5      -   5        $ rbSemiAnnually��5      $��Semi-Annually��66   $
��Left=�6N   $��	19,50,0,0q�6i   $	��Top=�6|   	� 5      -   5        $ 
rbAnnually��5      $��Annually��62   $
��Left=�6E   $��	19,70,0,0q�6`   $	��Top=�6s   5      5      �� 5   
   -   5         ��Name$ btnCalculate��5      $��	Calculate��6'   $
��Left=�6;   $��
413,56,0,0q�6V   $	��Top=�6j   $��75��6�   6�   �� 5   
   -   5        $ btnClose��5      $��Close��6#   $
��Left=�63   $��
413,93,0,0q�6N   $	��Top=�6b   $��75��6z   6�   �� 5   
   -   5        $ 	gbResults��5      $��Results��6&   $
��Left=�67   $��
42,172,0,0q�6R   $	��Top=�6f   $��61��6~   $	��446��6�   .��5       � .+�5!      �� -   5        $ lblInterestEarned��5!      $��Interest Earned��63   $
��Left=�6M   $��10,2,0,0q�6h   $	��Top=�6z   �� 5"      -   5        $ txtInterestEarned��5"      $
��Left=�65   $��
105,10,0,0q�6P   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $��95��6�   �� 5#      -   5        $ lblCurrentValue��5#      $��Current Value��61   $
��Left=�6I   $��	226,2,0,0q�6d   $	��Top=�6w   �� 5$      -   5        $ txtCurrentValue��5$      $
��Left=�63   $��
313,10,0,0q�6N   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��111��6�   5%      5&      5'      5(      