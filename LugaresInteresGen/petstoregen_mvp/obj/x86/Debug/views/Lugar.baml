   M S B A M L   `   `   `  ����  PetstoreGen_PageController'    !LugaresInteresGen_MVP.views.Lugar   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5        $��LugaresDeInteres��5        N� Title$  Lugares��6   .��5
      � $	��968��6   $
��auto��6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dataGridLugar��5   �      AutoGenerateColumns .     
IsReadOnly . $
��auto��6A   $��Center=�6O   $
��Left=�6s   $��
72,229,0,0q�6�   $	��Top=�6�   $	��760��6�   $��11(�6�      	RowHeight$ 40Q�6�   ���	#72BFD859��6  ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *Nombre+  5      $
 Tipo��6%   $	 150 63    6?   �� *Tipo+  5      $ 	Poblacion��6%   $	 150 68    6D   �� *	Poblacion+4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 Foto��6)   $	 300 67      
IsReadOnly . 	   CellTemplate	 5      �� 5      .R�5      �� ��6$   �� *ImageSource+5      5      5      �� 5   
   -   5        $��label1��5   \   $��Todos los lugares��6   $
��Left=�6,   $��20,33,0,406q�6G   $	��254��6j   $��26(�6v   �� 5   
   -   5        $��tabControl1��5   Q   $	��131��6   $
��Left=�6"   $��
656,50,0,0q�6=   $	��Top=�6d   $	��259��6|   ���#a9b604.@�5!      �� -   5        $��tabItem1��5!   (   $��	Búsqueda��6   .��5"      � .+�5#      �� -   5        $��buscar��5#   X   $��23��6   $
��Left=�6*   $��	16,21,0,0q�6E   $	��Top=�6f   $	��207��6~   �� 5$      -   5        $��button2��5$   l   $��
Por nombre��6   $��23��62   $
��Left=�6>   $��	16,61,0,0q�6Y   $	��Top=�6{   $��86��6�   6�   �� 5%      -   5        $��button1��5%   p   $��Por localidad��6   $��23��65   $
��Left=�6A   $��
137,61,0,0q�6\   $	��Top=�6   $��86��6�   5&      5'      5(      5)      5*      