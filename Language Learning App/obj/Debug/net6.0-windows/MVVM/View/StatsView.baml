   M S B A M L   `   `   `  ����P  LLanguage Learning App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Language_Learning_App.MVVM.ViewLanguage_Learning_App.MVVM.View  5      [2clr-namespace:Language_Learning_App.MVVM.ViewModel$Language_Learning_App.MVVM.ViewModel  5      /    )Language_Learning_App.MVVM.View.StatsView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:Language_Learning_App.MVVM.View     5      H	viewModel2clr-namespace:Language_Learning_App.MVVM.ViewModel     5        � DataContext  5      9   3Language_Learning_App.MVVM.ViewModel.StatsViewModel  5   
   6%   .��5      �� $��
20,0,20,20q�6   .+�5   
   �� 
�������$��28(�5      $
��Left=�5      $��0,0,0,20q�5      ��5      �� *Header+5      � 5   
    � ColumnDefinitions 5      �� 5      6%   �� 5      6%   �� 5      6%   .+�5      �� .+�5      �� $��
Completion��6   
�������$��18(�5!      $��Center=�5"      5#      �� 5$      
�������$��18(�5&      $��Center=�5'      ��5$      �� *CompletionPercent+5(      5)      �� 5+      $��1��6   .+�5,      �� $��	Successes��6   
�������$��18(�5.      $��Center=�5/      50      �� 51      
�������$��18(�53      $��Center=�54      ��51      �� *User.SuccessCount+55      56      �� 58      $��2��6   .+�59      �� $��Fails��6   
�������$��18(�5;      $��Center=�5<      5=      �� 5>      
�������$��18(�5@      $��Center=�5A      ��5>      �� *User.FailCount+5B      5C      5D      �� 5F   
   $��Daily Stats��6   
�������$��28(�5H      $
��Left=�5I      $��	0,20,0,20q�5J      5K      �� 5M   
   $��Hidden=�6   $	��300��5N      .��5O      ��    SessionTemplate#��[  5P      
�������
������ $��Stretch=�5S      ��5O      �� *
Sessions+5T      5U      5V      5W      