﻿#pragma checksum "..\..\..\Views\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9098216D4D5E3E50068F752E22E96729F381A74BF78FCC4FE47693207890454E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Expression.Interactivity.Core;
using Prism.Interactivity;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Regions.Behaviors;
using SimpleHmi.Converters;
using SimpleHmi.Designer;
using SimpleHmi.ViewModels;
using SimpleHmi.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace SimpleHmi.Views {
    
    
    /// <summary>
    /// MainPage
    /// </summary>
    public partial class MainPage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 92 "..\..\..\Views\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Views\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Copy;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\Views\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_roter_position;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\Views\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Rotery_Position_Positive;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\..\Views\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Rotery_Position_Negative;
        
        #line default
        #line hidden
        
        
        #line 193 "..\..\..\Views\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Rotery_Position_position;
        
        #line default
        #line hidden
        
        
        #line 210 "..\..\..\Views\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Shorter_Positive;
        
        #line default
        #line hidden
        
        
        #line 222 "..\..\..\Views\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Shorter_Negative;
        
        #line default
        #line hidden
        
        
        #line 253 "..\..\..\Views\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Shorter_position;
        
        #line default
        #line hidden
        
        
        #line 358 "..\..\..\Views\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Homing_Shorter;
        
        #line default
        #line hidden
        
        
        #line 364 "..\..\..\Views\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Homing;
        
        #line default
        #line hidden
        
        
        #line 370 "..\..\..\Views\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_roter_Homing;
        
        #line default
        #line hidden
        
        
        #line 379 "..\..\..\Views\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Alignment_Test;
        
        #line default
        #line hidden
        
        
        #line 385 "..\..\..\Views\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Crack_Check;
        
        #line default
        #line hidden
        
        
        #line 391 "..\..\..\Views\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Dust_Check;
        
        #line default
        #line hidden
        
        
        #line 508 "..\..\..\Views\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_production_reset;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SimpleHmi;component/views/mainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MainPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.button = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.button_Copy = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.button_roter_position = ((System.Windows.Controls.Button)(target));
            
            #line 135 "..\..\..\Views\MainPage.xaml"
            this.button_roter_position.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.button_Rotery_Position_Positive = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.button_Rotery_Position_Negative = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.button_Rotery_Position_position = ((System.Windows.Controls.Button)(target));
            
            #line 194 "..\..\..\Views\MainPage.xaml"
            this.button_Rotery_Position_position.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.button_Shorter_Positive = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.button_Shorter_Negative = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.button_Shorter_position = ((System.Windows.Controls.Button)(target));
            
            #line 254 "..\..\..\Views\MainPage.xaml"
            this.button_Shorter_position.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.button_Homing_Shorter = ((System.Windows.Controls.Button)(target));
            
            #line 359 "..\..\..\Views\MainPage.xaml"
            this.button_Homing_Shorter.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.button_Homing = ((System.Windows.Controls.Button)(target));
            
            #line 365 "..\..\..\Views\MainPage.xaml"
            this.button_Homing.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.button_roter_Homing = ((System.Windows.Controls.Button)(target));
            
            #line 371 "..\..\..\Views\MainPage.xaml"
            this.button_roter_Homing.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.button_Alignment_Test = ((System.Windows.Controls.Button)(target));
            
            #line 380 "..\..\..\Views\MainPage.xaml"
            this.button_Alignment_Test.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.button_Crack_Check = ((System.Windows.Controls.Button)(target));
            
            #line 386 "..\..\..\Views\MainPage.xaml"
            this.button_Crack_Check.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.button_Dust_Check = ((System.Windows.Controls.Button)(target));
            
            #line 392 "..\..\..\Views\MainPage.xaml"
            this.button_Dust_Check.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.button_production_reset = ((System.Windows.Controls.Button)(target));
            
            #line 509 "..\..\..\Views\MainPage.xaml"
            this.button_production_reset.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

