   M S B A M L   `   `   `  ����D  @PspClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PspClient.ViewPspClient.View  5   	   (    "PspClient.View.DeleteStudentWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PspClient.View     5   	     � Title$%  Удалить студента��5   	   $	��140��6"   $	��350��6/    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � SizeToContent$ Manual=�6   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��Center=�5      $��0,0,0,10q�5      $
��Wrap=�5      $^��XВведите ID студента, которого необходимо удалить��5      �� 5   
   -   5        $��DeleteStudentIDInput��5      $��1��5      $��Stretch=�5      $��0,0,0,10q�5       �� TextWrapping$
 Wrap=�5      �� 5   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   .+�5       �� -   5         ��Name$ DeleteButton��5       $��Удалить��6+   $��5q�6=   $��80��6c   �� 5!      -   5        $��Отмена��5!      $��5q�6&   $��80��6L   5"      5#      5$      