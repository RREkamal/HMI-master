   M S B A M L   `   `   `  ����D  @SimpleHmi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SimpleHmi.ConvertersSimpleHmi.Converters  5   	   ;"clr-namespace:SimpleHmi.ViewModelsSimpleHmi.ViewModels  5   	   S OSimpleHmi.Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulleHclr-namespace:SimpleHmi.Infrastructure;assembly=SimpleHmi.InfrastructureSimpleHmi.Infrastructure 5	   	        SimpleHmi.Views.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   9
Converters"clr-namespace:SimpleHmi.Converters     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1vm"clr-namespace:SimpleHmi.ViewModels     5   	   P LPrism.Wpf, Version=6.2.0.0, Culture=neutral, PublicKeyToken=91a96d2a154366d8$prismhttp://prismlibrary.com/  5   	   ]infrastructureHclr-namespace:SimpleHmi.Infrastructure;assembly=SimpleHmi.Infrastructure  5	   	   !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  .  � Title$ Reed Relay Test System��5   	   $
��1280��5   	   $	��800��5   	    � WindowState$ 	Maximized=�5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��0��6&   &   SimpleHmi.Infrastructure.Regions   LeftMenuRegion!  Prism.Regions.RegionManager   
RegionName# Z 66   �� 5   
   $��0��6   $��1��6&      ContentRegion# Z 66   �� 5   
   $��1��6   $��2��6&      StatusBarRegion# Z 6:   �� 5      $��0��6   		 �� X1$	 0��6    	
 �� Y1$
 0��6'   	 �� X2$ 1��6.   	 �� Y2$ 0��66   $��2��6=   $	��Top=�6Q   
���  ��$��2��5       �� Stretch$ Uniform=�60   6D   5      5      