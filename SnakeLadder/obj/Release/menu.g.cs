﻿#pragma checksum "..\..\menu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "258BDE9F48F71F5740282B3F85E0E4231EDC424760B1CDC65DBD60A3B9DEF06E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
using SnakeLadder;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
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


namespace SnakeLadder {
    
    
    /// <summary>
    /// menu
    /// </summary>
    public partial class menu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridPP;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button info;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox here;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Dice;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Imagin;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock message1;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lablePlayers;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox How_much;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock its;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit;
        
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
            System.Uri resourceLocater = new System.Uri("/SnakeLadder;component/menu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\menu.xaml"
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
            this.GridPP = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.info = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\menu.xaml"
            this.info.Click += new System.Windows.RoutedEventHandler(this.info_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.here = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.Dice = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\menu.xaml"
            this.Dice.Click += new System.Windows.RoutedEventHandler(this.Dice_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Imagin = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.message1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.lablePlayers = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.How_much = ((System.Windows.Controls.ComboBox)(target));
            
            #line 86 "..\..\menu.xaml"
            this.How_much.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.How_much_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.its = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\menu.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.exit = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\menu.xaml"
            this.exit.Click += new System.Windows.RoutedEventHandler(this.exit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

