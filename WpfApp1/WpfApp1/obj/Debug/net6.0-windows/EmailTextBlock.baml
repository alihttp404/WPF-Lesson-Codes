   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.EmailTextBlock   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5      -   5          >�Name$  CONTROL��5   7   .��5	      � .+�5
   
   �� -   5         ��Name$ EmailTextBlock_��5      
�������$��Email��5      $��10 5 0 0q�5      ��5      ��  �� ElementName$ CONTROL�� �� Path$ FontSize���5      �� $ CONTROL��$ HorizontalAlignment���5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � y� �� Value$ 	Collapsed=�63    �� Triggers 5      �� 5       �� Binding 6&   �� $ EmailTextBox��$
 Text�	 �� Value	  6^   .a�5      ��  � y�$ Visible=�6;   5      5      5      �� 5   
   -   5        
 ��Name$
 EmailTextBox��5!      
������ $��0q�5       5!      �� 5#   
   
����  �$	��300��5%      $��50��5&      $��Email��5)      ��5'      �� $ EmailTextBlock_��$ HorizontalAlignment���5(      �� $ EmailTextBlock_��$ VerticalAlignment�5+      5,      5-      