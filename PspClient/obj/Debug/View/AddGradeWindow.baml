   M S B A M L   `   `   `  ����D  @PspClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PspClient.ViewPspClient.View  5   	   #    PspClient.View.AddGradeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PspClient.View     5   	     � Title$#  Добавить Оценку��5      $	��350��6    $	��400��6-    � WindowStartupLocation$ CenterScreen=�5	   	   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��ID Студента:��6   $
��Bold"�6(   $��14(�6:   $��Center=�6H   �� 5   
   -   5         ��Name$ IDStudentTextBox��5      $��1��6,   $��0,5,0,10q�69   $��30��6K   �� 5   
   $��ID Дисциплины:��6   $
��Bold"�6*   $��14(�6<   $��Center=�6J   $��2��6e   �� 5   
   -   5        $ IDDisciplineTextBox��5      $��3��6/   $��0,5,0,10q�6<   $��30��6N   �� 5   
   $��Оценка:��6   $
��Bold"�6#   $��14(�65   $��Center=�6C   $��4��6^   �� 5   
   -   5        $ GradeValueTextBox��5      $��5��6-   $��0,5,0,40q�6:   $��30��6L   �� 5   
   $��6��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��0,10,0,0q�6X   .+�5       �� -   5         ��Name$ 	AddButton��5       $��Добавить��6(   $��80��6;   $
��10,0q�6F   $��26��6l   �� 5!      -   5        $��Отмена��5!      $��80��6&   $
��10,0q�61   $��26��6Z   5"      5#      5$      