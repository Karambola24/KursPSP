   M S B A M L   `   `   `  ����D  @PspClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PspClient.ViewPspClient.View  5   	   (    "PspClient.View.AddDisciplineWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PspClient.View     5   	     � Title$+  %Добавить дисциплину��5   	   $	��250��6%   $	��400��62    � WindowStartupLocation$ CenterScreen=�5	   	   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $,��&Название дисциплины:��6   $
��Bold"�60   $��14(�6B   $��Center=�6P   �� 5   
   -   5         ��Name$ NameTextBox��5      $��1��6'   $��0,5,0,20q�64   $��30��6F   �� 5   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   .+�5      �� -   5         ��Name$ 	AddButton��5      $��Добавить��6(   $��80��6;   $
��10,0q�6F   6T   �� 5      -   5        $��Отмена��5      $��80��6&   $
��10,0q�61   6?   5      5      5      